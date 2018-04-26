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
    public partial class FrmRegistrarEmpleado : Form
    {
        private Conexion conexion = new Conexion();
        private ArrayList listaNumeros = new ArrayList();
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }
        private void cmd_Click(object sender, EventArgs e)
        {
            if (!buscarCURP(txtCURP.Text) && (txtCURP.Text.Length == 18))// si no existe
            {
                habilitarCampos(true);
                
            }
            else
            {
                validador.SetError(txtCURP, "El empleado ya se encuentra registrado");
            }
        }
        private bool buscarCURP(string CURP)
        {
            //Corroborar que en la BD no se encuentre registrada la CURP del empleado
            DataTable dt = new DataTable();
            dt = conexion.Select("CURP", "Empleados", "CURP = " + "'" + CURP + "'");
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else                   //false si no existe, true si existe
            {
                return true; 
            }
        }
        private void habilitarCampos(bool cambio)
        {
            validador.Dispose();
            //habilita los campos  para poder ingresar texto
            cmdRehabilitar.Visible = cambio;
            txtCURP.Enabled = !cambio;
            cmdVerificar.Visible = !cambio;
            //Campos
            txtTelefono.Enabled = cambio;
            txtContraseña.Enabled = cambio;
            txtNombre.Enabled = cambio;
            txtApellidoP.Enabled = cambio;
            txtApellidoM.Enabled = cambio;
            cbSucursal.Enabled = cambio;
            mskRFC.Enabled = cambio;
            mskNSS.Enabled = cambio;
            cbCiudad.Enabled = cambio;
            cbTurno.Enabled = cambio;
            txtCodigoPostal.Enabled = cambio;
            txtColonia.Enabled = cambio;
            txtCalle.Enabled = cambio;
            txtNumero.Enabled = cambio;
            cbIdPuesto.Enabled = cambio;
            txtSalario.Enabled = cambio;
            mskNumeroCuenta.Enabled = cambio;
            txtBanco.Enabled = cambio;
            txtLicencia.Enabled = cambio;
            cmdRegistrar.Visible = cambio;
            txtCURP.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (validar())
            {
                conexion.Insert("Empleados", "Contraseña, Nombre, ApellidoPaterno, ApellidoMaterno, CURP, ID_Sucursal, RFC, NSS, ID_Ciudad, CP, Colonia, Calle, Numero, ID_Puesto, Salario, numero_cuenta, banco, Licencia, turno, vigencia",
                  comillas(txtContraseña.Text) + "," + comillas(txtNombre.Text) + "," + comillas(txtApellidoP.Text) + "," + comillas(txtApellidoM.Text) + "," + comillas(txtCURP.Text) + "," + comillas(cbSucursal.SelectedValue.ToString()) + "," + comillas(mskRFC.Text) + "," + comillas(mskNSS.Text) + "," + comillas(cbCiudad.SelectedValue.ToString()) + "," +
                 comillas(txtCodigoPostal.Text) + "," + comillas(txtColonia.Text) + "," + comillas(txtCalle.Text) + "," + comillas(txtNumero.Text) + "," +
                 comillas(cbIdPuesto.SelectedValue.ToString()) + "," + comillas(txtSalario.Text) + "," + comillas(mskNumeroCuenta.Text) + "," + comillas(txtBanco.Text) + "," + 
                comillas(txtLicencia.Text) +  "," + comillas(cbTurno.SelectedValue.ToString()) + "," + comillas(dtpVigencia.Value.ToString("yyyyMMdd")));
                string id_empleado = conexion.Select1Valor("select max(id_empleado) from empleados");
                foreach (string numero in listaNumeros)
                {
                    conexion.Insert("telefonos_empleado", "id_empleado,teléfono", comillas(id_empleado) + "," + comillas(numero));
                }
                MessageBox.Show("Empleado " + id_empleado + " registrado con éxito.", "Exito");
                limpiar();
            }
        }
        private bool necesitaContrasena() {
            string modulo = conexion.Select1Valor("select id_modulo from puestos where id_puesto = " + cbIdPuesto.SelectedValue.ToString());
            if (modulo == "7")
            {
                return true;
            }
            return false;
        }
        private bool validar()
        {
            String L = txtCURP.Text;
            //validar si en el campo del telefono hay digitos
            if (txtTelefono.Text != "")
            {
                listaNumeros.Add(txtNumero.Text);
                lbTelefonos.Items.Add(txtNumero.Text);
                txtTelefono.Clear();
            }
            if (L.Length != 18 )
            {
                txtCURP.Focus();
                validador.SetError(txtCURP, "Ingresa la CURP completa");
            }
            if (txtCURP.Text == "")
            {
                txtCURP.Focus();
                validador.SetError(txtCURP, "Campo vacío, ingresa la CURP");
            }
            else if (listaNumeros.Count == 0)
            {
                txtTelefono.Focus();
                validador.SetError(txtTelefono, "Ingrese al menos un telefono");
            }
            else if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                validador.SetError(txtNombre, "Ingrese el nombre");
            }
            else if (txtApellidoP.Text == "")
            {
                txtApellidoP.Focus();
                validador.SetError(txtApellidoP, "Ingrese el apellido paterno");
            }
            else if (cbCiudad.Text == "")
            {
                cbCiudad.Focus();
                validador.SetError(cbCiudad, "Selecione una ciudad");
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
            else if (txtCalle.Text == "")
            {
                txtCalle.Focus();
                validador.SetError(txtCalle, "Ingrese la calle ");
            }
            else if (txtSalario.Text == "")
            {
                txtSalario.Focus();
                validador.SetError(txtSalario, "Ingrese el salario");
            }
            else if (txtContraseña.Text == "" && necesitaContrasena() == false)
            {
                validador.SetError(txtContraseña, "Este puesto necesita contraseña");
                txtContraseña.Focus();
            }
            else if (cbIdPuesto.SelectedValue.ToString() == "23" &&(txtLicencia.Text == "" || txtLicencia.Text.Length <10))
            {
                validador.SetError(txtLicencia,"Necesitas ingresar una licencia válida para un chofer");
                txtLicencia.Focus();
            }
            else
            {
                return true;
            }
            return false;
        }
        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {
            txtTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cbCiudad.DisplayMember = "nombre"; //esto es la columna que se mostrará en el combobox
            cbCiudad.ValueMember = "id_ciudad"; //valor real del combobox, este caso su ID
            cbCiudad.DataSource = conexion.Select("nombre,id_ciudad", "ciudades order by nombre");
            DataTable dt = new DataTable();
            dt.Columns.Add("valor");
            dt.Columns.Add("Nombre");
            dt.Rows.Add("M", "Matutino");
            dt.Rows.Add("V", "Vespertino");
            dt.Rows.Add("N", "Nocturno");
            cbTurno.ValueMember = "valor";
            cbTurno.DisplayMember = "Nombre";
            cbTurno.DataSource = dt;
            cbSucursal.ValueMember = "id_sucursal";
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.DataSource = conexion.Select("id_sucursal, nombre", "sucursales order by nombre");
            cbIdPuesto.ValueMember = "id_puesto";
            cbIdPuesto.DisplayMember = "nombre";
            cbIdPuesto.DataSource = conexion.Select("id_puesto, nombre", "puestos order by nombre");
            //Codigo de conexion
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string comillas(string cadena){
            return "'" + cadena + "'";
            }
        private void cmdRehabilitar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar() {
            txtCURP.Clear();
            lbTelefonos.Items.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtCURP.Clear();
            mskRFC.Clear();
            mskNSS.Clear();
            txtCodigoPostal.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtSalario.Clear();
            mskNumeroCuenta.Clear();
            txtBanco.Clear();
            txtTelefono.Clear();
            txtLicencia.Clear();
            habilitarCampos(false);
        }
        private void cmdAnadirTel_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (txtTelefono.MaskFull)
            {
                listaNumeros.Add(txtTelefono.Text);
                lbTelefonos.Visible = true;
                lblTelefonos.Visible = true;
                lbTelefonos.Items.Add(txtTelefono.Text);
                txtTelefono.Clear();
                txtTelefono.Focus();
            }
            else
            {
                validador.SetError(txtTelefono, "Necesita completar el campo");
            }
            
        }
        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSalario.Text.Contains("."))
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
        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtLicencia_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLicencia.Text != "")
            {
                grpVigencia.Show();
            }
            else
            {
                grpVigencia.Hide();
            }
        }
        private void registrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarSucursal regsuc = new frmRegistrarSucursal();
            regsuc.Show();
            this.Close();
        }
        private void modificarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void darDeBajaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBajaSucursal bajasuc = new frmBajaSucursal();
            bajasuc.Show();
            this.Close();
        }
        private void modificarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado modemp = new frmModificarEmpleado();
            modemp.Show();
            this.Close();
        }
        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarContraseña modcon = new frmModificarContraseña();
            modcon.Show();
            this.Close();
        }
    }
}
