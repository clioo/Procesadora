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
    public partial class frmMenuuuu : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmMenuuuu()
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

        }

     
        }
    }
