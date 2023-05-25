using CapaEntidad;
using CapaNegocio;
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
    public partial class frmrol : Form
    {
        public frmrol()
        {
            InitializeComponent();
        }

        private void frmrol_Load(object sender, EventArgs e)
        {
            List<Rol> lista = new CN_Rol().Listar();

            foreach (Rol item in lista)
            {

                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdRol,
                    item.Descripcion,


            });

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
