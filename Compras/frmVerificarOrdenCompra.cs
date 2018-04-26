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
    public partial class frmVerificarOrdenCompra : Form
    {
        Conexion conexion = new Conexion();
        public frmVerificarOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmBuscarOrden_Load(object sender, EventArgs e)
        {

        }

        private void txtIdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            string status = conexion.Select1Valor("select status from orden_compra where id_orden = " + "'" + txtIdCompra.Text + "'");
            string orden = conexion.Select1Valor("select id_orden from Orden_Compra where id_orden = " + txtIdCompra.Text);
            if (orden == "")
            {
                validador.SetError(txtIdCompra, "Esa orden de compra no existe");
            }
            else if (status == "C")
            {
                MessageBox.Show("Ya se registró una compra con esta orden");
            }
            else if (status == "I")
            {
                MessageBox.Show("Esa orden está inactiva");
            }
            else if (status == "ERROR")
            {
                MessageBox.Show("Error en base de datos");
            }
            else
            {
                frmRegistrarCompra regCom = new frmRegistrarCompra(orden);
                regCom.Show();
                this.Close();
            }
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
