using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using FontAwesome.Sharp;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem Menuactivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null) 
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> LiataPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach(IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = LiataPermisos.Any(m => m.NombreMneu == iconmenu.Name);

                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lbusuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFromulario(IconMenuItem menu, Form formulario)
        {
            if (Menuactivo !=null)
            {
                Menuactivo.BackColor = Color.Silver;
            }
            menu.BackColor = Color.White;
            Menuactivo = menu;

            if (FormularioActivo !=null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White; //FromArgb(49; 66; 82);

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }
   
        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuproductos, new frmCategoria());
        }

        private void menuproductos_Click(object sender, EventArgs e)
        {
        }

        private void submenuregistarcompra_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menucompras, new frmCompras(usuarioActual));
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuventas, new frmDetalleVenta());
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menucompras, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmReportes());
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menurol_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmrol());
        }

        private void administrarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menurol, new frmPermisos());
        }

        private void menuacerca_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmNegocio());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuproductos, new frmProducto());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void creditoFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuclientes, new frmClientes());
        }

        private void clienteCreditoFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuclientes, new ClienteCreditofiscal());
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuventas, new frmVentaCF(usuarioActual));
        }

        private void creditoFsicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuventas, new DetalleVentaCF());
        }
    }
}
