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
    public partial class frmVerificarPedido : Form
    {
        Conexion conexion = new Conexion();
        public frmVerificarPedido()
        {
            InitializeComponent();
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = conexion.Select1Valor("select estado from pedidos where id_pedido = " + txtOrden.Text);
            if (status == "")
            {
                MessageBox.Show("Este pedido no existe");
            }
            else if (status == "C")
            {
                MessageBox.Show("Ya se efectuó la compra de este pedido");
            }
            else if (status == "A")
            {
                //abrir formulario
                frmVentaPedido vp = new frmVentaPedido(txtOrden.Text);
                vp.Show();
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPedido bp = new frmBuscarPedido();
            if (bp.ShowDialog() == DialogResult.OK)
            {
                txtOrden.Text = bp.ID_Pedido;
            }
        }
    }
}
