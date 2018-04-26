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
    public partial class frmBuscarInsumo : Form
    {
        public string id_insumo;
        public frmRegistrarCompra regcompra;
        Conexion conexion = new Conexion();
        public frmBuscarInsumo()
        {
            InitializeComponent();
        }
        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmBuscarInsumo_Load(object sender, EventArgs e)
        {
            
            dgvInsumo.DataSource = conexion.Select("id_insumo, nombre,U_medida","Insumos");
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID del insumo", "id_insumo");
            dt.Rows.Add("Nombre del insumo", "nombre");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( cbBuscarPor.SelectedValue.ToString() == "nombre")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "id_insumo")
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
        private void buscar()
        {
            if (!(txtValor.Text == ""))
            {
                dgvInsumo.DataSource = conexion.Select("id_insumo, nombre,U_medida", "insumos", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));

            }

        }
        private string comillas(string texto) 
        {
            return "'" + texto+ "'";
        }
        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            buscar();
        }
        private void dgvInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿" + dgvInsumo.CurrentRow.Cells[1].Value.ToString() + " es el insumo que necesita?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                id_insumo = dgvInsumo.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
