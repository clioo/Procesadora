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
    public partial class frmVerificarOrdenRetirarProducto : Form
    {
        Conexion conexion = new Conexion();

        public frmVerificarOrdenRetirarProducto()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orden = conexion.Select1Valor("select id_orden from ordenRetirarProductos where id_orden = " + txtOrden.Text);
            string retiro = conexion.Select1Valor("select id_ordenRetirarProduct from retirarproductos where id_ordenRetirarProduct = " +  txtOrden.Text);
            if (orden == "")
            {
                validador.SetError(txtOrden, "Esa orden de retiro no existe no existe");
            }
            else
            {
                string status = conexion.Select1Valor("select status from ordenRetirarProductos where id_orden = " + txtOrden.Text);
                if (status =="A")
                {
                    frmRetirarProducto frp = new frmRetirarProducto(txtOrden.Text);
                    frp.Show();
                }
                else
                {
                    MessageBox.Show("Ya se efectuó un retiro con esta orden o se deshabilitó");
                }
            }
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenRetirarProductos c = new frmBuscarOrdenRetirarProductos();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtOrden.Text = c.id_orden;
            }
        }
    }
}
