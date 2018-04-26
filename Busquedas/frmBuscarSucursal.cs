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
    public partial class frmBuscarSucursal : Form
    {
        Conexion conexion = new Conexion();
        String seleccion = "sucursales.ID_Sucursal as [ID de la Sucursal], sucursales.Nombre as Nombre, sucursales.Email, Ciudades.Nombre as Ciudad, sucursales.CP as [Codigo postal], sucursales.Colonia, sucursales.Calle, sucursales.NumeroExt as [Numero exterior], sucursales.NumeroInt as [Numero interior], Empleados.Nombre + ' ' + Empleados.ApellidoPaterno + ' ' + Empleados.ApellidoMaterno AS Encargado";
        String from = "sucursales join Ciudades on Sucursales.ID_Ciudad = Ciudades.ID_Ciudad join Empleados on Sucursales.id_empleadoEncargado = Empleados.ID_Empleado";
        String condicion = "sucursales.Estado = 'A'";
        public frmBuscarSucursal()
        {
            InitializeComponent();
        }
        public String ID_Sucursal { get; set; }
        private void frmBuscarSucursal_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID de la sucursal", "[ID de la Sucursal]");
            dt.Rows.Add("Nombre de la sucursal", "Nombre");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvProductos.DataSource = conexion.Select(seleccion, from, condicion);
        }
        private void buscar()
        {
            if (!(txtValor.Text == ""))
            {
                dgvProductos.DataSource = conexion.Select(seleccion, from, condicion + " && " + cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }

        }
        private string comillas(string cadena){return "'" + cadena + "'";}

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "Nombre")
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (cbBuscarPor.SelectedValue.ToString() == "[ID de la Sucursal]")
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            buscar();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿" + dgvProductos.CurrentRow.Cells[1].Value.ToString() + " es la sucursal que necesita?", "Advertencia",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ID_Sucursal = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
