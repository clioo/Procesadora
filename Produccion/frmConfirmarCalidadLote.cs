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
    public partial class frmConfirmarCalidadLote : Form
    {
        Conexion conexion = new Conexion();
        public frmConfirmarCalidadLote()
        {
            InitializeComponent();
        }

        private void frmConfirmarCalidadLote_Load(object sender, EventArgs e)
        {
            cbLote.DataSource = conexion.Select("id_lote","lotes","estado = 'A'");
            cbLote.ValueMember = "id_lote";
            cbLote.DisplayMember = "id_lote";
            cbCalidad.SelectedIndex = 0;
        }
        private void insertIfNecesary(string id_producto) {
            if (conexion.Select1Valor("select 'True' from prodXsuc where id_producto = " + id_producto + " and id_sucursal = '2'") == "True")
            {
                return;
            }
            else
            {
                if (conexion.Insert("prodXsuc", "id_producto,id_sucursal,cantidad,estado,stock_minimo", com(id_producto) + "," + "'2'" + "," +
                    "0" + "," + "'A'" + "," + "'100'"))
                {
                    
                }
                else
                {
                    MessageBox.Show("Error en la base de datos");
                }
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string estado = "";
            string cantidad = conexion.Select1Valor("select cantidadProducida from lotes where id_lote= " + cbLote.SelectedValue.ToString());
            string id_lote_orden = conexion.Select1Valor("select id_lote_orden from lotes where id_lote = " + cbLote.SelectedValue.ToString());
            string id_product = conexion.Select1Valor("select id_producto from lotesordenes where id_lote_orden = " + id_lote_orden);
            if (cbCalidad.SelectedIndex == 0)
            {
                estado = "'C'";
            }
            else if (cbLote.Text == "")
            {
                MessageBox.Show("No hay ningun lote producido");
            }
            else
            {
                estado = "'I'";
            }
            insertIfNecesary(id_product);
            if (conexion.Update("lotes","estado = "+estado,"id_lote = "+cbLote.SelectedValue.ToString()))
            {
                if (estado == "'C'")
                {
                    if (conexion.Update("prodXsuc", "cantidad =  cantidad + " + cantidad, "id_sucursal = '2' and id_producto = " + com(id_product)))
                    {
                        if (conexion.Update("productos","cantidad_Almacen =  cantidad_Almacen - " + cantidad,"id_producto = "+id_product))
                        {
                            MessageBox.Show("Productos listos para vender");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error con la base de datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error con la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("Productos serán desechados al momento que se registren como merma");
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
        }
        private string com(string cad) { return "'" + cad + "'"; }
    }
}
