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
    public partial class frmGenerarFactura : Form
    {
        Conexion conexion = new Conexion();
        public frmGenerarFactura()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarVenta buscar = new frmBuscarVenta();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string nombre = buscar.ID_Venta; //lee la propiedad
                txt_IDVenta.Text = nombre; //la pone en el título
            }
        }
        private bool facturaPrevia(string id_venta) {
            if ("True" == conexion.Select1Valor("select 'True' from facturasVentas where id_venta  = " + txt_IDVenta.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txt_IDVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
              
            }
        }
        Boolean BuscarVenta(String ID)
        {
            if ("True" == conexion.Select1Valor("Select 'True' from Venta where ID_Venta = " + ID)) return true; else return false;
        }
       string ID_Cliente;
        private string com(string cadena) { return "'" + cadena + "'"; }
        private bool buscarCliente() {
            if ("True" == conexion.Select1Valor("select 'True' from clientes where id_cliente = " + com(txtCliente.Text)))
            {
                return true;
            }
            return false;
        }
        private void cmd_guardar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (buscarCliente() == false)
            {
                ep1.SetError(txtCliente,"El cliente no existe");
            }
            else
            {
                ID_Cliente = txtCliente.Text;
                insertar();
            }
           
        }

        private void insertar() {
            if (conexion.Insert("FacturasVentas", "ID_Venta, ID_Cliente,fechaEmitida", com(txt_IDVenta.Text) + ", " + com(ID_Cliente) + "," + com(DateTime.Now.ToString("yyyyMMdd"))))
            {
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
                MessageBox.Show("Error en la transacción");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string obtenerCliente(string id_venta) {
            return conexion.Select1Valor("select id_cliente from venta where id_venta  = " + com(txt_IDVenta.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (txt_IDVenta.Text == "")
            {
                ep1.SetError(txt_IDVenta, "Error, no has introducido el ID de la venta");
            }
            else if (!BuscarVenta(txt_IDVenta.Text))
            {
                ep1.SetError(txt_IDVenta, "Error, el ID de la venta no existe en la base de datos");
            }
            else if(facturaPrevia(txt_IDVenta.Text))
            {
                ep1.SetError(txt_IDVenta,"Ya se ha facturado con esa venta");
            }
            else if(obtenerCliente(txtCliente.Text) == "")
            {
                gbCliente.Visible = true;
                cmd_guardar.Visible = true;
                txt_IDVenta.Enabled = false;
                cmdVerificar.Enabled = false;
            }
            else
            {
                ID_Cliente = obtenerCliente(txtCliente.Text);
                insertar();
            }
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente bc = new frmBuscarCliente();
            if (bc.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = bc.ID_Cliente;
            }
        }
    }
}
