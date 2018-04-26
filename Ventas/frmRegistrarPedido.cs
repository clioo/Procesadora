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
    public partial class frmRegistrarPedido : Form
    {
        public frmRegistrarPedido()
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
        private void actualizar_total() {
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
        private void cmdAceptar_Click_1(object sender, EventArgs e)
        {
            if (dgvCompra.RowCount > 0)
            {

                if (txtCantidad.Text != "" || txtIdInsumo.Text != "")
                {
                    if (MessageBox.Show("Hay una captura inconclusa. ¿Deseas continuar?", "Advertencia",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        insertar();
                    }
                }
                else if (MessageBox.Show("¿Seguro deseas continuar?", "Advertencia",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                }

            }
            else
            {
                MessageBox.Show("No has ingresado ningun producto");
            }

        }
        private void insertar()
        {
            //FALTA HACER QUE SELECCIONE LA SUCURSAL DEL EMPLEADO QUE ACTUALMENTE ESTA LOGGEADO
            //FALTA TOMAR EL EMPLEADO INICIADO DE SESION
            string id_pedido;
            if (conexion.Insert("pedidos","id_sucursal,id_empleado,id_cliente,fechaSolicitud,fechaPromesa",
                "'1'" + "," + "'1'" +"," + com(txtCliente.Text) + "," + com(dtpFechaSolicitud.Value.ToString("yyyyMMdd")) + "," +
                com(dtpFechaPromesa.Value.ToString("yyyyMMdd"))))
            {
                id_pedido = conexion.Select1Valor("select max(id_pedido) from pedidos");
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    conexion.Insert("detallePedido","id_pedido,id_producto,cantidad",com(id_pedido) + "," + com(dgvCompra.Rows[i].Cells[0].Value.ToString()) + "," + com(dgvCompra.Rows[i].Cells[3].Value.ToString()));
                }
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("Error con la base de datos");
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

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string cliente = conexion.Select1Valor("select * from clientes where id_cliente  = " + com(txtCliente.Text));
            if (cliente == "")
            {
                validador.SetError(txtCliente,"Ese cliente no existe");
            }
            else if (dgvCompra.RowCount == 0)
            {
                validador.SetError(txtIdInsumo,"No has ingresado ningún producto a comprar");  
            }
            else
            {
                insertar();
                dgvCompra.Rows.Clear();
                txtCantidad.Clear();
                txtIdInsumo.Clear();
                txtTotal.Clear();
                txtCliente.Clear();
            }
        }

        private void frmRegistrarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
