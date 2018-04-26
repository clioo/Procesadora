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
    public partial class frmRetirarInsumo : Form
    {
        Conexion conexion = new Conexion();
        string id_orden,sucursal;
        DataTable detalles = new DataTable();
        public frmRetirarInsumo(string id_orden)
        {
            InitializeComponent();
            this.id_orden = id_orden;
            detalles = conexion.Select("id_insumo,cantidad", "detalleOrdenRetirarInsumo", "id_orden = " + com(id_orden));
            sucursal = conexion.Select1Valor("select id_sucursal from ordenRetirarInsumos where id_orden = "+ com(id_orden));
        }
        private string com(string cadena)
        {
            return "'" + cadena + "'";
        }
        private bool verificarDisponibilidad()
        {
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                float cantidadActualizada = float.Parse(dgvCompra.Rows[i].Cells[5].Value.ToString()) - float.Parse(
                        dgvCompra.Rows[i].Cells[2].Value.ToString());
                if (cantidadActualizada < 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void frmRetirarInsumo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                dgvCompra.Rows.Add("","",""," "," "," ");
                dgvCompra.Rows[i].Cells[0].Value = detalles.Rows[i][0].ToString();
                dgvCompra.Rows[i].Cells[1].Value = conexion.Select1Valor("select nombre from v_retirarInsumo where id_insumo = " + detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[2].Value = detalles.Rows[i][1].ToString();
                dgvCompra.Rows[i].Cells[3].Value = conexion.Select1Valor("select u_medida from v_retirarInsumo where id_insumo = " + detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[4].Value = conexion.Select1Valor("select nombreAlmacen from v_retirarInsumo where id_insumo = " + detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[5].Value = conexion.Select1Valor("select stock from v_retirarInsumo where id_insumo = " + detalles.Rows[i][0].ToString());
            }
            txtObservaciones.Text = conexion.Select1Valor("select observaciones from ordenRetirarInsumos where id_orden = " + id_orden);
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //TOMAR EL ID DEL EMPLEADO LOGGEADO ACTUALMENTE
            if (verificarDisponibilidad())
            {
                conexion.Insert("retiroInsumos", "id_orden,fechaRetiro,id_empleado",
                com(id_orden) + "," + com(dtpFechaTransferencia.Value.ToString("yyyyMMdd")) + "," + com(Globales.ID_UsuarioL));
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    float cantidadActual = float.Parse(dgvCompra.Rows[i].Cells[5].Value.ToString()) - float.Parse(
                            dgvCompra.Rows[i].Cells[2].Value.ToString());
                    conexion.Update("insumos", "cantidad = " + com(cantidadActual.ToString()),
                    "id_insumo = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                }
                conexion.Update("ordenRetirarInsumos", "status = 'C'", "id_orden =" + id_orden);
                MessageBox.Show("Merma registrada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique que haya disponibilidad en stock","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
