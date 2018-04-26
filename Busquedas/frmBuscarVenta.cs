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
    public partial class frmBuscarVenta : Form
    {
        public frmBuscarVenta()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        public String ID_Venta { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtProveedores = new DataTable();
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID de la venta", "Ticket");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dtProveedores = conexion.Select("*", "v_venta_desarrollada");

        }
        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            buscar();
        }
        private void buscar()
        {
            if (!(txtValor.Text == ""))
            {
                dgvVentas.DataSource = conexion.Select("*", "v_venta_desarrollada", cbBuscarPor.SelectedValue.ToString() + " like " + comillas(txtValor.Text + "%"));

            }

        }

        private string comillas(string cadena)
        {
            return "'" + cadena + "'";
        }


        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "nombreReal" || cbBuscarPor.SelectedValue.ToString() == "RFC")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "id_proveedor")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "Email")
            {
                e.Handled = false;
            }

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿" + dgvVentas.CurrentRow.Cells[1].Value.ToString() + " es el la venta que necesita?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ID_Venta = dgvVentas.CurrentRow.Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
