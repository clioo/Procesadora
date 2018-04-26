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
    public partial class frmHistorialProduccionLotes : Form
    {
        Conexion conexion = new Conexion();
        String sql = "SELECT dbo.Lotes.ID_Lote AS ID, dbo.Producto_Descripcion.Nombre, dbo.Productos.Presentacion, dbo.Empleados.Nombre + N' ' + dbo.Empleados.ApellidoPaterno + N' ' + dbo.Empleados.ApellidoMaterno AS Encargado, dbo.Lotes.CantidadProducida AS Cantidad, dbo.Lotes.FechaProduccion AS Producción, dbo.Lotes.FechaCaducidad AS Caducidad, dbo.Lotes.CostoUnitarioFab AS [Costo Unitario] FROM dbo.Lotes INNER JOIN dbo.Productos ON dbo.Lotes.ID_Producto = dbo.Productos.ID_Producto INNER JOIN dbo.Producto_Descripcion ON dbo.Productos.ID_ProdDescripcion = dbo.Producto_Descripcion.ID_ProdDescripcion INNER JOIN dbo.Empleados ON dbo.Lotes.ID_Empleado = dbo.Empleados.ID_Empleado";
        public frmHistorialProduccionLotes()
        {
            InitializeComponent();
        }
        public String ID_Producto { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtProductos = new DataTable();
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID del lote", "dbo.Lotes.ID_Lote");
            dt.Rows.Add("Nombre del producto", "Nombre");
            dt.Rows.Add("Fecha de producción", "Producción");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dtProductos = conexion.Select("*", "V_Productos");
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            if (cbBuscarPor.SelectedValue.ToString() == "Producción") dtp_prod.Visible = true;
            else dtp_prod.Visible = false;
        }
        private void buscar() 
        {
            if (!(txtValor.Text == "") && cbBuscarPor.SelectedValue.ToString() != "Producción")
            {
                dgvProductos.DataSource = conexion.Select(sql + " where " + cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }
            else if (cbBuscarPor.SelectedValue.ToString() == "Producción")
            {
                dgvProductos.DataSource = conexion.Select(sql + " where lotes.FechaProduccion = " + comillas(dtp_prod.Text));
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
            else if (cbBuscarPor.SelectedValue.ToString() == "dbo.Lotes.ID_Lote")
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
                ID_Producto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dtp_prod_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
