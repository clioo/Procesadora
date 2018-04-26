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
    public partial class frmReportesCompras : Form
    {
        Conexion conexion = new Conexion();
        public frmReportesCompras()
        {
            InitializeComponent();
        }

        private void frmReportesCompras_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("Proveedor", "[ID del proveedor]");
            dt.Rows.Add("Fecha", "Fecha");
            dt.Rows.Add("ID de la compra", "[ID de Compra]");
            comboBox1.ValueMember = "nombreReal";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = dt;
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Proveedor")
            {
                frmBuscarProveedor buscar = new frmBuscarProveedor();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscar.ID_Proveedor; //lee la propiedad
                    txt_valor.Text = nombre; //la pone en el título
                }
            }
            else if (comboBox1.Text == "Ticket")
            {
                frmBuscarCompra buscar = new frmBuscarCompra();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscar.id_compra; //lee la propiedad
                    txt_valor.Text = nombre; //la pone en el título
                }
            }
        }

        private void dtp_prod_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_valor.Clear();
            dgv.Visible = false;
            if (comboBox1.Text == "Fecha") { gbValor.Visible = false; gbfecha.Visible = true; } else { gbValor.Visible = true; gbfecha.Visible = false; }
        }
        private string comillas(string cadena) { return "'" + cadena + "'"; }
        void Buscar()
        {
            if (comboBox1.Text == "Fecha") dgv.DataSource = conexion.Select("*", "V_Compras_Desarrolladas", "fecha > '" + dtp_prod.Text + "' and Fecha < DATEADD(day, 1, '" + dtp_prod.Text + "');");
            else dgv.DataSource = conexion.Select("*", "V_Compras_Desarrolladas", comboBox1.SelectedValue.ToString() + " like " + comillas(txt_valor.Text + "%"));
            dgv.Show();
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

    }
}
