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
    public partial class frmMenuAlmacenes : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuAlmacenes()
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
                LogoTransition.ShowSync(Logo);
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
            if (Globales.rango == "1")
            {
                cmdEntradaInsumos.Enabled = false;
                cmdRetirarInsumo.Enabled = false;
            }
            else if (Globales.rango =="2")
            {
                cmdRegistrarEntradaProducto.Enabled = false;
                cmdRegistrarRetiroProducto.Enabled = false;
            }
        }

        private void cmdOrdenRetirarProducto_Click(object sender, EventArgs e)
        {
            frmOrdenRetirarProductos o = new frmOrdenRetirarProductos();
            o.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmVerificarEntradaProducto c = new frmVerificarEntradaProducto();
            c.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmVerificarEntradaInsumo c = new frmVerificarEntradaInsumo();
            c.Show();
        }

        private void cmdRetirarInsumo_Click(object sender, EventArgs e)
        {
            frmVerificarOrdenRetirarInsumo c = new frmVerificarOrdenRetirarInsumo();
            c.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmVerificarOrdenRetirarProducto c = new frmVerificarOrdenRetirarProducto();
            c.Show();
        }

        private void cmdEncargado_Click(object sender, EventArgs e)
        {
            frmMenuEncargado c = new frmMenuEncargado();
            c.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

     
        }
    }
