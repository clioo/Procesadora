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
    public partial class frmModificarInsumo : Form
    {
        Conexion conexion = new Conexion();
        public frmModificarInsumo()
        {
            InitializeComponent();
        }
        public void Msgbox(String cadena)
        {
            MessageBox.Show(cadena);
        }
        private void frmModificarInsumo_Load(object sender, EventArgs e)
        {
            ActualizarCB();
            ActualizarCampos();
        }
        void ActualizarCB()
        {
            cbInsumoBaja.DataSource = conexion.Select("*", "Insumos", "Estado = 'A'" + " order by nombre");
            cbInsumoBaja.DisplayMember = "Nombre";
            cbInsumoBaja.ValueMember = "ID_Insumo";
            cbInsumoAlta.DataSource = conexion.Select("*", "Insumos", "Estado = 'I'" + " order by nombre");
            cbInsumoAlta.DisplayMember = "Nombre";
            cbInsumoAlta.ValueMember = "ID_Insumo";
            cbInsumoMod.DataSource = conexion.Select("*", "Insumos", "Estado = 'A'" + " order by nombre");
            cbInsumoMod.DisplayMember = "Nombre";
            cbInsumoMod.ValueMember = "ID_Insumo";
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            String estado = conexion.Select1Valor("Select dbo.VerificarInsumoxDelete('" + cbInsumoBaja.SelectedValue.ToString() + "')");
            if (estado == "True")
                ep1.SetError(cbInsumoBaja, "Error, este insumo está en alguna receta, favor de verificarlo");
            else
                if (MessageBox.Show("¿Está seguro que desea dar de baja este insumo de la base de datos?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (conexion.Update("Insumos", "Estado = 'I'", "ID_Insumo = " + cbInsumoBaja.SelectedValue.ToString()))
                    {
                        Msgbox("Se ha dado de baja con éxito.");
                    }
                    else
                    {
                        Msgbox("Ha ocurrido un error al dar de baja.");
                    }
                    ActualizarCB();
                }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (conexion.Update("Insumos", "Estado = 'A'", "ID_Insumo = " + cbInsumoAlta.SelectedValue.ToString()))
            {
                Msgbox("Se ha dado reactivado el insumo con éxito.");
            }
            else
            {
                Msgbox("Ha ocurrido un error al tratar de reactivar el insumo.");
            }
            ActualizarCB();
        }

        private void cbInsumoMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCampos();
        }
        private void ActualizarCampos()
        {
            txtIDInsumo.Text = cbInsumoMod.SelectedValue.ToString();
            txtNombre.Text = conexion.Select1Valor("Select Nombre from Insumos where ID_Insumo = " + txtIDInsumo.Text);
            txtCantidad.Text = conexion.Select1Valor("Select Cantidad from Insumos where ID_Insumo = " + txtIDInsumo.Text);
            txtStockMin.Text = conexion.Select1Valor("select stock_min from Insumos where ID_Insumo = " + txtIDInsumo.Text);
            txtCostoPromedio.Text = conexion.Select1Valor("select Costo_Promedio from Insumos where ID_Insumo = " + txtIDInsumo.Text);
            txtUMedida.Text = conexion.Select1Valor("Select U_Medida from Insumos where ID_Insumo = " + txtIDInsumo.Text);
            txtTipoInsumo.Text = conexion.Select1Valor("select Tipo_Insumo.Descripcion from Insumos join Tipo_Insumo on Tipo_Insumo.ID_Tipo_Insumo = Insumos.ID_Tipo_Insumo where Insumos.ID_Insumo = " + txtIDInsumo.Text);
            txtCantidad.Text = conexion.Select1Valor("Select cantidad from insumos where ID_Insumo = " + txtIDInsumo.Text);
            if (cbInsumoAlta.Items.Count == 0)
                groupBox1.Visible = false;
            else
                groupBox1.Visible = true;
            if (cbInsumoBaja.Items.Count == 0)
                groupBox3.Visible = false;
            else
                groupBox3.Visible = true;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (txtNombre.Text == "")
                ep1.SetError(txtNombre, "Error, no ha introducido el nuevo nombre, favor de verificarlo");
            else if (txtStockMin.Text == "")
                ep1.SetError(txtStockMin, "Error, no ha introducido el nuevo stock mínimo, favor de verificarlo");
            else if (Convert.ToDouble(txtStockMin.Text) < 0)
                ep1.SetError(txtStockMin, "Error, no ha introducido una cantidad válida en el nuevo stock mínimo, favor de verificarlo");
            else
            {
                if (MessageBox.Show("¿Está seguro que desea actualizar la información del insumo de la base de datos?", "Advertencia",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (conexion.Update("Insumos", "Stock_Min = " + txtStockMin.Text + ", Nombre = '" + txtNombre.Text + "'", "ID_Insumo = " + txtIDInsumo.Text))
                    {
                        Msgbox("Se ha actualizado la información del insumo con éxito.");
                    }
                    else
                    {
                        Msgbox("Ha ocurrido un error al tratar de actualizar la información del insumo.");
                    }
                    ActualizarCB();
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

        private void registrarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarInsumos REGINSU = new frmRegistrarInsumos();
            REGINSU.Show();
            this.Close();
        }
    }
}
