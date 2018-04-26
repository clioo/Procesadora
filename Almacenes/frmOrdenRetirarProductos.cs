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
    public partial class frmOrdenRetirarProductos : Form
    {
        public frmOrdenRetirarProductos()
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
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProducto c = new frmBuscarProducto();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtIdInsumo.Text = c.ID_Producto;
            }
        }
        private void agregar_producto()
        {
            if (validar())
            {
                dgvCompra.Rows.Add(txtIdInsumo.Text,
                getNombreProducto(txtIdInsumo.Text),
                txtCantidad.Text);
                txtIdInsumo.Clear();
                txtCantidad.Clear();
                txtIdInsumo.Focus();
            }

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
                dgvCompra.CurrentRow.Cells[2].Value = float.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString()) + 1;
               
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
            if (dgvCompra.RowCount >= 1 && Int32.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString()) >= 2)
            {
                dgvCompra.CurrentRow.Cells[2].Value = Int32.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString()) - 1;
               
            }
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCompra.Rows.Remove(dgvCompra.CurrentRow);
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
        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id_sucursal";
            cbSucursal.DataSource = conexion.Select("nombre,id_sucursal", "sucursales order by nombre");
        }
        private void cmdAceptar_Click_1(object sender, EventArgs e)
        {
            if (dgvCompra.RowCount >0)
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
            string id_orden;
            //FALTA HACER QUE SELECCIONE LA SUCURSAL DEL EMPLEADO QUE ACTUALMENTE ESTA LOGGEADO
            //FALTA TOMAR EL EMPLEADO INICIADO DE SESION
            if (conexion.Insert("ordenRetirarProductos","id_sucursal,id_empleado,fechaEmitida,observaciones,concepto,id_sucursal_transferida,fechaRequerida",
            com(Globales.ID_SucursalL)+ "," +com(Globales.ID_UsuarioL) + "," + com(DateTime.Today.ToString("yyyyMMdd")) + "," + com(txtDescripcion.Text) + "," + com(cbConcepto.SelectedValue.ToString()) + "," + 
            com(cbSucursal.SelectedValue.ToString()) + "," + com(dtpFechaRequerida.Value.ToString("yyyyMMdd"))))
            {
                id_orden = conexion.Select1Valor("select max(id_orden) from ordenRetirarProductos");
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    conexion.Insert("detalleOrdenRetirarProducto", "id_producto,id_orden,cantidad", com(dgvCompra.Rows[i].Cells[0].Value.ToString()) + "," +
                        com(id_orden) + "," + com(dgvCompra.Rows[i].Cells[2].Value.ToString()));
                }
                MessageBox.Show("Orden exitosa, su número de orden es: " + id_orden);
                dgvCompra.Rows.Clear();
                txtCantidad.Clear();
                txtDescripcion.Clear();
                txtIdInsumo.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
            
           
            
        }
        private void txtNumTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void cbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConcepto.Text == "Merma") {
                gbSucursal.Visible = false;
            }
            else
            {
                gbSucursal.Visible = true;
            }
        }
        private void frmOrdenRetirarProductos_Load(object sender, EventArgs e)
        {
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id_sucursal";
            cbSucursal.DataSource = conexion.Select("nombre,id_sucursal", "sucursales order by nombre");
            DataTable dt = new DataTable();
            dt.Columns.Add("valor");
            dt.Columns.Add("display");
            dt.Rows.Add("T","Transferencia");
            dt.Rows.Add("M", "Merma");
            cbConcepto.ValueMember = "valor";
            cbConcepto.DisplayMember = "display";
            cbConcepto.DataSource = dt;
            cbConcepto.SelectedIndex = 0;
            cbSucursal.SelectedIndex = 0;
        }
    }
}
