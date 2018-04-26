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
    public partial class frmCompraCheque : Form
    {
        Conexion conexion = new Conexion();
        string id_compra,id_proveedor;
        public frmCompraCheque(string id_compra, string id_proveedor)
        {
            InitializeComponent();
            this.id_compra = id_compra;
            this.id_proveedor = id_proveedor;
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;   
            }
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            validador.Clear();
            if (txtNumeroCuenta.Text == "")
            {
                validador.SetError(txtNumeroCuenta,"Ingresa el número de cuenta");
            }
            else if (txtNumeroCheque.Text == "")
            {
                validador.SetError(txtNumeroCheque,"Ingresa el número de cuenta");
            }
            else if (txtBanco.Text == "")
            {
                validador.SetError(txtBanco, "Ingresa el banco al que pertenece el cheque");
            }
            else
            {
                if (  conexion.Insert("cheques_compras","num_cuenta,num_cheque,banco,fecha_cheque,fecha_entrega,id_compra,id_proveedor",
                    com(txtNumeroCuenta.Text) + "," + com(txtNumeroCheque.Text) + "," + com(txtBanco.Text) + "," + 
                    com(dtpFechaExpedicion.Value.ToString("yyyyMMdd")) + "," + com(dtpFechaEntrega.Value.ToString("yyyyMMdd")) + "," +
                    com(id_compra) + "," + com(id_proveedor)))
                {
                    MessageBox.Show("Registro de cheque exitoso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error con la base de datos");
                }
              
            }
        }
        private string com(string cad) {
            return "'" + cad + "'";
        }
    }
}
