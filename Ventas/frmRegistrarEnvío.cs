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
    public partial class frmRegistrarEnvío : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarEnvío()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarVenta buscar = new frmBuscarVenta();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Venta; //lee la propiedad
                txt_id_venta.Text = nombre; //la pone en el título
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
                txtempresaPaqueteria.Focus();
            }
        }

        private void cmd_buscarempleado_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado buscar = new frmBuscarEmpleado();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Empleado; //lee la propiedad
                txtnumero_seguimiento.Text = nombre; //la pone en el título
            }
        }

        private void txt_cantidadprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtcostoEnvio.Text.Contains("."))
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
        }
        Boolean BuscarOrda(String ID)
        {
            if ("True" == conexion.Select1Valor("Select 'True' from LotesOrdenes where ID_Lote_Orden = " + ID)) return true; else return false;
        }
        Boolean Buscarempa(String ID)
        {
            if ("True" == conexion.Select1Valor("Select 'True' from Empleados where ID_Empleado = " + ID)) return true; else return false;
        }
        private void cmd_Registrar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (txt_id_venta.Text == "") ep1.SetError(txt_id_venta, "Este campo es obligatorio.");
            else if (txtnumero_seguimiento.Text == "") ep1.SetError(txtnumero_seguimiento, "Este campo es obligatorio.");
            else if (txtempresaPaqueteria.Text == "") ep1.SetError(txtempresaPaqueteria, "Este campo es obligatorio.");
            else if (txtcostoEnvio.Text == "") ep1.SetError(txtcostoEnvio, "Este campo es obligatorio.");
            else if (txt_id_cliente.Text == "") ep1.SetError(txt_id_cliente, "Este campo es obligatorio.");
            else if (txtcalle.Text == "") ep1.SetError(txtcalle, "Este campo es obligatorio.");
            else if (txtNumero.Text == "") ep1.SetError(txtNumero, "Este campo es obligatorio.");
            else if (txtColonia.Text == "") ep1.SetError(txtColonia, "Este campo es obligatorio.");
            else if (txtcp.Text == "") ep1.SetError(txtcp, "Este campo es obligatorio.");
            else
            {
                String fechaenvio = dtp_fechaenvio.Text;
                if (conexion.Insert("envio","id_venta, numero_seguimiento,empresaPaqueteria,fechaDeEnvio,id_empleado,costoEnvio,id_cliente,calle,Colonia,CP,Numero", com(txt_id_venta.Text) + ", " + com(txtnumero_seguimiento.Text) + ", " + com(txtempresaPaqueteria.Text) + ", " + com(fechaenvio) + ", " + com(txtID_Empleado.Text) + ", " + com(txtcostoEnvio.Text) + ", " + com(txt_id_cliente.Text) + ", " + com(txtcalle.Text) + ", " + com(txtColonia.Text) + ", " + com(txtcp.Text) + ", " + com(txtNumero.Text)))
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
        }

        private void historialDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialProduccionLotes histo = new frmHistorialProduccionLotes();
            histo.Show();
        }

        private void frmRegistrarProduccionDeLote_Load(object sender, EventArgs e)
        {
            txtID_Empleado.Text = Globales.ID_UsuarioL.ToString();
        }
        private void txt_txt_id_orden_produccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                txtnumero_seguimiento.Focus();
            }
        }

        private void registrarOrdenDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarOrdenProduccion reg = new frmRegistrarOrdenProduccion();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarCliente buscar = new frmBuscarCliente();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Cliente; //lee la propiedad
                txt_id_cliente.Text = nombre; //la pone en el título
            }
        }

        private void txtcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                cmd_Registrar.Focus();
            }
        }
    }
}
