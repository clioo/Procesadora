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
    public partial class frmOrdenRetirarInsumos : Form
    {
        Conexion conexion = new Conexion();
        public frmOrdenRetirarInsumos()
        {
            InitializeComponent();
        }
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
                agregar_insumo();
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
        private bool validar()
        {
            validador.Dispose();
            Regex dinero = new Regex(@"^(?=.*\d)\d*[\.\,]?\d*$");
            if (txtIdInsumo.Text == "")
            {
                validador.SetError(txtIdInsumo, "Falta el ID del Insumo");
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
                agregar_insumo();
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
            agregar_insumo();
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
            if (dgvCompra.RowCount >= 1 && float.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString()) >= 2)
            {
                dgvCompra.CurrentRow.Cells[2].Value = float.Parse(dgvCompra.CurrentRow.Cells[2].Value.ToString()) - 1;
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
            string id_orden;
            if (//FALTA HACER QUE SELECCIONE LA SUCURSAL E ID DEL EMPLEADO QUE ACTUALMENTE ESTA LOGGEADO
            conexion.Insert("ordenRetirarInsumos","id_sucursal,id_empleado,fechaEmitida,fechaRequerida,observaciones",
                com(Globales.ID_SucursalL) + "," + com(Globales.ID_UsuarioL) + "," + com(DateTime.Now.ToString("yyyyMMdd")) + "," + com(dtpFechaRequerida.Value.ToString("yyyyMMdd")) + ","
                + com(txtDescripcion.Text)))
            {
                id_orden = conexion.Select1Valor("select max(id_orden) from ordenRetirarInsumos");
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                conexion.Insert("detalleOrdenRetirarInsumo","id_orden,id_insumo,cantidad",com(id_orden)+"," + 
                    com(dgvCompra.Rows[i].Cells[0].Value.ToString()) + "," + 
                    com(dgvCompra.Rows[i].Cells[2].Value.ToString()));
                }
                MessageBox.Show("Orden " + id_orden + " generada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            




        }
        private void txtNumTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void agregar_insumo() {
            if (validar())
            {
                dgvCompra.Rows.Add(txtIdInsumo.Text,
                getNombreInsumo(txtIdInsumo.Text),
                txtCantidad.Text);
                txtIdInsumo.Clear();
                txtCantidad.Clear();
                txtIdInsumo.Focus();
            }
        }
        private void frmOrdenRetirarInsumos_Load(object sender, EventArgs e)
        {

        }
    }
}
