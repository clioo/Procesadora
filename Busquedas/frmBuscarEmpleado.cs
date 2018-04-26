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
    public partial class frmBuscarEmpleado : Form
    {
        Conexion conexion = new Conexion();
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }
        public String ID_Empleado { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtProductos = new DataTable();
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID del empleado", "ID");
            dt.Rows.Add("Nombre del empleado", "Nombre");
            dt.Rows.Add("Sucursal", "Sucursal");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dtProductos = conexion.Select("*", "V_Empleados");
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
                dgvProductos.DataSource = conexion.Select("*", "V_Empleados", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }
            
        }

        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }


        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "Nombre" || cbBuscarPor.SelectedValue.ToString() == "Sucursal")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "ID")
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
            if (MessageBox.Show("¿" + dgvProductos.CurrentRow.Cells[1].Value.ToString() + " es el producto que necesita?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ID_Empleado = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
