﻿using CapaEntidad;
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
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Txto = "Factura" });

            cbotipodocumento.DisplayMember = "Txto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

    

            cbogarantia.Items.Add(new OpcionCombo() { Valor = "Activo", Txto = "Activo" });
            cbogarantia.Items.Add(new OpcionCombo() { Valor = "No Activo", Txto = "No Activo" });
            cbogarantia.DisplayMember = "Txto";
            cbogarantia.ValueMember = "Valor";
            cbogarantia.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txttotalpagar.Text = "0";


        }


        private void cbotipodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void txtnregistro_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
        }

        private void txtnit_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
              using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {

                    txtdocumentocliente.Text = modal._Cliente.Documento;
                    txtnombrecliente.Text = modal._Cliente.NomnbreCompleto;
                    txtdireccion.Text = modal._Cliente.Direccion;
                    txttelefono.Text = modal._Cliente.Telefono;
                    txtdepartamento.Text = modal._Cliente.Departamento;
                    txtmunicipio.Text = modal._Cliente.Municipio;

                    txtcodproducto.Select();
                }
                else
                {
                    txtdocumentocliente.Select();
                }

            }

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text= modal._Producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.Nombre;
                    txtprecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtstock.Text = oProducto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtcantidad.Value = 1;
                }


            }
        }

        private void cbogarantia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string date = DateTime.UtcNow.ToString("d");
            DateTime fechafin = DateTime.Today;

            fechafin = fechafin.AddDays(30);
            

            if (cbogarantia.SelectedIndex == 0) 
            {

                datefechagaran.Enabled = true;

            }

            else 
                datefechagaran.Enabled = false;

            if (cbogarantia.SelectedIndex == 0)
            {

                datefechagaran.Text = fechafin.ToString("d");

            }

            else

                datefechagaran.Text = "";




        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                bool respuesta = new CN_Venta().RestarStock(
                   Convert.ToInt32(txtidproducto.Text),
                   Convert.ToInt32(txtcantidad.Value.ToString())
                   );

                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[] {
                        txtidproducto.Text,
                        txtproducto.Text,
                        precio.ToString("0.00"),
                        txtcantidad.Value.ToString(),
                        (txtcantidad.Value * precio).ToString("0.00"),
                          ((OpcionCombo)cbogarantia.SelectedItem).Valor.ToString(),
                           ((OpcionCombo)cbogarantia.SelectedItem).Txto.ToString(),
                           datefechagaran.Text



                    }); ;

                    calcularTotal();
                    limpiarProducto();
                    txtcodproducto.Select();
                }
               
            }


        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                
            }
            txttotalpagar.Text = total.ToString("0.00");
        }
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 8)
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }
                    }
                }
            }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtfechafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (txtdocumentocliente.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtnombrecliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));
            detalle_venta.Columns.Add("Garantia", typeof(string));
            detalle_venta.Columns.Add("FechaGarntia", typeof(string));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                    row.Cells["Garantia"].Value.ToString(),
                    row.Cells["FechaGarantia"].Value.ToString(),

                });
            }
            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);


            Venta oVenta = new Venta()
            {

                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocuemnto = ((OpcionCombo)cbotipodocumento.SelectedItem).Txto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtdocumentocliente.Text,
                NombreCliente = txtnombrecliente.Text,
                Direccion=txtdireccion.Text,
                Telefono= txttelefono.Text,
                Departamento= txtdepartamento.Text,
                Municipio= txtmunicipio.Text,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text),
     
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtdocumentocliente.Text = "";
                txtnombrecliente.Text = "";
                txttelefono.Text = "";
                txtdireccion.Text = "";
                txtdepartamento.Text = "";
                txtmunicipio.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txtgarantia.Text = "";
                datefechagaran.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        

    }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }


