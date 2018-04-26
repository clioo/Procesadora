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
    public partial class frmVentaCheque : Form
    {
        string id_venta, id_cliente;
        Conexion conexion = new Conexion();
        public frmVentaCheque(string id_venta, string id_cliente)
        {
            this.id_cliente = id_cliente;
            this.id_venta = id_venta;
            InitializeComponent();
        }

        private void frmVentaCheque_Load(object sender, EventArgs e)
        {

        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (txtNumeroCuenta.Text == "")
            {
                validador.SetError(txtNumeroCuenta,"Este campo es obligatorio");
            }
            else if (txtNumeroCheque.Text == "")
            {
                validador.SetError(txtNumeroCheque,"Este campo es obligatorio");
            }
            else if (txtBanco.Text == "")
            {
                validador.SetError(txtBanco,"Este campo es obligatorio");
            }
            else if (txtNumeroCuenta.Text.Length < 10)
            {
                validador.SetError(txtNumeroCuenta,"Te faltan dígitos");
            }
            else if (txtNumeroCheque.Text.Length < 9)
            {
                 validador.SetError(txtNumeroCheque,"Te faltan dígitos");
            }
            
            else
            {
                if (conexion.Insert("cheques_ventas", "id_venta,num_cuenta,num_cheque,banco,fecha_cheque,fecha_entrega,id_cliente",
                    com(id_venta) + "," + com(txtNumeroCuenta.Text) + "," + com(txtNumeroCheque.Text) + "," + com(txtBanco.Text) + "," +
                    com(dtpFechaExpedicion.Value.ToString("yyyyMMdd")) + "," + com(dtpFechaEntrega.Value.ToString("yyyyMMdd")) + "," +
                    com(id_cliente)))
                {
                    MessageBox.Show("Registro comletado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
         
            }
        }
        private string com(string cadena) {
            return "'" + cadena + "'";
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
