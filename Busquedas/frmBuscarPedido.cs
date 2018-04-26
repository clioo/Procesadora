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
    public partial class frmBuscarPedido : Form
    {
        Conexion conexion = new Conexion();
        public frmBuscarPedido()
        {
            InitializeComponent();
        }
        public String ID_Pedido { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID del pedido", "[ID]");
            dt.Rows.Add("Cliente", "[Cliente]");
            dt.Rows.Add("Nombre del producto", "Producto");
            dt.Rows.Add("Fecha", "[Fecha estimada]");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvProductos.DataSource = conexion.Select("*", "v_pedidos","estado = 'A'");
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_fecha.Visible = false;
            txtValor.Visible = false;
            txt_fecha.Clear();
            txtValor.Clear();
            if (cbBuscarPor.SelectedValue.ToString() == "[Fecha estimada]") txt_fecha.Visible = true;
            else txtValor.Visible = true;
            buscar();
        }
        private void buscar()
        {
            if (!(txtValor.Text == "") && cbBuscarPor.SelectedValue.ToString() != "[Fecha estimada]")
            {
                dgvProductos.DataSource = conexion.Select("*", "v_pedidos", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }
            else if ((txt_fecha.Text.Length == 10) && cbBuscarPor.SelectedValue.ToString() == "[Fecha estimada]")
            {
                dgvProductos.DataSource = conexion.Select("*", "v_pedidos", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txt_fecha.Text.Substring(6, 4) + "-" + txt_fecha.Text.Substring(3, 2) + "-" + txt_fecha.Text.Substring(0, 2) + "%"));
            }
            else
            {
                dgvProductos.DataSource = conexion.Select("*", "v_pedidos");
            }

        }

        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }


        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "Producto" || cbBuscarPor.SelectedValue.ToString() == "[Cliente]")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "[ID]")
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

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿" + dgvProductos.CurrentRow.Cells[5].Value.ToString() + " es el pedido que necesita?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ID_Pedido = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
