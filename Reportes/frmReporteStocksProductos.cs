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
    public partial class frmReporteStocksProductos : Form
    {
        Conexion conexion = new Conexion();
        public frmReporteStocksProductos()
        {
            InitializeComponent();
        }

        private void frmReporteStocksProductos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("Producto", "ID");
            dt.Rows.Add("Precio", "Precio");
            dt.Rows.Add("Sucursal", "Nombre");
            comboBox1.ValueMember = "nombreReal";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            txt_valor.Clear();
            dgv.Visible = false;
            if (comboBox1.Text == "Precio") cmdBuscar.Enabled = false; else cmdBuscar.Enabled = true;
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text != "Precio")
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar.ToString() == "\b")
                {
                    e.Handled = false;
                }
            }
            else if (comboBox1.Text == "Precio")
            {
                if (txt_valor.Text.Contains("."))
                {
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar.ToString() == "\b")
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == "\b")
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Producto")
            {
                frmBuscarProducto buscar = new frmBuscarProducto();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscar.ID_Producto; //lee la propiedad
                    txt_valor.Text = nombre; //la pone en el título
                }
            }
            else if (comboBox1.Text == "Sucursal")
            {
                frmBuscarSucursal buscar = new frmBuscarSucursal();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscar.ID_Sucursal; //lee la propiedad
                    txt_valor.Text = nombre; //la pone en el título
                }
            }
        }
        private string comillas(string cadena) { return "'" + cadena + "'"; }
        void Buscar()
        {
            dgv.DataSource = conexion.Select("ID, Producto, Presentación, Cantidad, [Stock mínimo], Precio", "V_Stocks", comboBox1.SelectedValue.ToString() + " like " + comillas(txt_valor.Text + "%"));
            dgv.Show();
        }
        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
