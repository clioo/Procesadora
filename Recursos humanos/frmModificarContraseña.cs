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
    public partial class frmModificarContraseña : Form
    {
        public int Rango;
        Conexion conexion = new Conexion();
        public frmModificarContraseña()
        {
            InitializeComponent();
        }
        public void Msgbox(String cadena)
        {
            MessageBox.Show(cadena);
        }
        private void frmModificarContraseña_Load(object sender, EventArgs e)
        {
            cbUsuarioPS.DataSource = conexion.Select("select Empleados.ID_Empleado, (Empleados.Nombre + ' ' + Empleados.ApellidoPaterno + ' ' + ISNULL(Empleados.ApellidoMaterno, '')) as Nombre, ID_Empleado from Empleados join Puestos on Empleados.ID_Puesto = Puestos.ID_Puesto where " + Rango + " >= Puestos.Rango ");
            cbUsuarioPS.DisplayMember = "Nombre";
            cbUsuarioPS.ValueMember = "ID_Empleado";
            cbUsuarioPS.SelectedIndex = 0;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            Boolean error = false;
            if (txtContraseña.Text == "")
            {
                ep1.SetError(txtContraseña, "Error, no ha introducido la contraseña"); error = true;
            }
            if (txtContraseña2.Text == "")
            {
                ep1.SetError(txtContraseña2, "Error, no ha introducido la validación de contraseña"); error = true;
            }
            if (error == false)
            {
                if (txtContraseña.Text != txtContraseña2.Text)
                {
                    ep1.SetError(txtContraseña, "Error, las contraseñas no coinciden");
                    ep1.SetError(txtContraseña2, "Error, las contraseñas no coinciden");
                }
                else
                {
                    if (conexion.Update("Empleados", "Contraseña = '" + txtContraseña.Text + "'", "ID_Empleado = " + cbUsuarioPS.SelectedValue))
                    {
                        Msgbox("Contraseña actualizada con éxito.");
                    }
                    else
                    {
                        Msgbox("Error al tratar de actualizar la contraseña");
                    }
                }
            }
        }
    }
}
