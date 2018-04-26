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
    public partial class frmEntradaInsumo : Form
    {
        public frmEntradaInsumo(string id_compra)
        {
            InitializeComponent();
            this.id_compra = id_compra;
            detalles = conexion.Select("id_insumo,cantidad", "detalles_compra", "id_compra = " + com(id_compra));
            id_proveedor = conexion.Select1Valor("select id_proveedor from compra where id_compra = " + com(id_compra));
        
        }
        Conexion conexion = new Conexion();
        DataTable detalles = new DataTable();
        string id_compra,id_proveedor;
        private string getNombreInsumo(string id_insumo)
        {
            return conexion.Select1Valor("select nombre from insumos where id_insumo =" + com(id_insumo));

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
                dgvCompra.Rows[i].Cells[1].Value = getNombreInsumo(detalles.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[2].Value = detalles.Rows[i][1].ToString();
                dgvCompra.Rows[i].Cells[3].Value = conexion.Select1Valor("select u_medida from insumos where id_insumo = " + com(detalles.Rows[i][0].ToString()));


            }
            lbl_destino.Text = conexion.Select1Valor("select nombre from proveedores where id_proveedor = " + id_proveedor);
        }
 
        private void cmdAceptar_Click_1(object sender, EventArgs e)
        {
            //FALTA TOMAR EL ID DEL EMPLEADO LOGGEADO ACTUALMENTE
            //FALTA TOMAR EL ID DE EL EMPLEADO
            if (conexion.Insert("ingresoInsumo","id_compra,fechaIngreso,observaciones,id_empleado",com(id_compra) +  "," + 
                com(dtpFechaTransferencia.Value.ToString("yyyyMMdd"))+ "," + com(txtObservaciones.Text) + "," + com(Globales.ID_UsuarioL)))
            {
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    string cantidadActual = conexion.Select1Valor("select cantidad from insumos where id_insumo = " + com(dgvCompra.Rows[i].Cells[0].Value.ToString()));
                    if (cantidadActual == "")
                    {
                        cantidadActual = "0";
                    }
                    float cantidadActualizada = float.Parse(cantidadActual) + float.Parse(dgvCompra.Rows[i].Cells[2].Value.ToString());
                    conexion.Update("insumos","cantidad  = "+cantidadActualizada.ToString(),"id_insumo = " + dgvCompra.Rows[i].Cells[0].Value.ToString());
                }    
            }
            this.Close();
        }
    }
}
