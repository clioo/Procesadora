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
    public partial class frmRetirarProducto : Form
    {
        public frmRetirarProducto(string id_orden)
        {
            InitializeComponent();
            this.id_orden = id_orden;
            detalles = conexion.Select("id_producto,cantidad", "detalleOrdenRetirarProducto", "id_orden = " + com(id_orden));
            sucursal = conexion.Select1Valor("select id_sucursal from ordenRetirarProductos where id_orden = " + com(id_orden));
            sucursalDestino = conexion.Select1Valor("select id_sucursal_transferida from ordenRetirarProductos where id_orden = " + com(id_orden));
            observaciones = conexion.Select1Valor("select observaciones from ordenRetirarProductos where id_orden = " + com(id_orden));
            concepto = conexion.Select1Valor("select concepto from ordenRetirarProductos where id_orden = " + com(id_orden));
            if (concepto == "T")
            {
                concepto = "Transferencia";

            }
            else if (concepto == "M")
            {
                concepto = "Merma";
                gbDestino.Visible = false;
            }
        }
        Conexion conexion = new Conexion();
        DataTable detalles = new DataTable();
        string sucursal;
        string sucursalDestino;
        string concepto,observaciones;
        string id_orden;

        private string getNombreProducto(string id_producto)
        {
            return conexion.Select1Valor("select nombre from v_productos where [id del producto] =" + com(id_producto));

        }
        private string com(string cadena)
        {
            return "'" + cadena + "'";
        }
        private void frmRetirarProducto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                dgvCompra.Rows.Add("", "", "","");
                dgvCompra.Rows[i].Cells[0].Value = detalles.Rows[i][0].ToString();
                dgvCompra.Rows[i].Cells[1].Value = getNombreProducto(detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[2].Value = detalles.Rows[i][1].ToString();
                dgvCompra.Rows[i].Cells[3].Value = conexion.Select1Valor("select presentación from v_productos where [id del producto] = " + com(detalles.Rows[i][0].ToString()));
                dgvCompra.Rows[i].Cells[4].Value = conexion.Select1Valor("select cantidad from ProdXSuc where id_producto = " + com(detalles.Rows[i][0].ToString()) +
                    "and id_sucursal = " + com(sucursal));
                if (dgvCompra.Rows[i].Cells[4].Value.ToString() == "")
                {
                    dgvCompra.Rows[i].Cells[4].Value = "0";
                }
            }
            lbl_concepto.Text = concepto;
            txtObservaciones.Text = observaciones;
            if (sucursalDestino != "")
            {
                lbl_destino.Text = conexion.Select1Valor("select nombre from sucursales where id_sucursal = " +sucursalDestino);
                gbDestino.Visible = true;
                gbFechaTransfer.Visible = true;
            }
        }
        private bool verificarDisponibilidad() {
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                float cantidadActualizada = float.Parse(dgvCompra.Rows[i].Cells[4].Value.ToString()) -  float.Parse(
                        dgvCompra.Rows[i].Cells[2].Value.ToString());
                if (cantidadActualizada < 0)
                {
                    return false;  
                }
            }
            return true;
        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            
            if (verificarDisponibilidad())
            {
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    float cantidadActual = float.Parse(dgvCompra.Rows[i].Cells[4].Value.ToString()) - float.Parse(dgvCompra.Rows[i].Cells[2].Value.ToString());
                    if (conexion.Update("prodXsuc", "cantidad = " + com(cantidadActual.ToString()),
                        "id_producto = " + dgvCompra.Rows[i].Cells[0].Value.ToString() + " and id_sucursal=" + com(sucursal)))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error con el update de almacen");
                    }
                }
              if (conexion.Insert("retirarProductos","id_ordenRetirarProduct,fechaRetiro,id_empleado",
                com(id_orden) + "," + com(dtpFechaTransferencia.Value.ToString("yyyyMMdd")) + "," + com(Globales.ID_UsuarioL)))
                {
                if (concepto == "Transferencia")
                {
                    if (conexion.Insert("historicoTransferencia","id_ordenRetirarProductos,id_sucursalOrigen,id_sucursalDestino,fechaTransferencia",
                        com(id_orden) + "," + com(sucursal) + "," + com(sucursalDestino) + "," + com(dtpFechaTransferencia.Value.ToString("yyyyMMdd"))))
                    {
                        MessageBox.Show("Transferencia iniciada, para que se refleje en la otra sucursal tiene que llegar al destino","Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else if(concepto == "Merma")
                {
                    MessageBox.Show("Merma registrada con éxito","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                conexion.Update("ordenRetirarProductos", "status='C'", "id_orden=" + id_orden);
                this.Close();
              
              }
            }

        }
    }
}
