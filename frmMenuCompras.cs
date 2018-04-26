using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Procesadora
{
    public partial class frmMenuCompras : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuCompras()
        {
            InitializeComponent();
            if (Globales.rango == "2")
            {
                cmdCancelarOrdenCompra.Enabled = false;
                cmdGenerarOrdenCompra.Enabled = false;

                
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
           
            if (sidemenu.Width==60)
            {
                //Expandir
                sidemenu.Visible = true;
                sidemenu.Width = 260;
                PanelTransition.ShowSync(sidemenu);
            }
            else
            {
     
            }
        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabRegEmpleado_Click(object sender, EventArgs e)
        {
            frmVerificarOrdenCompra voc = new frmVerificarOrdenCompra();
            voc.Show();
        }


        private void frmMenuRRHH_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Globales.nombre + " " + Globales.apellidoPaterno + " " + Globales.apellidoMaterno;
            lblPuesto.Text = conexion.Select1Valor("select nombre from puestos where id_puesto = " + Globales.puesto);
            if (Globales.ID_UsuarioL == conexion.Select1Valor("select id_empleadoEncargado from sucursales where id_sucursal = " + Globales.ID_SucursalL))
            {
                cmdEncargado.Visible = true;
            }
            if (Globales.rango == "2")
            {
                
            }
        }

        private void BtnInsumos_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado modEmpleado = new frmModificarEmpleado();
            modEmpleado.Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmCancelarCOmpra canc = new frmCancelarCOmpra();
            canc.Show();
        }

        private void tabRegistrarBonificacion_Click(object sender, EventArgs e)
        {
            frmRegistrarProveedor rp = new frmRegistrarProveedor();
            rp.Show();
        }

        private void tabRegistrarDescuento_Click(object sender, EventArgs e)
        {
            frmModificarProveedor mp = new frmModificarProveedor();
            mp.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmOrdenCompra oc = new frmOrdenCompra();
            oc.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmRegistrarPago rp = new frmRegistrarPago();
            rp.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            frmRegistrarInsumos ri = new frmRegistrarInsumos();
            ri.Show();
        }

        private void cmdCompraMobiliario_Click(object sender, EventArgs e)
        {
            frmCompraMobiliario cm = new frmCompraMobiliario();
            cm.Show();
        }

        private void cmdEncargado_Click(object sender, EventArgs e)
        {
            frmMenuEncargado c = new frmMenuEncargado();
            c.Show();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            frmReportesCompras c = new frmReportesCompras();
            c.Show();
        }





        
        }
    }
