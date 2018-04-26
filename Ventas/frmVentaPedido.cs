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
    public partial class frmVentaPedido : Form
    {
        string id_cliente;
        Conexion conexion = new Conexion();
        DataTable detalles = null;
        string id_pedido;
        public frmVentaPedido(string id_pedido)
        {
            InitializeComponent();
            this.id_pedido = id_pedido;
            detalles = conexion.Select("id_producto,cantidad", "detallepedido", "id_pedido = " + com(id_pedido));
            this.id_cliente = conexion.Select1Valor("select id_cliente from pedidos where id_pedido = " + id_pedido);
        }
        private void frmRegistrarCompra_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("char");
            dt.Columns.Add("Nombre");
            dt.Rows.Add("C", "Crédito");
            dt.Rows.Add("E", "Efectivo");
            dt.Rows.Add("T", "Tarjeta");
            dt.Rows.Add("H", "Cheque");
            cbTipoPago.DisplayMember = "Nombre";
            cbTipoPago.ValueMember = "Char";
            cbTipoPago.DataSource = dt;
            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                dgvCompra.Rows.Add("", "", "", "", "","");
                dgvCompra.Rows[i].Cells[0].Value = detalles.Rows[i][0].ToString();
                dgvCompra.Rows[i].Cells[1].Value = getNombreProducto(detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[2].Value = conexion.Select1Valor("select Presentación from v_productos where [ID del producto] = " + com(detalles.Rows[i][0].ToString()));
                dgvCompra.Rows[i].Cells[3].Value = detalles.Rows[i][1].ToString();
                dgvCompra.Rows[i].Cells[4].Value = conexion.Select1Valor("select precio from v_productos where [ID del producto] = " + com(detalles.Rows[i][0].ToString()));
            }
            actualizar_total();
        }
        private void actualizar_total()
        {
            float total = 0;
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                dgvCompra.Rows[i].Cells[5].Value = (float.Parse(dgvCompra.Rows[i].Cells[3].Value.ToString()) * float.Parse(dgvCompra.Rows[i].Cells[4].Value.ToString())).ToString();
                total = total + float.Parse(dgvCompra.Rows[i].Cells[5].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }
        private string com(string cadena)
        {
            return "'" + cadena + "'";
        }
        private bool insumo_ingresado(string id_insumo)
        {
            for (int x = 0; x < dgvCompra.RowCount; x++)
            {
                if (id_insumo == dgvCompra.Rows[x].Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private string getNombreProducto(string id_producto)
        {
            return conexion.Select1Valor("select nombre from v_productos where [id del producto] =" + com(id_producto));

        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (verificarStock())
            {
                if (conexion.Insert("venta", "fecha,tipo_pago,id_sucursal,id_empleado,id_cliente,total,id_pedido",
                com(dtpFechaCompra.Value.ToString("yyyyMMdd")) + "," + com(cbTipoPago.SelectedValue.ToString()) + "," +
                com(Globales.ID_SucursalL) + "," + com(Globales.ID_UsuarioL) + "," + com(id_cliente) + "," + com(txtTotal.Text) + "," + com(id_pedido)))
                {
                    string id_venta = conexion.Select1Valor("select max(id_venta) from venta");
                    for (int i = 0; i < dgvCompra.RowCount; i++)
                    {
                        string id_prodXsuc = conexion.Select1Valor("select id_prodxsuc from prodxsuc where id_sucursal = " + com(Globales.ID_SucursalL) + " and id_producto = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                        conexion.Insert("detalles_Venta", "id_venta,id_prodXsuc,cantidad,costo_u", com(id_venta) + "," + com(id_prodXsuc) + "," + com(dgvCompra.Rows[i].Cells[3].Value.ToString()) + "," + com(dgvCompra.Rows[i].Cells[4].Value.ToString()));
                    }
                    conexion.Update("pedidos", "estado = 'C'", "id_pedido = " + id_pedido);
                    if (cbTipoPago.SelectedValue.ToString() == "H")
                    {
                        frmVentaCheque vc = new frmVentaCheque(id_venta, id_cliente);
                        vc.Show();
                    }
                    else if (cbTipoPago.SelectedValue.ToString() == "C")
                    {
                        frmVentaCredito vc = new frmVentaCredito(id_venta, id_cliente);
                        vc.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en la base de datos");
                }
            }
            
        }
        private void txtNumTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void cbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Precio_KeyPress);
            if (dgvCompra.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Precio_KeyPress);
                }
            }

        }
        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void dgvCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            float acc = 0;
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                if (dgvCompra.Rows[i].Cells[3].Value.ToString() != "")
                {
                    dgvCompra.Rows[i].Cells[4].Value = (float.Parse(dgvCompra.Rows[i].Cells[2].Value.ToString()) * float.Parse(dgvCompra.Rows[i].Cells[3].Value.ToString()));
                    acc += float.Parse(dgvCompra.Rows[i].Cells[4].Value.ToString());
                }

            }
            txtTotal.Text = acc.ToString();
        }
        private void cbTipoPago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
 
        }
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private bool verificarStock() {
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                string cantidad = conexion.Select1Valor("select cantidad from prodxsuc where id_sucursal = " + com(Globales.ID_SucursalL) + " and id_producto = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                if (float.Parse(dgvCompra.Rows[i].Cells[3].Value.ToString()) > float.Parse(cantidad))
                {
                    MessageBox.Show("No hay stock suficiente de " + dgvCompra.Rows[i].Cells[1].Value.ToString() + "en la presentación de " + dgvCompra.Rows[i].Cells[2].Value.ToString());
                    return false;
                }
            }
            return true;
        }
    }
}
