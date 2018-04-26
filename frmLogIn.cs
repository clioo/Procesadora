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
    public partial class frmLogIn : Form
    {
        Conexion conexion = new Conexion();
        public string rango;
        public frmLogIn()
        {
            InitializeComponent();
        }
        public void Msgbox(String cadena)
        {
            MessageBox.Show(cadena);
        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
        protected void IniciarSesion()
        {
            ep.Clear();
            Boolean error = false;
            if (txtUsuario.Text == "")
            {
                ep.SetError(txtUsuario, "Error, no has introducido un usuario");
                error = true;
            }
            if (txtContraseña.Text == "")
            {
                ep.SetError(txtContraseña, "Error, no has introducido una contraseña");
                error = true;
            }
            if (conexion.Select1Valor("select estado from empleados where id_empleado ="+txtUsuario.Text) =="I")
            {
                MessageBox.Show("Ese empleado está inactivo");
                error = true;
            }
            if (error == false)
            {
                rango = conexion.Select1Valor("select dbo.GetRango(" + txtUsuario.Text + ",'" + txtContraseña.Text + "')");
                if (rango == "0" || rango=="ERROR")
                {
                    Msgbox("Error al ingresar, usuario y/o contraseña incorrectos");
                }
                else
                {
                    Globales.ID_SucursalL = conexion.Select1Valor("select id_sucursal from empleados where id_empleado = "+txtUsuario.Text);
                    Globales.ID_UsuarioL = txtUsuario.Text;
                    Globales.rango = rango;
                    Globales.puesto = conexion.Select1Valor("select id_puesto from empleados where id_empleado = " + txtUsuario.Text);
                    Globales.nombre = conexion.Select1Valor("select nombre from empleados where id_empleado = " + txtUsuario.Text);
                    Globales.apellidoPaterno = conexion.Select1Valor("select apellidoPaterno from empleados where id_empleado = " + txtUsuario.Text);
                    Globales.apellidoMaterno = conexion.Select1Valor("select apellidoMaterno from empleados where id_empleado = " + txtUsuario.Text);
                    string modulo = conexion.Select1Valor("select puestos.id_modulo from empleados join puestos on empleados.id_puesto = puestos.id_puesto where id_empleado  = " + txtUsuario.Text);
                    Globales.modulo = modulo;
                    if (modulo == "2")
                    {
                        frmMenuCompras mc = new frmMenuCompras();
                        mc.Show();
                    }
                    else if (modulo == "4")
                    {
                        frmMenuRRHH rechu = new frmMenuRRHH();
                        rechu.Show();
                    }
                    else if (modulo == "1")
                    {
                        frmMenuAdministracion ma = new frmMenuAdministracion();
                        ma.Show();
                    }
                    else if (modulo == "3")
                    {
                        frmMenuVentas mv = new frmMenuVentas();
                        mv.Show();
                    }
                    else if (modulo == "5")
                    {
                        frmMenuProduccion m = new frmMenuProduccion();
                        m.Show();
                    }
                    else if (modulo == "6")
                    {
                        frmMenuAlmacenes c = new frmMenuAlmacenes();
                        c.Show();
                    }
                    
                    this.Hide();
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar.ToString() == "\b")
            {
                e.Handled = false;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
