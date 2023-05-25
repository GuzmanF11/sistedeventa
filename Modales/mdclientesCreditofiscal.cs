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

namespace CapaPresentacion.Modales
{
    public partial class mdclientesCreditofiscal : Form
    {
        public ClienteCreditoFiscal _ClienteCF { get; set; }
        public mdclientesCreditofiscal()
        {
            InitializeComponent();
        }

        private void mdclientesCreditofiscal_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Txto = columna.HeaderText });
            }

            cbobusqueda.DisplayMember = "txto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<ClienteCreditoFiscal> lista = new CN_ClienteCreditoFiscal().Listar();

            foreach (ClienteCreditoFiscal item in lista)
            {
                if (item.Estado)
                    dgvdata.Rows.Add(new object[] { item.Nombre, item.NIT,item.NumeroRegistro, item.Direccion, item.Telefono, item.Departamento, item.Municipio });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                _ClienteCF = new ClienteCreditoFiscal()
                {
                     NIT= dgvdata.Rows[iRow].Cells["NIT"].Value.ToString(),
                    Nombre = dgvdata.Rows[iRow].Cells["NombreCliente"].Value.ToString(),
                    NumeroRegistro = dgvdata.Rows[iRow].Cells["NoRegistro"].Value.ToString(),
                    Direccion = dgvdata.Rows[iRow].Cells["Direccion"].Value.ToString(),
                    Telefono = dgvdata.Rows[iRow].Cells["Telefono"].Value.ToString(),
                    Departamento = dgvdata.Rows[iRow].Cells["Departamento"].Value.ToString(),
                    Municipio = dgvdata.Rows[iRow].Cells["Municipio"].Value.ToString(),


                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
