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
    public partial class frmBuscarCompra : Form
    {
        public frmBuscarCompra()
        {
            InitializeComponent();
        }
        
        public string id_compra;
        Conexion conexion = new Conexion();
        private string comillas(string texto)
        {
            return "'" + texto + "'";
        }
        private void frmBuscarOrdenCompra_Load(object sender, EventArgs e)
        {
            dgvResultados.DataSource = conexion.Select("*", "v_compra", "estado = 'A'");
            DataTable dt = new DataTable();
            dt.Columns.Add("display");
            dt.Columns.Add("valor");
            dt.Rows.Add("Número de ticket", "numTicket");
            dt.Rows.Add("Número de factura", "numFactura");
            cbBuscarPor.ValueMember = "valor";
            cbBuscarPor.DisplayMember = "display";
            cbBuscarPor.DataSource = dt;
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (!(txtValor.Text == ""))
            {
                dgvResultados.DataSource = conexion.Select("*", "v_Compra", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Es la orden que necesita?", "Advertencia",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                id_compra = dgvResultados.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
    }
