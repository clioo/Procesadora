using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Procesadora
{
    public partial class FrmRegistrarProducto : Form
    {
        FrmRegistrarReceta regreceta = new FrmRegistrarReceta();
        public int ID_Producto = 0;
        public int ID_ProductoDescripcion = 0;
        DataTable dt = new DataTable();
        Conexion conexion = new Conexion();
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (validar())
            {
                //conexion.Insert("Empleados", "",);
            }
        }
        private bool validar()
        {
            if (cbNombre.Text == "")
            {
                cbNombre.Focus();
                validador.SetError(cbNombre, "Ingrese o seleccione el nombre");
            }
            else if (txtPresentacion.Text == "")
            {
                txtPresentacion.Focus();
                validador.SetError(txtPresentacion, "Ingrese la presentación");
            }
            else if (txtPrecio.Text == "")
            {
                txtPrecio.Focus();
                validador.SetError(txtPrecio, "Ingrese el precio de venta");
            }
            else
            {
                return true;
            }
            return false;
        }
        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {
            ActualizarCB();
        }
        void ActualizarCB()
        {
            cbNombre.DataSource = conexion.Select("*", "Producto_Descripcion");
            cbNombre.DisplayMember = "Nombre";
            cbNombre.ValueMember = "ID_ProdDescripcion";
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }
        private void cmdLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            cbNombre.SelectedIndex = 0;
            txtPresentacion.Text = "";
            txtPrecio.Text = "";
            txtStockMin.Text = "";
        }
        void Msgbox(String Cadena)
        {
            MessageBox.Show(Cadena);
        }
        private void cmdAgregarReceta_Click(object sender, EventArgs e)
        {
            validador.Clear();
            if (validar())
            {
                if (cbNombre.SelectedValue == null)
                    if (conexion.Insert("Producto_Descripcion", "Nombre", comillas(cbNombre.Text)))
                    {
                        String selected = cbNombre.Text;
                        ActualizarCB();
                        cbNombre.Text = selected;
                    }
                ID_ProductoDescripcion = Convert.ToInt32(cbNombre.SelectedValue.ToString());
                conexion.Insert("Productos", "ID_ProdDescripcion, Presentacion, Precio, Stock_Minimo", ID_ProductoDescripcion.ToString() + ", " + comillas(txtPresentacion.Text) + ", " + comillas(txtPrecio.Text) + ", " + comillas(txtStockMin.Text));
                ID_Producto = Convert.ToInt32(conexion.Select1Valor("Select max(ID_Producto) from Productos"));
                regreceta.ID_Producto = ID_Producto;
                regreceta.label1.Text = "Datos del Producto " + cbNombre.Text;
                regreceta.regproducto = this;
                regreceta.Show();
                this.Hide();
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrecio.Text.Contains("."))
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
        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarProducto modpro = new FrmModificarProducto();
            modpro.Show();
            this.Close();
        }
    }
}
