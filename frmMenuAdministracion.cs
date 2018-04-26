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
    public partial class frmMenuAdministracion : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuAdministracion()
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
            if (Globales.ID_UsuarioL == conexion.Select1Valor("select id_empleadoEncargado from sucursales where id_sucursal = "+ Globales.ID_SucursalL))
            {
                cmdEncargado.Visible = true;
            }
        }

        private void cmdRegistrarSucursal_Click(object sender, EventArgs e)
        {
            frmRegistrarSucursal rs = new frmRegistrarSucursal();
            rs.Show();
        }

        private void cmdBajaSucursal_Click(object sender, EventArgs e)
        {
            frmBajaSucursal bs = new frmBajaSucursal();
            bs.Show();
        }

        private void cmdRegistrarReceta_Click(object sender, EventArgs e)
        {
            FrmRegistrarReceta rr = new FrmRegistrarReceta();
            rr.Show();
        }

        private void cmdModificarSucursal_Click(object sender, EventArgs e)
        {
            FrmModificarProducto mp = new FrmModificarProducto();
            mp.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto rp = new FrmRegistrarProducto();
            rp.Show();
        }

        private void cmdEncargado_Click(object sender, EventArgs e)
        {
            frmMenuEncargado c = new frmMenuEncargado();
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmReporteFactura c = new frmReporteFactura();
            c.Show();
        }

     
        }
    }
