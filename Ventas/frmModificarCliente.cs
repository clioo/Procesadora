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
    public partial class frmModificarCliente : Form
    {
        string oldEmail, oldColonia, oldCP, oldCiudad, oldNumInt, oldNumExt, oldCalle,oldLimiteCredito;
        Conexion conexion = new Conexion();
        public frmModificarCliente()
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
            cbProveedor.ValueMember = "ID_Cliente";
            cbProveedor.DataSource = conexion.Select("nombre, ID_Cliente", "Clientes order by nombre");
            cbCiudad.DisplayMember = "nombre"; //esto es la columna que se mostrará en el combobox
            cbCiudad.ValueMember = "id_ciudad"; //valor real del combobox, este caso su ID
            cbCiudad.DataSource = conexion.Select("nombre,id_ciudad", "ciudades");
        
        }
        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oldCiudad = "";
            txtIdProveedor.Text = cbProveedor.SelectedValue.ToString();
            txtRFC.Text = conexion.Select1Valor("Select rfc from Clientes where ID_Cliente = " + 
                comillas(cbProveedor.SelectedValue.ToString()));
            txtNombre.Text = conexion.Select1Valor("select nombre from Clientes where ID_Cliente  = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtEmail.Text = conexion.Select1Valor("select email from Clientes where ID_Cliente ="+ comillas(cbProveedor.SelectedValue.ToString()));
            oldEmail = txtEmail.Text;
            cbCiudad.SelectedValue = conexion.Select1Valor("select id_ciudad from Clientes where ID_Cliente = " + comillas(cbProveedor.SelectedValue.ToString()));
            txtCodigoPostal.Text = conexion.Select1Valor("select CP from Clientes where ID_Cliente = "  +comillas(cbProveedor.SelectedValue.ToString()));
            oldCP = txtCodigoPostal.Text;
            txtColonia.Text = conexion.Select1Valor("select colonia from Clientes where ID_Cliente = " + comillas(cbProveedor.SelectedValue.ToString()));
            oldColonia = txtColonia.Text;
            txtCalle.Text = conexion.Select1Valor("select calle from Clientes where ID_Cliente = " + comillas(cbProveedor.SelectedValue.ToString()));
            oldCalle = txtCalle.Text;
            txtNumExt.Text = conexion.Select1Valor("select numeroext from Clientes where ID_Cliente = " + comillas(cbProveedor.SelectedValue.ToString()));
            oldNumExt = txtNumExt.Text;
            txtNumInt.Text = conexion.Select1Valor("select numeroint from Clientes where ID_Cliente = " + comillas(cbProveedor.SelectedValue.ToString()));
            oldNumInt = txtNumInt.Text;
            txtLimiteCredito.Text = conexion.Select1Valor("select limitecredito from Clientes where ID_Cliente = " + comillas(cbProveedor.SelectedValue.ToString()));
            oldLimiteCredito = txtLimiteCredito.Text;
        }
        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                bool done = true;
                if (conexion.Select1Valor("select 'True' from Clientes where email=" + comillas(oldEmail) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
	                {
		            conexion.Update("Clientes", "email = " + comillas(txtEmail.Text),
                     "ID_Cliente = " + comillas(txtIdProveedor.Text));
	                }
                else
                {
                    MessageBox.Show("El email ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios","Control de concurrencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    done = false;
                }

                if (conexion.Select1Valor("select 'True' from Clientes where id_ciudad=" + comillas(oldCiudad) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    conexion.Update("Clientes", "id_ciudad = " + comillas(cbCiudad.SelectedValue.ToString()),
                     "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("La ciudad ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (conexion.Select1Valor("select 'True' from Clientes where CP=" + comillas(oldCP) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    conexion.Update("Clientes", "CP = " + comillas(txtCodigoPostal.Text),
                    "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("El codigo postal ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (conexion.Select1Valor("select 'True' from Clientes where colonia=" + comillas(oldColonia) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    conexion.Update("Clientes", "colonia = " + comillas(txtColonia.Text),
                   "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("La colonia ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (conexion.Select1Valor("select 'True' from Clientes where calle=" + comillas(oldCalle) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    done = false;
                    conexion.Update("Clientes", "calle = " + comillas(txtCalle.Text),
                     "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("La calle ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (conexion.Select1Valor("select 'True' from Clientes where numeroext=" + comillas(oldNumExt) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    conexion.Update("Clientes", "numeroext = " + comillas(txtNumExt.Text),
                    "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("El numero exterior ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (conexion.Select1Valor("select 'True' from Clientes where numeroint=" + comillas(oldNumInt) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    conexion.Update("Clientes", "numeroint = " + comillas(txtNumInt.Text),
                    "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("El numero interior ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (conexion.Select1Valor("select 'True' from Clientes where limitecredito=" + comillas(oldLimiteCredito) + " and ID_Cliente = " + comillas(txtIdProveedor.Text)) == "True")
                {
                    conexion.Update("Clientes", "limitecredito = " + comillas(txtLimiteCredito.Text),
                    "ID_Cliente = " + comillas(txtIdProveedor.Text));
                }
                else
                {
                    done = false;
                    MessageBox.Show("El limite de crédito ha sido cambiado mientras tu lo cambiabas, actualiza para ver los cambios", "Control de concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (done)
                {
                    MessageBox.Show("Modificado con éxito");
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
    }
}
