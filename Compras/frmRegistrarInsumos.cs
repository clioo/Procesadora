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
    public partial class frmRegistrarInsumos : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarInsumos()
        {
            InitializeComponent();
        }
        public void Msgbox(String cadena)
        {
            MessageBox.Show(cadena);
        }
        private void frmRegistrarInsumos_Load(object sender, EventArgs e)
        {
            cbTipoInsumo.DisplayMember = "Descripcion";
            cbTipoInsumo.ValueMember = "ID_Tipo_Insumo";
            cbTipoInsumo.DataSource = conexion.Select("ID_Tipo_Insumo, descripcion", "Tipo_Insumo order by descripcion");
            cbUMedida.SelectedIndex = 0;
            cbAlmacen.ValueMember = "id_almacen";
            cbAlmacen.DisplayMember = "nombre";
            cbAlmacen.DataSource = conexion.Select("id_almacen, nombre", "almacen order by nombre");
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            epNombre.Clear();
            Boolean error = false;
            if (txtNombre.Text == "")
            {
                epNombre.SetError(txtNombre, "No ha introducido un nombre al insumo."); error = true;
            }
            if (cbUMedida.Text == "")
            {
                epNombre.SetError(cbUMedida, "No ha seleccionado la unidad de medida del insumo."); error = true;
            }
            if (cbTipoInsumo.Text == "")
            {
                epNombre.SetError(cbTipoInsumo, "No ha seleccionado el tipo del insumo."); error = true;
            }
            if (txtStockMin.Text == "")
            {
                epNombre.SetError(txtStockMin, "El stock mínimo no puede estar vacío."); error = true;
            }
            else if (Convert.ToDouble(txtStockMin.Text) < 0)
            {
                epNombre.SetError(txtStockMin, "El stock mínimo no puede ser menor a 0."); error = true;
            }
            if (error == false)
            {
                String cadena = "'" + txtNombre.Text + "', '" + cbUMedida.Text + "', '" + cbTipoInsumo.SelectedValue.ToString() + "', '" + txtStockMin.Text + "','" + cbAlmacen.SelectedValue.ToString() + "'";
                if (conexion.Insert("Insumos", "Nombre,U_Medida,ID_Tipo_Insumo,Stock_Min,id_almacen", cadena))
                {
                    Msgbox("Se ha registrado el insumo con éxito.");
                    txtNombre.Clear();
                    txtStockMin.Clear();
                    txtNombre.Focus();
                }
                else
                {
                    Msgbox("Se ha producido un error al tratar de registrar el insumo.");
                }
            }
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStockMin.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar.ToString() == "\b")
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == "\b")
                {
                    e.Handled = false;
                }
            }
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarInsumo modinsu = new frmModificarInsumo();
            modinsu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModificarInsumo modInsumo = new frmModificarInsumo();
        }

    }
}
