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
    public partial class FRM_Facturas : Form
    {
        Conexion conexion = new Conexion();
        public FRM_Facturas()
        {
            InitializeComponent();
        }

        private void FRM_Facturas_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("Cliente", "ID_Cliente");
            dt.Rows.Add("Fecha", "Fecha");
            dt.Rows.Add("Ticket", "Ticket");
            comboBox1.ValueMember = "nombreReal";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = dt;
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cliente")
            {
                frmBuscarCliente buscar = new frmBuscarCliente();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscar.ID_Cliente; //lee la propiedad
                    txt_valor.Text = nombre; //la pone en el título
                }
            }
            else if (comboBox1.Text == "Ticket")
            {
                frmBuscarVenta buscar = new frmBuscarVenta();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = buscar.ID_Venta; //lee la propiedad
                    txt_valor.Text = nombre; //la pone en el título
                }
            }
        }
        void Buscar()
        {
            if (comboBox1.Text == "Fecha") dgv.DataSource = conexion.Select("*", "V_Facturas_Desarrolladas", "fecha > '" + dtp_prod.Text + "' and Fecha < DATEADD(day, 1, '" + dtp_prod.Text + "');");
            else dgv.DataSource = conexion.Select("*", "V_Facturas_Desarrolladas", comboBox1.SelectedValue.ToString() + " like " + comillas(txt_valor.Text + "%"));
            dgv.Show();
        }
        private string comillas(string cadena) { return "'" + cadena + "'"; }
        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_valor.Clear();
            dgv.Visible = false;
            if (comboBox1.Text == "Fecha") { gbValor.Visible = false; gbfecha.Visible = true; } else { gbValor.Visible = true; gbfecha.Visible = false; }
        }

        private void dtp_prod_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
