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
    public partial class frmReportesClientes : Form
    {
        Conexion conexion = new Conexion();
        public frmReportesClientes()
        {
            InitializeComponent();
        }

        private void frmReportesClientes_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID del cliente", "ID_Cliente");
            dt.Rows.Add("Nombre del Cliente", "Nombre");
            dt.Rows.Add("RFC", "RFC");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvClientes.DataSource = conexion.Select("ID_Cliente as ID, Nombre,RFC", "Clientes");
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (cbBuscarPor.SelectedValue.ToString() == "ID_Cliente")
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
            else
            {

            }
        }
        private void buscar()
        {
            if (!(txtValor.Text == ""))
            {
                dgvClientes.DataSource = conexion.Select("ID_Cliente as ID, Nombre,RFC", "Clientes", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }

        }

        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }
        private void cbBuscarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            buscar();
        }
    }
}
