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
    public partial class frmEntradaProducto : Form
    {
        public frmEntradaProducto(string id_orden)
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
            }
        }
        Conexion conexion = new Conexion();
        DataTable detalles = new DataTable();
        string sucursal;
        string sucursalDestino;
        string concepto, observaciones;
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
                dgvCompra.Rows.Add("", "", "", "");
                dgvCompra.Rows[i].Cells[0].Value = detalles.Rows[i][0].ToString();
                dgvCompra.Rows[i].Cells[1].Value = getNombreProducto(detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[2].Value = detalles.Rows[i][1].ToString();
                dgvCompra.Rows[i].Cells[3].Value = conexion.Select1Valor("select presentación from v_productos where [id del producto] = " + com(detalles.Rows[i][0].ToString()));
                

            }
            if (sucursalDestino != "")
            {
                lbl_destino.Text = conexion.Select1Valor("select nombre from sucursales where id_sucursal = " + sucursal);
                gbDestino.Visible = true;
                gbFechaTransfer.Visible = true;
            }
            txtObservaciones.Text = observaciones;
        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //FALTA TOMAR EL ID DEL EMPLEADO LOGGEADO ACTUALMENTE
            //FALTA TOMAR EL ID DE EL EMPLEADO
            if (conexion.Insert("entradaProducto", "id_orden,fechaEntrada,id_empleado,observaciones", com(id_orden) + "," + com(dtpFechaTransferencia.Value.ToString("yyyyMMdd")) + "," + com(Globales.ID_UsuarioL) + "," +
                com(txtObservaciones.Text)))
            {
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    string cantidadActual = conexion.Select1Valor("select cantidad from prodXsuc where id_sucursal = " + sucursalDestino + " and id_producto = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                    if (cantidadActual == ""|| cantidadActual == "ERROR")
                    {
                        cantidadActual = "0";
                        conexion.Insert("prodXsuc", "id_producto,id_sucursal,cantidad,estado,stock_minimo", com(dgvCompra.Rows[i].Cells[0].Value.ToString()) + "," +
                            com(sucursalDestino) + "," + "'0'" + "," + "'A'" + "," + "'100'");
                    }
                    float cantidadActualizada = float.Parse(cantidadActual) + float.Parse(
    dgvCompra.Rows[i].Cells[2].Value.ToString());
                    if ( conexion.Update("prodXsuc", "cantidad = " + com(cantidadActualizada.ToString()), "id_producto=" + dgvCompra.Rows[i].Cells[0].Value.ToString() + " and id_sucursal="+sucursalDestino))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Error con el update");
                    }
                   
                }
                conexion.Update("ordenRetirarProductos", "status='T'", "id_orden=" + id_orden);
                MessageBox.Show("Registro exitoso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error con la base de datos");
            }
            
       
        }
    }
}
