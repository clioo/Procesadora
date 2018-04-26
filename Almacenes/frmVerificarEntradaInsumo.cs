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
    public partial class frmVerificarEntradaInsumo : Form
    {
        Conexion conexion = new Conexion();
        public frmVerificarEntradaInsumo()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCompra bc = new frmBuscarCompra();
            if (bc.ShowDialog() == DialogResult.OK)
            {
                txtOrden.Text = bc.id_compra;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = conexion.Select1Valor("select id_entrada from ingresoInsumo where id_compra = "+ txtOrden.Text);
            if (entrada == "")
            {
                frmEntradaInsumo ei = new frmEntradaInsumo(txtOrden.Text);
                ei.Show();
            }
            else
            {
                MessageBox.Show("Ya se ingresaron los insumos de esta compra");
            }
        }
    }
}
