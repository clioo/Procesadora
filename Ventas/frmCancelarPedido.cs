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
    public partial class frmCancelarPedido : Form
    {
        Conexion conexion = new Conexion();
        public frmCancelarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdPedido.Text == "")
            {
                validador.SetError(txtIdPedido, "De click en la lupa y seleccione un pedido");
            }
            else
            {
                if (conexion.Update("Pedidos", "estado = 'C'", "id_pedido = " + com(txtIdPedido.Text)))
                {
                    MessageBox.Show("Baja realizada con éxito");
                    this.Close();
                }
            }
        }
        private string com(string cad)
        {
            return "'" + cad + "'";
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPedido buscar = new frmBuscarPedido();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Pedido; //lee la propiedad
                txtIdPedido.Text = nombre; //la pone en el título
            }
        }

        private void frmCancelarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
