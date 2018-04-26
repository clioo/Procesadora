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
    public partial class frmCancelarCOmpra : Form
    {
        Conexion conexion = new Conexion();
        public frmCancelarCOmpra()
        {
            InitializeComponent();
        }

        private void frmCancelarCOmpra_Load(object sender, EventArgs e)
        {
            frmBuscarCompraCredito buscarCompra = new frmBuscarCompraCredito();
            buscarCompra.cancompra = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdCompra.Text == "")
            {
                validador.SetError(txtIdCompra, "De click en la lupa y seleccione una orden de compra");
            }
            else
            {
                if (conexion.Update("Orden_Compra", "status =  'I'", "id_orden = " + txtIdCompra.Text))
                {
                    MessageBox.Show("Baja exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en base de datos");
                }
                
            }
        }
        private string com(string cad)
        {
            return "'" + cad + "'";
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenCompra c = new frmBuscarOrdenCompra();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtIdCompra.Text = c.id_orden;
            }
        }
    }
}
