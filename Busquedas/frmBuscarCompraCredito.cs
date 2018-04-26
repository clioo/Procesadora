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
    public partial class frmBuscarCompraCredito : Form
    {
        public frmRegistrarPago regpago = null;
        public frmCancelarCOmpra cancompra = null;
        Conexion conexion = new Conexion();
        public frmBuscarCompraCredito()
        {
            InitializeComponent();
        }

        private void frmBuscarCompra_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("nombreReal");
            dt.Rows.Add("ID de proveedor", "proveedores.id_proveedor");
            dt.Rows.Add("Nombre de proveedor", "proveedores.nombre");
            dt.Rows.Add("Fecha", "compra.fecha");
            dt.Rows.Add("Número de ticket", "compra.numTicket");
            dt.Rows.Add("Número de factura", "compra.numFactura");
            cbBuscarPor.ValueMember = "nombreReal";
            cbBuscarPor.DisplayMember = "nombre";
            cbBuscarPor.DataSource = dt;
            dgvCompras.DataSource = conexion.Select("compra.ID_Compra,proveedores.ID_Proveedor,proveedores.nombre,compra.Fecha",
                "Compra join Proveedores on Proveedores.ID_Proveedor = Compra.ID_Proveedor",
                " compra.estado = 'A'");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.SelectedValue.ToString() == "proveedores.id_proveedor" || cbBuscarPor.SelectedValue.ToString() == "compra.numTicket" || cbBuscarPor.SelectedValue.ToString() == "compra.numFactura")
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
            else if (cbBuscarPor.SelectedValue.ToString() == "proveedores.nombre")
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
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCompras.DataSource = conexion.Select("compra.ID_Compra,proveedores.ID_Proveedor,proveedores.nombre,compra.Fecha",
                "Compra join Proveedores on Proveedores.ID_Proveedor = Compra.ID_Proveedor",
                cbBuscarPor.SelectedValue.ToString() + " like " + com(txtValor.Text + "%' and compra.estado = 'A"));
        }
        private string com(string cad) {
            return "'" + cad + "'";
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            if (cbBuscarPor.Text == "Fecha")
            {
                grpVALOR.Hide();
                grpFECHA.Show();
            }
            else
            {
                grpVALOR.Show();
                grpFECHA.Hide();
                buscarXfecha();
            }

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            buscarXfecha();
        }
        private void buscarXfecha() {
            dgvCompras.DataSource = conexion.Select("compra.ID_Compra,proveedores.ID_Proveedor,proveedores.nombre,compra.Fecha",
           "Compra join Proveedores on Proveedores.ID_Proveedor = Compra.ID_Proveedor",
           "fecha >=" + com(dtpDesde.Value.ToString("yyyyMMdd") + " 00:00:00") + "and fecha <=" + com(dtpHasta.Value.ToString("yyyyMMdd") + " 23:59:59.999' and compra.estado = 'A"));
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            buscarXfecha();
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (cancompra != null)
            {
                cancompra.txtIdCompra.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
            }
            else if (regpago != null)
            {
                regpago.limpiar();
                regpago.txtIdCompra.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
