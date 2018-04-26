﻿using System;
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
    public partial class frmBuscarOrdenRetirarProductos : Form
    {
        public string id_orden;
        Conexion conexion = new Conexion();
        public frmBuscarOrdenRetirarProductos()
        {
            InitializeComponent();
        }
        private string comillas(string texto)
        {
            return "'" + texto + "'";
        }
        private void frmBuscarOrdenCompra_Load(object sender, EventArgs e)
        {
            dgvResultados.DataSource = conexion.Select("*", "v_ordenRetirarProductos", "status = 'A' or status = 'C'");
            DataTable dt = new DataTable();
            dt.Columns.Add("display");
            dt.Columns.Add("valor");
            dt.Rows.Add("Nombre del empleado que la emitió", "nombre");
            dt.Rows.Add("Apellido paterno del empleado que la emitió", "[Apellido Materno]");
            dt.Rows.Add("Apellido materno del empleado que la emitió", "[Apellido Paterno]");
            cbBuscarPor.ValueMember = "valor";
            cbBuscarPor.DisplayMember = "display";
            cbBuscarPor.DataSource = dt;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (!(txtValor.Text == ""))
            {
                dgvResultados.DataSource = conexion.Select("*", "v_ordenRetirarProductos", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Es la orden que necesita?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                id_orden = dgvResultados.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
