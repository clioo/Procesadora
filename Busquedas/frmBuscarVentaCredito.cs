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
    public partial class frmBuscarVentaCredito : Form
    {
        public string id_venta;
        Conexion conexion = new Conexion();
        public frmBuscarVentaCredito()
        {
            InitializeComponent();
        }

        private void frmBuscarCompra_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID de cliente", "Clientes.ID_cliente");
            dt.Rows.Add("Nombre de Cliente o razón social", "Clientes.nombre");
            dt.Rows.Add("Fecha", "Venta.fecha");
            dt.Rows.Add("Número de ticket", "Venta.id_venta");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvCompras.DataSource = conexion.Select("Venta.id_venta,Clientes.id_cliente,Clientes.nombre,Venta.fecha",
                "Venta join Clientes on Clientes.ID_Cliente = Venta.id_cliente",
                " Venta.estado = 'F'");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "Clientes.ID_cliente" || cbBuscarPor.SelectedValue.ToString() == "Venta.id_venta")
            {

                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (cbBuscarPor.SelectedValue.ToString() == "Clientes.nombre")
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCompras.DataSource = conexion.Select("Venta.id_venta,Clientes.id_cliente,Clientes.nombre,Venta.fecha",
                "Venta join Clientes on Clientes.ID_Cliente = Venta.id_cliente",
                cbBuscarPor.SelectedValue.ToString() + " like " + com(txtValor.Text + "%' and Venta.estado = 'F"));
        }
        private string com(string cad) {
            return "'" + cad + "'";
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            if (cbBuscarPor.Text == "Fecha")
            {
                grpVALOR.Hide();
                grpFECHA.Show();
            }
            else
            {
                grpVALOR.Show();
                grpFECHA.Hide();
                buscarXfecha();
            }

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            buscarXfecha();
        }
        private void buscarXfecha() {
            dgvCompras.DataSource = conexion.Select("Venta.id_venta,Clientes.id_cliente,Clientes.nombre,Venta.fecha",
                "Venta join Clientes on Clientes.ID_Cliente = Venta.id_cliente",
           "fecha >=" + com(dtpDesde.Value.ToString("yyyyMMdd") + " 00:00:00") + "and fecha <=" + com(dtpHasta.Value.ToString("yyyyMMdd") + " 23:59:59.999' and Venta.estado = 'F"));
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            buscarXfecha();
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Es la venta que necesita?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                id_venta = dgvCompras.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
