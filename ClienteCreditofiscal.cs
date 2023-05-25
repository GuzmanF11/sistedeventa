using CapaEntidad;
using CapaNegocio;
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
    public partial class ClienteCreditofiscal : Form
    {
        public ClienteCreditofiscal()
        {
            InitializeComponent();
        }

        private void ClienteCreditofiscal_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Txto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Txto = "No Activo" });
            cboestado.DisplayMember = "Txto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Txto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Txto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<ClienteCreditoFiscal> lista = new CN_ClienteCreditoFiscal().Listar();

            foreach (ClienteCreditoFiscal item in lista)
            {

                dgvdata.Rows.Add(new object[] {"",item.IdClienteFiscal,item.Nombre,item.NIT,item.NumeroRegistro,item.Telefono,item.Direccion,item.Departamento,item.Municipio,
                 item.Estado == true ? 1:0,
                 item.Estado == true ? "Activo" : "No Activo"
            });

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            ClienteCreditoFiscal obj = new ClienteCreditoFiscal()
            {
                IdClienteFiscal = Convert.ToInt32(txtid.Text),
                Nombre = txtnombre.Text,
                NIT = txtnit.Text,
                NumeroRegistro = txtnoregistro.Text,
                Telefono = txttelefono.Text,
                Direccion = txtdireccion.Text,
                Departamento = txtdepartamento.Text,
                Municipio = txtmunicipio.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdClienteFiscal == 0)
            {
                int idgenerado = new CN_ClienteCreditoFiscal().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",idgenerado,txtnombre.Text,txtnit.Text,txtnoregistro.Text,txttelefono.Text,txtdireccion.Text,txtdepartamento.Text,txtmunicipio.Text,
                ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Txto.ToString()
           });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_ClienteCreditoFiscal().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Nit"].Value = txtnit.Text;
                    row.Cells["Noregistro"].Value = txtnoregistro.Text;
                    row.Cells["Telefono"].Value = txttelefono.Text;
                    row.Cells["Direccion"].Value = txtdireccion.Text;
                    row.Cells["Departamento"].Value = txtdepartamento.Text;
                    row.Cells["Municipio"].Value = txtmunicipio.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Txto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtnombre.Text = "";
            txtnit.Text = "";
            txtnoregistro.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtdepartamento.Text = "";
            txtmunicipio.Text = "";
            cboestado.SelectedIndex = 0;

            txtnombre.Select();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                txtindice.Text = indice.ToString();
                txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                txtnombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                txtnit.Text = dgvdata.Rows[indice].Cells["Nit"].Value.ToString();
                txtnoregistro.Text = dgvdata.Rows[indice].Cells["Noregistro"].Value.ToString();
                txttelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
                txtdireccion.Text = dgvdata.Rows[indice].Cells["Direccion"].Value.ToString();
                txtdepartamento.Text = dgvdata.Rows[indice].Cells["Departamento"].Value.ToString();
                txtmunicipio.Text = dgvdata.Rows[indice].Cells["Municipio"].Value.ToString();

                foreach (OpcionCombo oc in cboestado.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                    {

                        int indice_combo = cboestado.Items.IndexOf(oc);
                        cboestado.SelectedIndex = indice_combo;
                        break;

                    }
                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea Eliminar El Cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    ClienteCreditoFiscal obj = new ClienteCreditoFiscal()
                    {
                         IdClienteFiscal= Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new CN_ClienteCreditoFiscal().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
