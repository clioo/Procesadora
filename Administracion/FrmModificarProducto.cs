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
    public partial class FrmModificarProducto : Form
    {
        public int ID_Producto = 0;
        public int ID_ProductoDescripcion = 0;
        DataTable dt = new DataTable();
        Conexion conexion = new Conexion();
        public FrmModificarProducto()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Focus();
                validador.SetError(txtPrecio, "Ingrese el precio de venta");
            }
            else if (txtStockMin.Text == "")
            {
                txtStockMin.Focus();
                validador.SetError(txtStockMin, "Ingrese un stock mínimo");
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
            valinicio = true;
            actualizarcbNombre();
            actualizarcbPresentacion();
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
                ID_Producto = Convert.ToInt32(cbPresentacion.SelectedValue);
                conexion.Update("Productos", "Precio = " + txtPrecio.Text, "ID_Producto = " + ID_Producto.ToString());
                Msgbox("Se ha modificado con éxito");
                this.Close();
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
        Boolean valinicio = false;
        private void cbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarcbNombre();
        }
        void actualizarcbNombre()
        {
            if (valinicio)
            {
                cbPresentacion.DataSource = conexion.Select("*", "Productos", "ID_ProdDescripcion = " + cbNombre.SelectedValue.ToString());
                cbPresentacion.ValueMember = "ID_Producto";
                cbPresentacion.DisplayMember = "Presentacion";
            }
        }
        void actualizarcbPresentacion()
        {
            if (valinicio)
            {
                txtPrecio.Text = conexion.Select1Valor("Select Precio from Productos where ID_Producto = " + cbPresentacion.SelectedValue.ToString());
                txtStockMin.Text = conexion.Select1Valor("Select Stock_Minimo from Productos where ID_Producto = " + cbPresentacion.SelectedValue.ToString());
                DataTable dt = conexion.Select("Select * from Sucursales join ProdXSuc on ProdXSuc.ID_Sucursal = Sucursales.ID_Sucursal where ProdXSuc.Estado = 'A' and ProdXSuc.ID_Producto = " + cbPresentacion.SelectedValue.ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                }
            }
        }
        private void cbPresentacion_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarcbPresentacion();
        }

        private void cmdModificarReceta_Click(object sender, EventArgs e)
        {
            ID_Producto = Convert.ToInt32(cbPresentacion.SelectedValue);
            FrmModificarReceta modrec = new FrmModificarReceta();
            modrec.ID_Producto = ID_Producto;
            modrec.label1.Text = "Datos del Producto " + cbNombre.Text;
            modrec.frmModificarProducto = this;
            modrec.Show();
            this.Hide();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto regpro = new FrmRegistrarProducto();
            regpro.Show();
            this.Close();
        }
    }
}
