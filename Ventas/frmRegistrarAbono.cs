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
    public partial class frmRegistrarCobro : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarCobro()
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
            frmBuscarVentaCredito c = new frmBuscarVentaCredito();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtIdCompra.Text = c.id_venta;
            }
        }
        private bool existeVenta() {
            if ("True" == conexion.Select1Valor("select 'True' from Venta where id_venta=" + com(txtIdCompra.Text)))
            {
                return true;
            }
            return false;
        }
        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            validador.Dispose();
            if (txtIdCompra.Text == "")
            {
                validador.SetError(txtIdCompra, "Ingrese un ID de compra");
                txtIdCompra.Focus();
            }
            
            else
            {
                string tipoPago = conexion.Select1Valor("select tipo_pago from venta where id_venta =" + com(txtIdCompra.Text) + "and estado = 'F'");
                if (!(tipoPago == "C"))
                {
                   validador.SetError(txtIdCompra,"La venta no fue realizada a crédito");
                    txtIdCompra.Focus();
                }
                else
                {
                    txtImporte.Enabled = true;
                    cmdPagar.Visible = true;
                    cmdBuscar.Enabled = false;
                    txtIdCompra.Enabled = false;
                    dgvDetalles.DataSource = conexion.Select("*", "v_detallesVenta", "[ID de venta] = " + com(txtIdCompra.Text));
                    txtFechaLimite.Text = conexion.Select1Valor("Select fechaLimite from cuentasxcobrar where id_venta =" + com(txtIdCompra.Text));
                    txtTotoal.Text = conexion.Select1Valor("select dbo.GetTotalVentaXID(" + com(txtIdCompra.Text) + ")");
                    cmdVerificar.Visible = false;
                    actualizar_deuda();
                }
            }
            
            
        }
        private void actualizar_deuda() {
            txtDeuda.Text = conexion.Select1Valor("Select TotalDeuda from CuentasXcobrar where ID_venta =" + com(txtIdCompra.Text));
            dgvHistorialPago.DataSource = conexion.Select("cantidad,fecha", "cobros", "id_venta = " + com(txtIdCompra.Text));
            txtProveedor.Text = conexion.Select1Valor("select clientes.Nombre from Venta join Clientes on Venta.ID_Cliente = Clientes.ID_Cliente where Venta.id_venta = " + txtIdCompra.Text);
            txtTotalPagado.Text = conexion.Select1Valor("select sum(cantidad) from cobros where id_venta = " + com(txtIdCompra.Text));
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
            else
            {
                if (conexion.Insert("cobros", "id_empleado,cantidad,id_venta,tipoPago", com(Globales.ID_UsuarioL) + ","
            + com(txtImporte.Text) + "," + com(txtIdCompra.Text)
           + "," + com(cbTipoPago.SelectedValue.ToString())))
                {
                    actualizar_deuda();
                    txtImporte.Clear();
                    if (cbTipoPago.SelectedValue.ToString() == "H")
                    {
                        frmCobroCheque cc = new frmCobroCheque(txtIdCompra.Text);
                        cc.Show();
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
