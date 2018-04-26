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
    public partial class frmBuscarOrdenProduccion : Form
    {
        Conexion conexion = new Conexion();
        public frmBuscarOrdenProduccion()
        {
            InitializeComponent();
        }
        public String ID_Orden_Produccion { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID de la orden", "[ID Ordenes de lotes]");
            dt.Rows.Add("Producto", "Producto");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvProductos.DataSource = conexion.Select("*", "V_OrdenesLotes");
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            buscar();
        }
        private void buscar() 
        {
            if (!(txtValor.Text == ""))
            {
                dgvProductos.DataSource = conexion.Select("*", "V_OrdenesLotes", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }
            
        }

        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }


        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "Nombre")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "[ID del Producto]")
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
            if (MessageBox.Show("¿La orden " + dgvProductos.CurrentRow.Cells[0].Value.ToString() + " de " + dgvProductos.CurrentRow.Cells[1].Value.ToString() + " es la orden de producción que necesita?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ID_Orden_Produccion = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
