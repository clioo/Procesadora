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
    public partial class frmMenuRRHH : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuRRHH()
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
                //Minimizar
                LogoTransition.Hide(Logo);
                sidemenu.Visible = false;
                sidemenu.Width = 60;
                PanelTransition.ShowSync(sidemenu);
            }
        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabRegEmpleado_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado regEmpleado = new FrmRegistrarEmpleado();
            regEmpleado.Show();
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
                cmdBajaEmpleado.Enabled = false;
                cmdModificarEmpleado.Enabled = false;
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
            frmRegistrarSucursal regSucursal = new frmRegistrarSucursal();
            regSucursal.Show();
        }

        private void tabRegistrarBonificacion_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmBajaEmpleados be = new frmBajaEmpleados();
            be.Show();
        }

        private void cmdBajaReactivarEmpleado_Click(object sender, EventArgs e)
        {
            frmReactivarEmpleado re = new frmReactivarEmpleado();
            re.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cmdEncargado_Click(object sender, EventArgs e)
        {
            frmMenuEncargado c = new frmMenuEncargado();
            c.Show();
            this.Close();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            frmReporteEmpleados c = new frmReporteEmpleados();
            c.Show();
        }





        
        }
    }
