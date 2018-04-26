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
    public partial class frmOrdenCompra : Form
    {
        public frmOrdenCompra()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        private int contadorCompra;

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
            frmBuscarInsumo c = new frmBuscarInsumo();
            if (c.ShowDialog() == DialogResult.OK)
            {
                txtIdInsumo.Text = c.id_insumo;
            }
        }
        private void agregar_producto()
        {
            if (validar())
            {
                dgvCompra.Rows.Add(txtIdInsumo.Text,
                getNombreInsumo(txtIdInsumo.Text),
                txtCantidad.Text);
                contadorCompra++;
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
                validador.SetError(txtIdInsumo, "Falta el ID del insumo");
                txtIdInsumo.Focus();
                return false;
            }
            else if (txtCantidad.Text == "")
            {
                validador.SetError(txtCantidad, "Falta la cantidad");
                txtCantidad.Focus();
                return false;
            }
            
            else if (insumo_ingresado(txtIdInsumo.Text))
            {
                validador.SetError(txtIdInsumo, "Ya ingresaste ese insumo");
                txtIdInsumo.Focus();
                return false;
            }
            else if (!existeInsumo(txtIdInsumo.Text))
            {
                validador.SetError(txtIdInsumo, "Ese insumo no existe");
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
                dgvCompra.CurrentRow.Cells[2].Value = Int32.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString()) + 1; 
            }
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            agregar_producto();
        }
        private string getNombreInsumo(string id_insumo)
        {
            return conexion.Select1Valor("select nombre from insumos where id_insumo =" + com(id_insumo));

        }
        private bool existeInsumo(string id_insumo)
        {
            string nombre = conexion.Select1Valor("select nombre from insumos where id_insumo =" + com(id_insumo));
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
            cbIdProveedor.DisplayMember = "nombre";
            cbIdProveedor.ValueMember = "id_proveedor";
            cbIdProveedor.DataSource = conexion.Select("nombre, id_proveedor", "proveedores order by nombre");
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id_sucursal";
            cbSucursal.DataSource = conexion.Select("nombre,id_sucursal","sucursales order by nombre");
        }
        private void cmdAceptar_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Tu orden de compra es la " + conexion.Select1Valor("select max(id_orden) from orden_compra"));
            }

        }
        private void insertar()
        {
            conexion.Insert("orden_Compra", "id_empleado,fecha_emitida,fecha_limite_entrega,descripcion,id_sucursal,id_proveedor", 
               com(Globales.ID_UsuarioL)  + "," + com(DateTime.Today.ToString("yyyyMMdd")) + "," + com(dtpFechaLimite.Value.ToString("yyyyMMdd"))+ "," +
                com(txtDescripcion.Text) + "," + com(cbSucursal.SelectedValue.ToString()) +","+com(cbIdProveedor.SelectedValue.ToString()));
            string id_orden = conexion.Select1Valor("select max(id_orden) from orden_compra");
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                conexion.Insert("detalleOrdenCompra","id_ordencompra,id_insumo,cantidad",
                    com(id_orden) + "," + com(dgvCompra.Rows[i].Cells[0].Value.ToString()) + "," +
                    com(dgvCompra.Rows[i].Cells[2].Value.ToString()));
            }
            limpiar();
        }
        private void txtNumTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmdCancelarVenta_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
