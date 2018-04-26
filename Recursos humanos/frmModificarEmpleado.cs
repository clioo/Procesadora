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
    public partial class frmModificarEmpleado : Form
    {
        private Conexion conexion = new Conexion();
        public frmModificarEmpleado()
        {
            InitializeComponent();
        }
        public void Msgbox(String cadena)
        {
            MessageBox.Show(cadena);
        }
        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            cbEmpleadoMod.DataSource = conexion.Select("*", "Empleados", "Estado = 'A'" + " order by nombre");
            cbEmpleadoMod.DisplayMember = "Nombre";
            cbEmpleadoMod.ValueMember = "ID_Empleado";
            cbPuesto.DataSource = conexion.Select("*", "puestos");
            cbPuesto.DisplayMember = "nombre";
            cbPuesto.ValueMember = "id_puesto";
            cbSucursal.DataSource = conexion.Select("*", "Sucursales", "Estado = 'A'");
            cbSucursal.DisplayMember = "Nombre";
            cbSucursal.ValueMember = "ID_Sucursal";
            actualizar();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //dirección, salario, puesto, sucursal, email y contrato
            ep1.Clear();
            if (txtColonia.Text == "")
                ep1.SetError(txtColonia, "Error, no ha introducido la nueva dirección, favor de verificarlo");
            else if (txtSueldo.Text == "")
                ep1.SetError(txtSueldo, "Error, no ha introducido el nuevo sueldo, favor de verificarlo");
            else if (txtEmail.Text == "")
                ep1.SetError(txtEmail, "Error, no ha introducido el Email, favor de verificarlo");
            else
            {
                if (MessageBox.Show("¿Está seguro que desea realizar este cambio?", "Advertencia",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (conexion.Update("Empleados", "Colonia = " + com(txtColonia.Text) + ", " + "Calle = " + com(txtCalle.Text) + ", " + "Numero = " + com(txtNumero.Text) + ", " + "CP = " + com(txtCP.Text) + ", " + "ID_Puesto = " + com(cbPuesto.SelectedValue.ToString()) + ", " + "Salario = " + com(txtSueldo.Text) + ", " + "ID_Sucursal = " + com(cbSucursal.SelectedValue.ToString()) + ", " + "Email = " + com(txtEmail.Text), "ID_Empleado = " + com(txtIDEmpleado.Text)))
                    {
                        Msgbox("Exito al modificar el empleado");
                        this.Close();
                    }
                    else Msgbox("Error al modificar al empleado");
                }
            }
        }
        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cbEmpleadoMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar();
        }
        private void actualizar() {
            txtIDEmpleado.Text = cbEmpleadoMod.SelectedValue.ToString();
            txtColonia.Text = conexion.Select1Valor("Select Colonia from Empleados where ID_Empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
            txtCalle.Text = conexion.Select1Valor("select calle from empleados where id_empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
            txtNumero.Text = conexion.Select1Valor("select numero from empleados where id_empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
            txtCP.Text = conexion.Select1Valor("select cp from empleados where id_empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
            txtSueldo.Text = conexion.Select1Valor("Select Salario from Empleados where ID_Empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
            cbPuesto.SelectedValue = conexion.Select1Valor("select id_puesto from empleados where id_empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
            txtEmail.Text = conexion.Select1Valor("Select Email from Empleados where ID_Empleado =" + com(cbEmpleadoMod.SelectedValue.ToString()));
            cbSucursal.SelectedValue = conexion.Select1Valor("select id_sucursal from empleados where id_empleado = " + com(cbEmpleadoMod.SelectedValue.ToString()));
        }
        private string com(string cadena) { return "'" + cadena + "'"; }
    }
}
