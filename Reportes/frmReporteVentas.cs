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
    public partial class frmReporteVentas : Form
    {
        Conexion conexion = new Conexion();
        public frmReporteVentas()
        {
            InitializeComponent();
        }
        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID de la venta", "Ticket");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvVentas.DataSource = conexion.Select("*", "v_venta_desarrollada");
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "nombreReal" || cbBuscarPor.SelectedValue.ToString() == "RFC")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "id_proveedor")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "Email")
            {
                e.Handled = false;
            }
        }
        private void buscar()
        {
            if (!(txtValor.Text == ""))
            {
                dgvVentas.DataSource = conexion.Select("*", "v_venta_desarrollada", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));

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
