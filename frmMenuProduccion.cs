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
    public partial class frmMenuProduccion : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuProduccion()
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
            if (Globales.rango == "3")
            {
                cmdCalidad.Enabled = false;   
            }
            else if (Globales.rango == "2")
            {
                cmdHistorialProduccion.Enabled = false;
                cmdOrdenRetirarInsumo.Enabled = false;
                cmdRegistrarEmpleado.Enabled = false;
                cmdRegistrarProduccion.Enabled = false;
            }
            else if (Globales.rango == "1")
            {

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmRegistrarProduccionDeLote rp = new frmRegistrarProduccionDeLote();
            rp.Show();
        }

        private void cmdRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            frmRegistrarOrdenProduccion rop = new frmRegistrarOrdenProduccion();
            rop.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmReporteProduccionLotes c = new frmReporteProduccionLotes();
            c.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmConfirmarCalidadLote c = new frmConfirmarCalidadLote();
            c.Show();
        }

        private void cmdOrdenRetirarInsumo_Click(object sender, EventArgs e)
        {
            frmOrdenRetirarInsumos c = new frmOrdenRetirarInsumos();
            c.Show();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            frmRegistrarFalloMobiliario c = new frmRegistrarFalloMobiliario();
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
