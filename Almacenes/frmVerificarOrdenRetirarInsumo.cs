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
    public partial class frmVerificarOrdenRetirarInsumo : Form
    {
        Conexion conexion = new Conexion();
        public frmVerificarOrdenRetirarInsumo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            string status = conexion.Select1Valor("select status from ordenRetirarInsumos where id_orden = " + txtOrden.Text);
            if (status == "")
            {
                validador.SetError(txtOrden,"Esa orden no existe");
            }
            else if (status == "A")
            {
                //abrir formulario
                frmRetirarInsumo ri = new frmRetirarInsumo(txtOrden.Text);
                ri.Show();
            }
            else
            {
                validador.SetError(txtOrden,"Ya se hizo un retiro con esa orden o se inhabilitó");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenRetirarInsumo c = new frmBuscarOrdenRetirarInsumo();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtOrden.Text = c.id_orden;
            }
        }
    }
}
