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
    public partial class frmBajaEmpleados : Form
    {
        public frmBajaEmpleados()
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
                validador.SetError(txtIdEmpleado,"Este campo es obligatorio");
                txtIdEmpleado.Focus();
            }
            else if (txtMotivo.Text == "")
            {
                validador.SetError(txtMotivo,"Este campo es obligatorio");
                txtMotivo.Focus();
            }
            else
            {
                if (conexion.Update("empleados","estado = 'I'","id_empleado = " + txtIdEmpleado.Text))
                {
                    conexion.Insert("historico_bajasEmpleados","id_empleado,fecha,motivo",
                        com(txtIdEmpleado.Text) + "," + com(dtpFecha.Value.ToString("yyyyMMdd")) +"," + 
                        com(txtMotivo.Text));
                    MessageBox.Show("Baja exitosa");
                }
                else
                {
                    MessageBox.Show("Error en la base de datos");
                }
            }
        }
        private string com(string cad){return "'" + cad + "'";}
    }
}
