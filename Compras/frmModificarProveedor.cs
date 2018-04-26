using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
namespace Procesadora
{
    public partial class frmModificarProveedor : Form
    {
        Conexion conexion = new Conexion();
        public frmModificarProveedor()
        {
            InitializeComponent();
        }
        private void cbProveedor_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("yola");
        }
        private void frmModificarProveedor_Load(object sender, EventArgs e)
        {
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id_proveedor";
            cbProveedor.DataSource = conexion.Select("nombre, id_proveedor", "proveedores order by nombre");
            cbCiudad.DisplayMember = "nombre"; //esto es la columna que se mostrará en el combobox
            cbCiudad.ValueMember = "id_ciudad"; //valor real del combobox, este caso su ID
            cbCiudad.DataSource = conexion.Select("nombre,id_ciudad", "ciudades");
        
        }
        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdProveedor.Text = cbProveedor.SelectedValue.ToString();
            txtRFC.Text = conexion.Select1Valor("Select rfc from proveedores where id_proveedor = " + 
                comillas(cbProveedor.SelectedValue.ToString()));
            txtNombre.Text = conexion.Select1Valor("select nombre from proveedores where id_proveedor  = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtEmail.Text = conexion.Select1Valor("select email from proveedores where id_proveedor ="+ comillas(cbProveedor.SelectedValue.ToString()));
            cbCiudad.SelectedValue = conexion.Select1Valor("select id_ciudad from proveedores where id_proveedor = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtCodigoPostal.Text = conexion.Select1Valor("select CP from proveedores where id_proveedor = "  +comillas(cbProveedor.SelectedValue.ToString()));
            txtColonia.Text = conexion.Select1Valor("select colonia from proveedores where id_proveedor = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtCalle.Text = conexion.Select1Valor("select calle from proveedores where id_proveedor = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtNumExt.Text = conexion.Select1Valor("select numeroext from proveedores where id_proveedor = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtNumInt.Text = conexion.Select1Valor("select numeroint from proveedores where id_proveedor = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtLimiteCredito.Text = conexion.Select1Valor("select limitecredito from proveedores where id_proveedor = " + comillas(cbProveedor.SelectedValue.ToString()));
        }
        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    conexion.Update("proveedores", "email = " + comillas(txtEmail.Text),
                     "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "id_ciudad = " + comillas(cbCiudad.SelectedValue.ToString()),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "CP = " + comillas(txtCodigoPostal.Text),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "colonia = " + comillas(txtColonia.Text),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "calle = " + comillas(txtCalle.Text),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "numeroext = " + comillas(txtNumExt.Text),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "numeroint = " + comillas(txtNumInt.Text),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    conexion.Update("proveedores", "limitecredito = " + comillas(txtLimiteCredito.Text),
                    "id_proveedor = " + comillas(txtIdProveedor.Text));
                    MessageBox.Show("Actualización realizada con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
      
  
                
                
                
                
                
                
                
            }
        }
        private bool validar() 
        {
            validador.Dispose();
            RegexUtilities reg = new RegexUtilities();
            if (!reg.IsValidEmail(txtEmail.Text))
            {
                txtEmail.Focus();
                validador.SetError(txtEmail, "Ingrese un email correcto");
            }
            else if (txtCodigoPostal.Text == "")
            {
                txtCodigoPostal.Focus();
                validador.SetError(txtCodigoPostal,"Ingrese el código postal");
            }
            else if (txtColonia.Text == "")
            {
                txtColonia.Focus();
                validador.SetError(txtColonia, "Debe ingresar una colonia");
            }
            else if (txtCalle.Text == "")
            {
                txtCalle.Focus();
                validador.SetError(txtCalle, "Debe ingresar una calle");
            }
            else if (txtNumExt.Text == "")
            {
                txtNumExt.Focus();
                validador.SetError(txtNumExt, "Debe ingresar numero exterior");
            }
            else if (txtLimiteCredito.Text == "")
            {
                txtLimiteCredito.Focus();
                validador.SetError(txtLimiteCredito, "Deber ingresar el limite del credito");
            }
            else
            {
                return true;
            }
            return false;
        }
        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
             var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private void txtNumExt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtNumInt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
