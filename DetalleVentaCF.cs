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
    public partial class DetalleVentaCF : Form
    {
        public DetalleVentaCF()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DetalleVentaCF_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            VentaCF oVenta = new CN_VentaCF().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVentacf != 0)
            {

                txtnumerodocumento.Text = oVenta.NumeroDocumento;
                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocuemnto;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;
                txtgiro.Text = oVenta.Giro;
                txtcondicion.Text = oVenta.CondicionPago;



                txtdoccliente.Text = oVenta.NIT;
                txtnombrecliente.Text = oVenta.NombreCliente;
                txtdireccioncliente.Text = oVenta.Telefono;
                txtnumeroregitro.Text = oVenta.NumeroRegistro;
                txtdepartamento.Text = oVenta.Departamento;
                txttelefonocliente.Text = oVenta.Direccion;
                txtdepartamento.Text = oVenta.Departamento;
                txtmunicipio.Text = oVenta.Municipio;

                dgvdata.Rows.Clear();
                foreach (DetalleVentaCF_ dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.oDescripcion.Descripcion, dv.PrecioVenta, dv.Cantidad, dv.SubTotal, dv.garantia, dv.FechaGarantia });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtsuma.Text = oVenta.Suma.ToString("0.00");
                txtiva.Text = oVenta.Iva.ToString("0.00");


            }
        }
    }
}
