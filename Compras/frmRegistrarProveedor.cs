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
using System.Globalization;
using System.Text.RegularExpressions;
using Utilidades;

//CREAR UN BOTON PARA LIMPIAR LA LISTA DE NUEMEROS
namespace Procesadora
{
    public partial class frmRegistrarProveedor : Form
    {
        private string id_rfc; //use esta variable global par no usar sobrecarga y ahorrar codigo en
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public frmRegistrarProveedor()
        {
            InitializeComponent();
        }
        private bool buscarRFC(string RFC)
        {
            //buscar en base de datos si el nombre existe
            DataTable dt = new DataTable();
            dt = conexion.Select("RFC, id_proveedor", "PROVEEDORES", "rfc = " + "'" + RFC + "'");
            if (dt.Rows.Count == 0)
            {
                
                return false;
            }
            else                   //false si no existe, true si existe
            {
                id_rfc = dt.Rows[0][1].ToString();
                return true; 
            }
        }
        private void habilitarCampos(bool cambio)
        {
            //habilita los campos  para poder ingresar texto
            cmdRehabilitar.Visible = cambio;
            cmdVerificar.Visible = !cambio;
            txtRFC.Enabled = !cambio;
            cbCiudad.Enabled = cambio;
            txtEmail.Enabled = cambio;
            txtNombre.Enabled = cambio;
            txtTelefono.Enabled = cambio;
            txtCodigoPostal.Enabled = cambio;
            txtCalle.Enabled = cambio;
            txtNumeroInt.Enabled = cambio;
            txtNumeroExt.Enabled = cambio;
            txtColonia.Enabled = cambio;
            txtNombreContacto.Enabled = cambio;
            txtLimiteCredito.Enabled = cambio;
            cmdRegistrar.Visible = cambio;
            txtRFC.Focus();
        }
        private bool validar()
        {
            RegexUtilities regex = new RegexUtilities();
            //validar si en el campo del telefono hay digitos
            if (txtTelefono.MaskFull == true)
            {
                listaNumeros.Add(txtTelefono.Text);
                lbl.Visible = true;
                lbTelefonos.Visible = true;
                lbTelefonos.Items.Add(txtTelefono.Text);
                txtTelefono.Clear();
            }
            if (txtRFC.Text == "")
            {
                txtRFC.Focus();
                validador.SetError(txtRFC, "Ingresa nombre");
            }
            else if (cbCiudad.Text == "")
            {
                cbCiudad.Focus();
                validador.SetError(cbCiudad, "Selecione una ciudad");
            }
            else if (!regex.IsValidEmail(txtEmail.Text))
            {
                txtEmail.Focus();
                validador.SetError(txtEmail,"Email no valido");
            }
            else if (txtEmail.Text == "")
            {
                //Tambien validar que el Email tenga formato correcto
                txtEmail.Focus();
                validador.SetError(txtEmail, "Ingrese un Email");
            }
            else if (txtNombreContacto.Text == "")
            {
                txtNombreContacto.Focus();
                validador.SetError(txtNombreContacto, "Ingrese un nombre de contacto");
            }
            else if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                validador.SetError(txtNombre, "Ingrese el ID del encargado");
            }
            else if (listaNumeros.Count == 0)
            {
                txtTelefono.Focus();
                validador.SetError(txtTelefono, "Ingrese al menos un telefono");
            }
            else if (txtCalle.Text == "")
            {
                txtCalle.Focus();
                validador.SetError(txtCalle,"Ingrese la calle de la sucursal");
            }
            else if (txtNumeroExt.Text == "")
            {
                txtNumeroExt.Focus();
                validador.SetError(txtNumeroExt, "Ingrese el numero exterior de la sucursal");
            }
            else if (txtCodigoPostal.Text == "")
            {
                txtCodigoPostal.Focus();
                validador.SetError(txtCodigoPostal, "Ingrese el codigo postal");
            }
            else if (txtColonia.Text == "")
            {
                txtColonia.Focus();
                validador.SetError(txtColonia, "Ingrese la colonia");
            }
            else if (txtLimiteCredito.Text == "")
            {
                txtLimiteCredito.Focus();
                validador.SetError(txtLimiteCredito, "Ingrese el límite de crédito");
            }
            else
            {
                return true;
            }
            return false;
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string comillas(string cadena){
            return "'" + cadena + "'";
            }
        private void limpiar() {
            txtRFC.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            lbTelefonos.Items.Clear();
            txtCalle.Clear();
            txtNumeroExt.Clear();
            txtNumeroInt.Clear();
            txtCodigoPostal.Clear();
            txtColonia.Clear();
            txtLimiteCredito.Clear();
            txtNombreContacto.Clear();
            habilitarCampos(false);
        }
        private void Registrar_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            //las comillas es para poder ingresar los valores del insert en la base de datos
            if (validar())
            {
                try
                {
                    bool b = conexion.Insert("proveedores","email, id_ciudad,cp,colonia,calle,numeroExt,numeroInt,limitecredito,rfc,nombre",
                        comillas(txtEmail.Text)+","+comillas(cbCiudad.SelectedValue.ToString())+","+comillas(txtCodigoPostal.Text)+","+comillas(txtColonia.Text)+","+
                        comillas(txtCalle.Text)+","+comillas(txtNumeroExt.Text)+","+comillas(txtNumeroInt.Text)+","+comillas(txtLimiteCredito.Text)+","+
                        comillas(txtRFC.Text)+","+comillas(txtNombre.Text));
                    //obtener el ID del proveedor que acabamos de insertar
                    buscarRFC(txtRFC.Text);
                    //ingresar numeros de telefono del proveedor
                    if (b) 
                    {
                        foreach (string numero in listaNumeros)
                        {
                            conexion.Insert("telefono_proveedor", "id_proveedor,telefono",
                                comillas(id_rfc) + "," + comillas(numero));
                        }
                        limpiar();
                        MessageBox.Show("Ingresado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en la inserción");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
        private void cmd_Click(object sender, EventArgs e)
        {
          
            if (txtRFC.Text.Length < 12)
            {
                validador.SetError(txtRFC, "Ingresa un RFC válido");
            }
            else if (!buscarRFC(txtRFC.Text))// si no existe
            {
                habilitarCampos(true);
            }
            else
            {
                validador.SetError(txtRFC, "El RFC ya existe");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (txtTelefono.MaskFull && !listaNumeros.Contains(txtTelefono.Text))
            {
                listaNumeros.Add(txtTelefono.Text);
                lbTelefonos.Visible = true;
                lbTelefonos.Items.Add(txtTelefono.Text);
                txtTelefono.Clear();
                txtTelefono.Focus();
            }
            else if (txtTelefono.MaskFull == false)
            {
                validador.SetError(txtTelefono, "Necesita completar el campo");
            }
            else if (listaNumeros.Contains(txtTelefono.Text))
            {
                validador.SetError(txtTelefono, "Ya ingresaste ese numero");
            }
        }
        private void cmdRehabilitar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void txtNumeroExt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
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
        private void FrmRegistrarSucursal_Load(object sender, EventArgs e)
        {
            txtTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cbCiudad.DisplayMember = "nombre"; //esto es la columna que se mostrará en el combobox
            cbCiudad.ValueMember = "id_ciudad"; //valor real del combobox, este caso su ID
            cbCiudad.DataSource = conexion.Select("nombre,id_ciudad", "ciudades");
            //Codigo de conexion
        }
        private void txtLimiteCredito_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void txtNombreContacto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.ToString() == " ")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarProveedor modProv = new frmModificarProveedor();
            modProv.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
