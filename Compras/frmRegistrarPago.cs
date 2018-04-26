using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesadora
{
    public partial class frmRegistrarPago : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarPago()
        {
            InitializeComponent();
        }

        private void frmRegistrarPago_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("valor");
            dt.Columns.Add("nombre");
            dt.Rows.Add("E", "Efectivo");
            dt.Rows.Add("T", "Tarjeta");
            dt.Rows.Add("H", "Cheque");
            cbTipoPago.DisplayMember = "nombre";
            cbTipoPago.ValueMember = "valor";
            cbTipoPago.DataSource = dt;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCompraCredito buscarCompra = new frmBuscarCompraCredito();
            buscarCompra.regpago = this;
            buscarCompra.Show();
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            string existeCompra;
            validador.Dispose();
            if (txtIdCompra.Text == "")
            {
                validador.SetError(txtIdCompra, "Ingrese un ID de compra");
                txtIdCompra.Focus();
            }
            else
            {
                existeCompra = conexion.Select1Valor("select tipo_pago from compra where id_compra =" + com(txtIdCompra.Text) + "and estado = 'A'");
                if (existeCompra == "")
                {
                    validador.SetError(txtIdCompra,"El ID de la compra no existe o está dado de baja");
                    txtIdCompra.Focus();
                }
                else if (!(existeCompra == "C"))
                {
                   validador.SetError(txtIdCompra,"La compra no fue realizada a crédito");
                    txtIdCompra.Focus();
                }
                else
                {
                    txtImporte.Enabled = true;
                    txtTicket.Enabled = true;
                    cmdPagar.Visible = true;
                    cmdBuscar.Enabled = false;
                    txtIdCompra.Enabled = false;
                    dgvDetalles.DataSource = conexion.Select("Insumos.Nombre, Detalles_Compra.Cantidad, Detalles_Compra.Costo_U",
                        "Detalles_Compra join Insumos on INSUMOS.ID_Insumo = Detalles_Compra.ID_Insumo",
                        "Detalles_Compra.ID_Compra =" + com(txtIdCompra.Text));
                    txtFechaLimite.Text = conexion.Select1Valor("Select fechaLimite from cuentasxpagar where id_compra =" + com(txtIdCompra.Text));
                    txtTotoal.Text = conexion.Select1Valor("select dbo.GetTotalCompraXID(" + com(txtIdCompra.Text) + ")");
                    cmdVerificar.Visible = false;
                    actualizar_deuda();
                }
            }
            
            
        }
        private void actualizar_deuda() {
            txtDeuda.Text = conexion.Select1Valor("Select TotalDeuda from CuentasXPagar where ID_Compra =" + com(txtIdCompra.Text));
            dgvHistorialPago.DataSource = conexion.Select("cantidad,fecha", "pagos", "id_compra = " + com(txtIdCompra.Text));
            txtProveedor.Text = conexion.Select1Valor("select Proveedores.Nombre from Compra join Proveedores on Compra.ID_Proveedor = Proveedores.ID_Proveedor where Compra.ID_Compra =" + com(txtIdCompra.Text));
            txtTotalPagado.Text = conexion.Select1Valor("select sum(cantidad) from pagos where id_compra = " + com(txtIdCompra.Text));
        }
        private string com(string cad) {
            return "'" + cad + "'";
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }
        public void limpiar() {
            dgvDetalles.DataSource = null;
            dgvDetalles.Rows.Clear();
            dgvHistorialPago.DataSource = null;
            dgvHistorialPago.Rows.Clear();
            txtDeuda.Clear();
            txtFechaLimite.Clear();
            txtIdCompra.Clear();
            txtImporte.Clear();
            txtProveedor.Clear();
            txtTotalPagado.Clear();
            txtTotoal.Clear();
            cmdPagar.Visible = false;
            txtImporte.Enabled = false;
            txtTicket.Enabled = false;
            txtIdCompra.Enabled = true;
            cmdVerificar.Visible = true;
            cmdBuscar.Enabled = true;
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            Regex regex = new Regex(@"^(?=.*\d)\d*[\.\,]?\d*$");
            if (!regex.IsMatch(txtImporte.Text))
            {
                validador.SetError(txtImporte,"Formato de importe no válido");
                txtImporte.Focus();
            }
            else if (float.Parse(txtDeuda.Text) < float.Parse(txtImporte.Text))
            {
                validador.SetError(txtImporte, "No puedes pagar más de lo que debes");
                txtImporte.Focus();
            }
            else if (txtTicket.Text == "")
            {
                validador.SetError(txtTicket,"Ingresa el ticket generado por el pago");
            }
            else
            {
                if (verificar_ticket())
                {
                    validador.SetError(txtTicket,"El ticket que has ingresado ya se ha ingresado antes");
                }
                else if (conexion.Insert("pagos", "id_empleado,ticket,cantidad,id_compra,tipoPago", com(Globales.ID_UsuarioL) + ","
           + com(txtTicket.Text) + "," + com(txtImporte.Text) + "," + com(txtIdCompra.Text)
           + "," + com(cbTipoPago.SelectedValue.ToString())))
                {
                    actualizar_deuda();
                    txtTicket.Clear();
                    txtImporte.Clear();
                    if (cbTipoPago.SelectedValue.ToString() == "H")
                    {
                        string pago = conexion.Select1Valor("select max(id_pago) from pagos");
                        frmPagoCheque pc = new frmPagoCheque(pago);
                        pc.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error en la inserción");
                }
           
              
            }
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool verificar_ticket() {
            DataTable dt = conexion.Select("ticket", "pagos", "id_compra  = " + com(txtIdCompra.Text));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == txtTicket.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmCancelarCOmpra cancel = new frmCancelarCOmpra();
            cancel.Show();
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
