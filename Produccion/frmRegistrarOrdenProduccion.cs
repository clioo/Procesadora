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
    public partial class frmRegistrarOrdenProduccion : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarOrdenProduccion()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProducto buscar = new frmBuscarProducto();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Producto; //lee la propiedad
                txt_idproducto.Text = nombre; //la pone en el título
            }
        }
        private string com(string cad)
        {
            return "'" + cad + "'";
        }
        private void cmd_Registrar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (txt_idproducto.Text == "") ep1.SetError(txt_idproducto, "No has introducido un ID del producto");
            else if (!BuscarProd(txt_idproducto.Text)) ep1.SetError(txt_idproducto, "ID del producto inválido");
            else if (Convert.ToDouble(txt_cantidadprod.Text) <= 0) ep1.SetError(txt_cantidadprod, "No has introducido cantidad a producir.");
            else
            {
                String fechaprod = com(dtp_prod.Text);
                if (conexion.Insert("LotesOrdenes", "ID_Producto, Cantidad, FechaProd", txt_idproducto.Text + ", " + txt_cantidadprod.Text + ", " + fechaprod))
                {
                    MessageBox.Show("Agregado con éxito");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al introducir en la base de datos");
            }
        }
        Boolean BuscarProd(String ID)
        {
            if ("True" == conexion.Select1Valor("Select 'True' from Productos where ID_Producto = " + ID)) return true; else return false;
        }
        private void txt_cantidadprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                txt_cantidadprod.Focus();
            }
            else if (txt_cantidadprod.Text.Contains("."))
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
}
