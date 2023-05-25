using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {

        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
          
            
           
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Txto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Txto = "Factura" });
            cbotipodocumento.DisplayMember = "Txto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); 

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";

          


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidprove.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocumento.Text = modal._Proveedor.Documento;
                    txtnombrepro.Text = modal._Proveedor.Rubro;
                }
                else
                {
                    txtdocproveedor.Select();
                }

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproduc.Text = modal._Producto.IdProducto.ToString();
                    txtprocprodu.Text = modal._Producto.Codigo;
                    txtproduc.Text = modal._Producto.Nombre;
                    txtpreciocom.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

            }
        }

        private void txtprocprodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtprocprodu.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtprocprodu.BackColor = Color.Honeydew;
                    txtidproduc.Text = oProducto.IdProducto.ToString();
                    txtproduc.Text = oProducto.Nombre;
                    txtpreciocom.Select();
                }
                else
                {
                    txtprocprodu.BackColor = Color.MistyRose;
                    txtidproduc.Text = "0";
                    txtproduc.Text = "";
                }


            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproduc.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocom.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - debe ingresar el precio de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioven.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - debe ingresar el precio de venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            foreach (DataGridViewRow fila in dvgdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproduc.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                dvgdata.Rows.Add(new object[] {
                    txtidproduc.Text,
                    txtproduc.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcanti.Value.ToString(),
                    (txtcanti.Value * preciocompra).ToString("0.00")

                });

                calcularTotal();
                limpiarProducto();
                txtprocprodu.Select();

            }
        }
        private void limpiarProducto()
        {
            txtidproduc.Text = "0";
            txtprocprodu.Text = "";
            txtprocprodu.BackColor = Color.White;
            txtproduc.Text = "";
            txtpreciocom.Text = "";
            txtprecioven.Text = "";
            txtcanti.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dvgdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dvgdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalapagar.Text = total.ToString("0.00");
        }

        private void dvgdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete25.Width;
                var h = Properties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dvgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dvgdata.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtpreciocom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocom.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtprecioven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioven.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidprove.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dvgdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dvgdata.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString()
                    });

            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oPreveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidprove.Text) },
                TipoDocuemnto = ((OpcionCombo)cbotipodocumento.SelectedItem).Txto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal( txttotalapagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtidprove.Text = "0";
                txtdocumento.Text = "";
                txtnombrepro.Text = "";
                dvgdata.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtidprove_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotipodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (cbotipodocumento.SelectedIndex == 0)
           // {
          //      prueba.Enabled = true;
           // }

           // else
              //  prueba.Enabled = false;
        }

        private void txttotalapagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
