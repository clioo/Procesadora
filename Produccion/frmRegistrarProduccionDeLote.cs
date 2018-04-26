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
    public partial class frmRegistrarProduccionDeLote : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarProduccionDeLote()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenProduccion buscar = new frmBuscarOrdenProduccion();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Orden_Produccion; //lee la propiedad
                txt_id_orden_produccion.Text = nombre; //la pone en el título
            }
        }
        private void txt_IDEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                txt_cantidadprod.Focus();
            }
        }

        private void txt_cantidadprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                txt_reprec.Focus();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_reprec.Text.Contains("."))
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
        Boolean BuscarOrd(String ID)
        {
            if ("True" == conexion.Select1Valor("Select 'True' from LotesOrdenes where ID_Lote_Orden = " + ID)) return true; else return false;
        }
        Boolean Buscaremp(String ID)
        {
            if ("True" == conexion.Select1Valor("Select 'True' from Empleados where ID_Empleado = " + ID)) return true; else return false;
        }
        private void cmd_Registrar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (txt_id_orden_produccion.Text == "") ep1.SetError(txt_id_orden_produccion, "No has introducido un ID de orden de producción.");
            else if (!BuscarOrd(txt_id_orden_produccion.Text)) ep1.SetError(txt_id_orden_produccion, "ID de orden de producción inválido.");
            else if (Convert.ToDouble(txt_cantidadprod.Text) <= 0) ep1.SetError(txt_cantidadprod, "No has introducido cantidad producida.");
            else if (Convert.ToDouble(txt_reprec.Text) <= 0) ep1.SetError(txt_reprec, "No has introducido cantidad de repeticiones de la receta.");
            else
            {
                String fechaprod = dtp_prod.Text;
                String fechacad = dtp_cad.Text;
                if (conexion.Insert("Lotes", "ID_Lote_Orden, RepeticionesReceta, CantidadProducida, FechaProduccion, FechaCaducidad, ID_Empleado", com(txt_id_orden_produccion.Text) + ", " + com(txt_reprec.Text) + ", " + com(txt_cantidadprod.Text) + ", " + com(fechaprod) + ", " + com(fechacad) + ", " + com(Globales.ID_UsuarioL)))
                {
                    MessageBox.Show("Agregado con éxito");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al introducir en la base de datos");
            }
        }
        private string com(string cad)
        {
            return "'" + cad + "'";
        }
        private void txt_idproducto_TextChanged(object sender, EventArgs e)
        {
            dgv_receta.DataSource = conexion.Select("*", "fvt_RecetaLXProducto(" + txt_id_orden_produccion.Text + ")");
        }

        private void historialDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialProduccionLotes histo = new frmHistorialProduccionLotes();
            histo.Show();
        }

        private void frmRegistrarProduccionDeLote_Load(object sender, EventArgs e)
        {

        }
        private void txt_txt_id_orden_produccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                
            }
        }

        private void registrarOrdenDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarOrdenProduccion reg = new frmRegistrarOrdenProduccion();
            reg.Show();
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
