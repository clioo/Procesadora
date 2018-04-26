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
    public partial class frmBajaSucursal : Form
    {
        Conexion conexion = new Conexion();
        public frmBajaSucursal()
        {
            InitializeComponent();
        }

        private void frmBajaSucursal_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 0;
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id_sucursal";
            cbSucursal.DataSource = conexion.Select("nombre,id_sucursal","Sucursales");
        }

        private void cmdCambiar_Click(object sender, EventArgs e)
        {
            string x;
            if (cbEstado.Text == "Alta") x = "A";
            else x = "B";
           bool b = conexion.Update("Sucursales", "estado = " + comillas(x), "id_sucursal = " + comillas(cbSucursal.SelectedValue.ToString()));
           if (b)
           {
               MessageBox.Show("Modificación realizada con éxito");
           }
        }
        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado regemp = new FrmRegistrarEmpleado();
            regemp.Show();
            this.Close();
        }

        private void registrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarSucursal regsuc = new frmRegistrarSucursal();
            regsuc.Show();
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
