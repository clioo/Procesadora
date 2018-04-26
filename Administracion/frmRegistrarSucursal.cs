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
    public partial class frmRegistrarSucursal : Form
    {
        private string id_sucursal; //use esta variable global par no usar sobrecarga y ahorrar codigo en
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        private ArrayList listaIdModulo = new ArrayList();
        public frmRegistrarSucursal()
        {
            InitializeComponent();
        }
        private bool buscarNombreSucursal(string nombreSucursal)
        {
            //buscar en base de datos si el nombre existe
            DataTable dt = new DataTable();
            dt = conexion.Select("nombre,id_sucursal", "sucursales", "nombre = " + "'" + nombreSucursal + "'");
            if (dt.Rows.Count == 0)
            {
                
                return false;
            }
            else                   //false si no existe, true si existe
            {
                id_sucursal = dt.Rows[0][1].ToString();
                return true; 
            }
        }
        private void habilitarCampos(bool cambio)
        {
            //habilita los campos  para poder ingresar texto
            cmdRehabilitar.Visible = cambio;
            cmdVerificar.Visible = !cambio;
            txtNombre.Enabled = !cambio;
            cbCiudad.Enabled = cambio;
            txtEmail.Enabled = cambio;
            txtTelefono.Enabled = cambio;
            txtCodigoPostal.Enabled = cambio;
            txtCalle.Enabled = cambio;
            txtNumeroInt.Enabled = cambio;
            txtNumeroExt.Enabled = cambio;
            txtColonia.Enabled = cambio;
            cmdRegistrar.Visible = cambio;
            txtNombre.Focus();
        }
        private bool validar()
        {
            RegexUtilities regex = new RegexUtilities();
            //validar si en el campo del telefono hay digitos
            if (txtTelefono.MaskFull == true)
            {
                listaNumeros.Add(txtTelefono.Text);
                listaIdModulo.Add(cbModulos.SelectedValue.ToString());
                txtTelefono.Clear();
            }
            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                validador.SetError(txtNombre, "Ingresa nombre");
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
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            lbTelefonos.Items.Clear();
            txtCalle.Clear();
            txtNumeroExt.Clear();
            txtNumeroInt.Clear();
            txtCodigoPostal.Clear();
            txtColonia.Clear();
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
                  //obtener el ID del proveedor que acabamos de insertar
                    if (conexion.Insert("sucursales","nombre, email,id_ciudad,CP,Colonia,calle,numeroext,numeroint,id_empleadoEncargado",
                        comillas(txtNombre.Text) + "," + comillas(txtEmail.Text)+ "," +comillas(cbCiudad.SelectedValue.ToString())+ "," + 
                        comillas(txtCodigoPostal.Text)+ "," +comillas(txtColonia.Text)+ "," +comillas(txtCalle.Text)+ "," +
                        comillas(txtNumeroExt.Text)+ "," + comillas(txtNumeroInt.Text) + "," + comillas(cbEncargado.SelectedValue.ToString())))
                    {
                        buscarNombreSucursal(txtNombre.Text);
                        //ingresar numeros de telefono del proveedor
                        for (int i = 0; i < listaNumeros.Count; i++)
                        {
                                conexion.Insert("telefono_sucursales", "id_sucursal,telefono", comillas(id_sucursal) + "," + comillas(listaNumeros[i].ToString()) + "," + comillas(listaIdModulo[i].ToString()));
                        }
                        limpiar();
                        MessageBox.Show("Sucursal registrada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error con la base de datos");
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
            validador.Clear();
            if (!buscarNombreSucursal(txtNombre.Text) && txtNombre.Text != "" )// si no existe
            {
                habilitarCampos(true);

            }
            else
            {
                validador.SetError(txtNombre, "El nombre de esa sucursal ya existe, favor de verificarlo");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (txtTelefono.MaskFull && !listaNumeros.Contains(txtTelefono.Text))
            {
                listaNumeros.Add(txtTelefono.Text);
                listaIdModulo.Add(cbModulos.Text.ToString());
                lbTelefonos.Visible = true;
                lblTelefonos.Visible = true;
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
        private void txtNumeroInt_KeyPress(object sender, KeyPressEventArgs e)
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
            cbEncargado.DisplayMember = "nombre";
            cbEncargado.ValueMember = "id_empleado";
            cbEncargado.DataSource = conexion.Select("nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno  as nombre, id_empleado", "empleados");
            cbModulos.DataSource = conexion.Select("*","modulos_sucursales");
            cbModulos.DisplayMember = "nombre";
            cbModulos.ValueMember = "id_modulo";
            //Codigo de conexion
        }
    }
}
