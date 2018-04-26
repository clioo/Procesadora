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
    public partial class frmReporteEmpleados : Form
    {
        Conexion conexion = new Conexion();
        public frmReporteEmpleados()
        {
            InitializeComponent();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmReporteEmpleados_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID del empleado", "ID");
            dt.Rows.Add("Nombre del empleado", "Nombre");
            dt.Rows.Add("Sucursal", "Sucursal");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvProductos.DataSource = conexion.Select("*", "V_EmpleadosA");
        }

        private void cbBuscarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            buscar();
        }
        private void buscar()
        {
            if (!(txtValor.Text == ""))
            {
                dgvProductos.DataSource = conexion.Select("*", "V_EmpleadosA", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }

        }

        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }
    }
}
