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
    public partial class frmRegistrarCompra : Form
    {
        Conexion conexion = new Conexion();
        DataTable detallesCompra = null;
        string id_ordenCompra;
        string id_proveedor;
        public frmRegistrarCompra(string id_OrdenCompra)
        {
            InitializeComponent();
            this.id_ordenCompra = id_OrdenCompra;
            detallesCompra = conexion.Select("id_insumo,cantidad","detalleOrdenCompra","id_ordenCompra = " + com(id_OrdenCompra));
            id_proveedor = conexion.Select1Valor("select id_proveedor from orden_compra where id_orden = " + com(id_OrdenCompra));
            MessageBox.Show(id_proveedor);
        }
        private void frmRegistrarCompra_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("char");
            dt.Columns.Add("Nombre");
            dt.Rows.Add("C","Crédito");
            dt.Rows.Add("E", "Efectivo");
            dt.Rows.Add("T", "Tarjeta");
            dt.Rows.Add("H", "Cheque");
            cbTipoPago.DisplayMember = "Nombre";
            cbTipoPago.ValueMember = "Char";
            cbTipoPago.DataSource = dt;
            for (int i = 0; i < detallesCompra.Rows.Count; i++)
            {
                dgvCompra.Rows.Add("", "", "", "","");
                dgvCompra.Rows[i].Cells[0].Value = detallesCompra.Rows[i][0].ToString();
                dgvCompra.Rows[i].Cells[1].Value = getNombreInsumo(detallesCompra.Rows[i][0].ToString());
                dgvCompra.Rows[i].Cells[2].Value = detallesCompra.Rows[i][1].ToString();
            }
        }
        private void actualizarTotal() {
            float total = 0;
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                total = total + float.Parse(dgvCompra.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }
        private string com(string cadena)
        {
            return "'" + cadena + "'";
        }
        private bool insumo_ingresado(string id_insumo) {
            for (int x = 0; x < dgvCompra.RowCount; x++)
            {
                if (id_insumo == dgvCompra.Rows[x].Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private string getNombreInsumo(string id_insumo)
        {
           return conexion.Select1Valor("select nombre from insumos where id_insumo =" + com(id_insumo));

        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            bool tienePrecio = true;
            for (int i = 0; i < dgvCompra.RowCount; i++)
            {
                if (dgvCompra.Rows[i].Cells[3].Value.ToString() == "")
                {
                    tienePrecio = false;
                    break;
                }
            }
            if (tienePrecio == false)
            {
                MessageBox.Show("Te faltó ingresar algún precio en la lista, verificalo");
            }
            else if (txtNumTicket.Text == "")
            {
                validador.SetError(txtNumTicket,"Te falta ingresar el número de ticket de compra");
            }
            else if (txtNumFactura.Text == ""){
                validador.SetError(txtNumFactura,"Te falta ingresar el número de factura");
            }
            else
            {
                insertar();
                MessageBox.Show("Registro exitoso");
                this.Close();
            }
        }
        private void insertar() {
            string id_compra;
            if (            conexion.Insert("compra","id_ordenCompra,fecha,estado,tipo_pago,id_proveedor,numticket,numfactura",com(id_ordenCompra) + "," + com(dtpFechaLimite.Value.ToString("yyyyMMdd")) + "," + com("A") + "," + 
                com(cbTipoPago.SelectedValue.ToString()) + "," + com(id_proveedor) + "," + com(txtNumTicket.Text) + "," + com(txtNumFactura.Text)))
            {
                id_compra = conexion.Select1Valor("select max(id_compra) from compra");

                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    conexion.Insert("detalles_Compra", "id_compra,id_insumo,cantidad,costo_u", com(id_compra) + "," + com(dgvCompra.Rows[i].Cells[0].Value.ToString()) + "," +
                        com(dgvCompra.Rows[i].Cells[2].Value.ToString()) + "," + com(dgvCompra.Rows[i].Cells[3].Value.ToString()));
                }
                if (cbTipoPago.SelectedValue.ToString() == "C")
                {
                    conexion.Insert("cuentasXpagar", "id_compra,id_proveedor,fechalimite,totalDeuda", com(id_compra) + "," + com(id_proveedor) + "," +
                        com(dtpFechaLimite.Value.ToString("yyyyMMdd")) + "," + com(txtTotal.Text));
                }
                if (cbTipoPago.SelectedValue.ToString() == "H")
                {
                    frmCompraCheque cc = new frmCompraCheque(id_compra,id_proveedor);
                    cc.Show();
                }
                conexion.Update("Orden_Compra", "status =  'C'", "id_orden = " + id_ordenCompra);
            }
            else
            {
                MessageBox.Show("Ocurrio un error con la base de datos","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            grpbxCredito.Visible = false;
            if (cbTipoPago.SelectedValue.ToString() == "C")
            {
                grpbxCredito.Visible = true;
            }
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

 }
}