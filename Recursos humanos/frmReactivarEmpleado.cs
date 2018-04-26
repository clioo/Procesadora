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
    public partial class frmReactivarEmpleado : Form
    {
        public frmReactivarEmpleado()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado be = new frmBuscarEmpleado();
            if (be.ShowDialog() == DialogResult.OK)
            {
                txtIdEmpleado.Text = be.ID_Empleado;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "")
            {
                validador.SetError(txtIdEmpleado, "Este campo es obligatorio");
                txtIdEmpleado.Focus();
            }
            else if (conexion.Select1Valor("select * from empleados where id_empleado = " + com(txtIdEmpleado.Text)) == "")
            {
                validador.SetError(txtIdEmpleado,"Este empleado no existe");
            }
            else if (conexion.Select1Valor("select * from empleados where id_empleado = " + com(txtIdEmpleado.Text)) == "")
            {
                validador.SetError(txtIdEmpleado, "Este empleado no existe");
            }
            else
            {
                if (conexion.Update("empleados", "estado = 'A'", "id_empleado = " + txtIdEmpleado.Text))
                {
                    conexion.Insert("historico_reactEmpleado", "id_empleado,fecha",
                        com(txtIdEmpleado.Text) + "," + com(dtpFecha.Value.ToString("yyyyMMdd")));
                    MessageBox.Show("Baja exitosa");
                }
                else
                {
                    MessageBox.Show("Error en la base de datos");
                }
            }
        }
        private string com(string cad) { return "'" + cad + "'"; }
    }
}
