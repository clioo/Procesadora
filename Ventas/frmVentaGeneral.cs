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
    public partial class frmVentaGeneral : Form
    {
        public frmVentaGeneral()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        private void limpiar()
        {
            dgvCompra.Rows.Clear();
            txtCantidad.Clear();
            txtIdInsumo.Focus();
        }
        private void id_insumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                agregar_producto();
            }
        }
        private void agregar_producto()
        {
            if (validar())
            {
                dgvCompra.Rows.Add(txtIdInsumo.Text,
                getNombreProducto(txtIdInsumo.Text),
                conexion.Select1Valor("select Presentación from v_productos where [ID del producto] = " + com(txtIdInsumo.Text)),
                txtCantidad.Text,
                conexion.Select1Valor("select precio from v_productos where [ID del producto] = " + com(txtIdInsumo.Text)),
                ""
                );
                actualizar_total();
                txtIdInsumo.Clear();
                txtCantidad.Clear();
                txtIdInsumo.Focus();
            }
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
        private bool validar()
        {
            validador.Dispose();
            Regex dinero = new Regex(@"^(?=.*\d)\d*[\.\,]?\d*$");
            if (txtIdInsumo.Text == "")
            {
                validador.SetError(txtIdInsumo, "Falta el ID del producto");
                txtIdInsumo.Focus();
                return false;
            }
            else if (txtCantidad.Text == "")
            {
                validador.SetError(txtCantidad, "Falta la cantidad");
                txtCantidad.Focus();
                return false;
            }

            else if (producto_ingresado(txtIdInsumo.Text))
            {
                validador.SetError(txtIdInsumo, "Ya ingresaste ese producto");
                txtIdInsumo.Focus();
                return false;
            }
            else if (!existeProducto(txtIdInsumo.Text))
            {
                validador.SetError(txtIdInsumo, "Ese producto no existe");
                txtIdInsumo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private string com(string cadena)
        {
            return "'" + cadena + "'";
        }
        private bool producto_ingresado(string id_producto)
        {
            for (int x = 0; x < dgvCompra.RowCount; x++)
            {
                if (id_producto == dgvCompra.Rows[x].Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else if (Encoding.ASCII.GetBytes(e.KeyChar.ToString())[0] == 13)
            {
                agregar_producto();
            }
        }
        private void cmdAumentar_Click(object sender, EventArgs e)
        {

            if (dgvCompra.RowCount >= 1)
            {
                dgvCompra.CurrentRow.Cells[3].Value = float.Parse(dgvCompra.CurrentRow.Cells[3].Value.ToString()) + 1;
                actualizar_total();
            }
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            agregar_producto();
        }
        private string getNombreProducto(string id_producto)
        {
            return conexion.Select1Valor("select nombre from v_productos where [id del producto] =" + com(id_producto));

        }
        private bool existeProducto(string id_producto)
        {
            string nombre = conexion.Select1Valor("select nombre from v_productos where [id del producto] =" + com(id_producto));
            if (nombre == "ERROR" || nombre == "") return false;
            else return true;
        }
        private void cmdReducir_Click(object sender, EventArgs e)
        {
            if (dgvCompra.RowCount >= 1 && Int32.Parse(dgvCompra.CurrentRow.Cells[3].Value.ToString()) >= 2)
            {
                dgvCompra.CurrentRow.Cells[3].Value = Int32.Parse(dgvCompra.CurrentRow.Cells[3].Value.ToString()) - 1;
                actualizar_total();
            }
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCompra.Rows.Remove(dgvCompra.CurrentRow);
                actualizar_total();
            }
            catch (Exception)
            {

                validador.SetError(cmdEliminar, "La lista está vacía");
            }
        }
        private void cmdCancelarVenta_Click(object sender, EventArgs e)
        {
            dgvCompra.Rows.Clear();
            txtCantidad.Clear();
            txtIdInsumo.Clear();
        }
        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void insertar()
        {
            //FALTA HACER QUE SELECCIONE LA SUCURSAL DEL EMPLEADO QUE ACTUALMENTE ESTA LOGGEADO
            //FALTA TOMAR EL EMPLEADO INICIADO DE SESION
            if (cbTipoPago.SelectedValue.ToString() == "C" || cbTipoPago.SelectedValue.ToString() == "H")
            {
                if (conexion.Insert("venta", "fecha,tipo_pago,id_sucursal,id_empleado,id_cliente,total",
                    com(dtpFechaSolicitud.Value.ToString("yyyyMMdd")) + "," + com(cbTipoPago.SelectedValue.ToString()) + "," +
                    com(Globales.ID_SucursalL) + "," + com(Globales.ID_UsuarioL) + "," + com(txtCliente.Text) + "," + com(txtTotal.Text)))
                {
                    string id_venta = conexion.Select1Valor("select max(id_venta) from venta");
                    for (int i = 0; i < dgvCompra.RowCount; i++)
                    {
                        string id_prodXsuc = conexion.Select1Valor("select id_prodxsuc from prodxsuc where id_sucursal = " + Globales.ID_SucursalL + " and id_producto = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                        if ( conexion.Insert("detalles_Venta", "id_venta,id_prodXsuc,cantidad,costo_u", com(id_venta) + "," + com(id_prodXsuc) + "," + com(dgvCompra.Rows[i].Cells[3].Value.ToString()) + "," + com(dgvCompra.Rows[i].Cells[4].Value.ToString())))
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Error con detalles de la venta");
                        }
                       
                    }
                    if (cbTipoPago.SelectedValue.ToString() == "H")
                    {
                        frmVentaCheque vc = new frmVentaCheque(id_venta, txtCliente.Text);
                        vc.Show();
                        this.Close();
                    }
                    else if (cbTipoPago.SelectedValue.ToString() == "C")
                    {
                        frmVentaCredito vc = new frmVentaCredito(id_venta, txtCliente.Text);
                        vc.Show();
                        this.Close();
                    }
                    MessageBox.Show("Registro exitoso");
                }
                else
                {
                    MessageBox.Show("Error en la base de datos");
                }
            }
            else
            {
                if (conexion.Insert("venta", "fecha,tipo_pago,id_sucursal,id_empleado,total",
                    com(dtpFechaSolicitud.Value.ToString("yyyyMMdd")) + "," + com(cbTipoPago.SelectedValue.ToString()) + "," +
                    com(Globales.ID_SucursalL) + "," + com(Globales.ID_UsuarioL)  + "," + com(txtTotal.Text)))
                {
                    string id_venta = conexion.Select1Valor("select max(id_venta) from venta");
                    for (int i = 0; i < dgvCompra.RowCount; i++)
                    {
                        string id_prodXsuc = conexion.Select1Valor("select id_prodxsuc from prodxsuc where id_sucursal = "+Globales.ID_SucursalL+ " and id_producto = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                        conexion.Insert("detalles_Venta", "id_venta,id_prodXsuc,cantidad,costo_u", com(id_venta) + "," + com(id_prodXsuc) + "," + com(dgvCompra.Rows[i].Cells[3].Value.ToString()) + "," + com(dgvCompra.Rows[i].Cells[4].Value.ToString()));
                    }
                    MessageBox.Show("Registro exitoso");
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
        private void cmdBuscar_Click_1(object sender, EventArgs e)
        {
            //ingresar busqueda en integracion
        }
        private bool verificarStock()
        {
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
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            validador.Clear();
            string cliente = conexion.Select1Valor("select * from clientes where id_cliente  = " + com(txtCliente.Text));
            if ((cliente == "ERROR" || txtCliente.Text == "") && (cbTipoPago.SelectedValue.ToString() == "H" || cbTipoPago.SelectedValue.ToString() == "C"))
            {
                validador.SetError(txtCliente, "Ingrese un cliente válido");
            }
            else if (dgvCompra.RowCount == 0)
            {
                validador.SetError(txtIdInsumo, "No has ingresado ningún producto a comprar");
            }
            else if(verificarStock())
            {
                    insertar();
                    dgvCompra.Rows.Clear();
                    txtCantidad.Clear();
                    txtIdInsumo.Clear();
                    txtTotal.Clear();
                    txtCliente.Clear();
            }
        }
        private void frmVentaGeneral_Load(object sender, EventArgs e)
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
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProducto bp = new frmBuscarProducto();
           
            if (bp.ShowDialog() == DialogResult.OK)
            {
                txtIdInsumo.Text = bp.ID_Producto;
            }
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente bc = new frmBuscarCliente();
            if (bc.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = bc.ID_Cliente;
            }
        }
    }
}
