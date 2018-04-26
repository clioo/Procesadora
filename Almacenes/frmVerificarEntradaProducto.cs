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
    public partial class frmVerificarEntradaProducto : Form
    {
        Conexion conexion = new Conexion();
        public frmVerificarEntradaProducto()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenRetirarProductos c = new frmBuscarOrdenRetirarProductos();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtOrden.Text = c.id_orden;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = conexion.Select1Valor("select status from ordenRetirarProductos where id_orden = " + txtOrden.Text);
            if (status == "")
            {
                MessageBox.Show("No existe esa orden");
            }
            else if (status =="A")
            {
                MessageBox.Show("El producto no ha salido de la sucursal de origen");
            }
            else if (status == "C")
            {
                frmEntradaProducto ep = new frmEntradaProducto(txtOrden.Text);
                ep.Show();
            }
            else if (status == "T")
            {
                MessageBox.Show("Ya se hizo la actualizacion de stock");
            }
        }
    }
}
