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
    public partial class frmMenuVentas : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuVentas()
        {
            InitializeComponent();
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




        private void frmMenuRRHH_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Globales.nombre + " " + Globales.apellidoPaterno + " " + Globales.apellidoMaterno;
            lblPuesto.Text = conexion.Select1Valor("select nombre from puestos where id_puesto = " + Globales.puesto);
            if (Globales.ID_UsuarioL == conexion.Select1Valor("select id_empleadoEncargado from sucursales where id_sucursal = " + Globales.ID_SucursalL))
            {
                cmdEncargado.Visible = true;
            }
        }

        private void cmdRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            frmVentaGeneral vg = new frmVentaGeneral();
            vg.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cmdRegistrarPedido_Click(object sender, EventArgs e)
        {
            frmRegistrarPedido rp = new frmRegistrarPedido();
            rp.Show();
        }

        private void cmdCancelarPedido_Click(object sender, EventArgs e)
        {
            frmCancelarPedido cp = new frmCancelarPedido();
            cp.Show();
        }

        private void cmdVentaPedido_Click(object sender, EventArgs e)
        {
            frmVerificarPedido vp = new frmVerificarPedido();
            vp.Show();
        }

        private void cmdGenerarFactura_Click(object sender, EventArgs e)
        {
            frmGenerarFactura gf = new frmGenerarFactura();
            gf.Show();
        }

        private void cmdRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente rc = new frmRegistrarCliente();
            rc.Show();
        }

        private void cmdModificarCliente_Click(object sender, EventArgs e)
        {
            frmModificarCliente mc = new frmModificarCliente();
            mc.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmRegistrarCobro rc = new frmRegistrarCobro();
            rc.Show();
        }

        private void cmdEncargado_Click(object sender, EventArgs e)
        {
            frmMenuEncargado c = new frmMenuEncargado();
            c.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmReporteVentas c = new frmReporteVentas();
            c.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmReportesClientes c = new frmReportesClientes();
            c.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frmReporteStocksProductos c = new frmReporteStocksProductos();
            c.Show();
        }

     
        }
    }
