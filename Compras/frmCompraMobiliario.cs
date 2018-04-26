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
    public partial class frmCompraMobiliario : Form
    {
        Conexion conexion = new Conexion();
        public frmCompraMobiliario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string com(string cad) { return "'" + cad + "'"; }
        private bool existe() {
            if ("True" == conexion.Select1Valor("Select 'True' from Mobiliario where id_insumo ="
                + com(txtInsumo.Text) + " and id_compra =" + com(txtIdCompra.Text)))
            {
                return true;
            }
            return false;
        }
        private bool existeCompra() {
            if ("True" == conexion.Select1Valor("select 'True' from detalles_compra where id_compra="+com(txtIdCompra.Text) + " and id_insumo="+com(txtInsumo.Text)))
            {
                return true;
            }
            return false;
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ep.Clear();
            string tipo_insumo = conexion.Select1Valor("select id_tipo_inusmo from insumo where id_insumo = "+com(txtInsumo.Text));
            if (existeCompra() == false)
            {
                ep.SetError(txtIdCompra, "Esa compra no existe o no se compró este insumo en ella");
                ep.SetError(txtInsumo, "Esa compra no existe o no se compró este insumo en ella");  
            }
            else if (tipo_insumo !="5")
            {
                ep.SetError(txtInsumo,"Este insumo no es un mobiliario");
            }
            else if (existe())
            {
                ep.SetError(txtIdCompra, "Ya ingresaste esa compra del insumo");  
            }
            else
            {
                string cantidad = conexion.Select1Valor("select cantidad from detalles_Compra where id_compra = " + com(txtIdCompra.Text)
                    + " and id_insumo = " + com(txtInsumo.Text));
                string fecha = conexion.Select1Valor("select fecha from compra where id_compra ="+com(txtIdCompra.Text));
                if (conexion.Insert("mobiliario","id_insumo,id_compra,cantidad,id_sucursal",com(txtInsumo.Text) + "," +
                     com(txtIdCompra.Text) + "," + com(cantidad) + "," + com(cbSucursal.SelectedValue.ToString())))
                {
                    MessageBox.Show("Registro Exitoso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error con la base de datos");
                }
            }
        }

        private void frmCompraMobiliario_Load(object sender, EventArgs e)
        {
            cbSucursal.DataSource = conexion.Select("*", "sucursales");
            cbSucursal.DisplayMember = "Nombre";
            cbSucursal.ValueMember = "ID_Sucursal";
        }

        private void cmdBuscarMobiliario_Click(object sender, EventArgs e)
        {
            frmBuscarInsumo bi = new frmBuscarInsumo();
            if (bi.ShowDialog() == DialogResult.OK)
            {
                txtInsumo.Text = bi.id_insumo;
            }
        }

        private void cmdBuscarCompra_Click(object sender, EventArgs e)
        {
            frmBuscarCompra bc = new frmBuscarCompra();
            if (bc.ShowDialog() == DialogResult.OK)
            {
                txtIdCompra.Text = bc.id_compra;
            }
        }
    }
}
