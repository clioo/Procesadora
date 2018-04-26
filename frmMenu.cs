using System;
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
    public partial class frmMenu : Form
    {
        public frmLogIn login;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            login.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
           
            if (sidemenu.Width==10)
            {
                //Expandir
                sidemenu.Visible = true;
                sidemenu.Width = 1260;
                PanelTransition.ShowSync(sidemenu);
                //LogoTransition.ShowSync(Logo);
            }
            else
            {
                //Minimizar
                //LogoTransition.Hide(Logo);
                sidemenu.Visible = false;
                sidemenu.Width = 10;
                PanelTransition.ShowSync(sidemenu);
            }
        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnInsumos_Click(object sender, EventArgs e)
        {
            frmMenuProduccion v = new frmMenuProduccion();
            v.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            frmMenuVentas v = new frmMenuVentas();
            v.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdCompras_Click(object sender, EventArgs e)
        {
            frmMenuCompras v = new frmMenuCompras();
            v.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmMenuAlmacenes v = new frmMenuAlmacenes();
            v.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            frmMenuRRHH v = new frmMenuRRHH();
            v.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmRegistrarProveedor regProv = new frmRegistrarProveedor();
            regProv.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmMenuProduccion v = new frmMenuProduccion();
            v.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            frmMenuAdministracion v = new frmMenuAdministracion();
            v.Show();
        }
        }
    }
