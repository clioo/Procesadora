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
    public partial class FrmRegistrarReceta : Form
    {
        public FrmRegistrarProducto regproducto;
        Conexion conexion = new Conexion();
        public int ID_Producto;
        public FrmRegistrarReceta()
        {
            InitializeComponent();
        }
        void Msgbox(String Cadena)
        {
            MessageBox.Show(Cadena);
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (dgvReceta.RowCount > 0)
            {
                Boolean Boleana = true;
                for (int i = 0; i < dgvReceta.Rows.Count - 1; i++)
                {
                    if (!conexion.Insert("RecetaXRepeticion", "ID_Producto, ID_Insumo, Cantidad", ID_Producto.ToString() + ", " + dgvReceta.Rows[i].Cells[2].Value.ToString() + ", " + dgvReceta.Rows[i].Cells[1].Value.ToString()))
                    {
                        Boleana = false;
                    }
                }
                if (Boleana)
                {
                    regproducto.Close();
                    MessageBox.Show("Se ha registrado con éxito");
                    this.Close();
                }
            }
        }

        private void FrmRegistrarReceta_Load(object sender, EventArgs e)
        {
            cbInsumo.DataSource = conexion.Select("*" , "Insumos", " Estado = 'A'");
            cbInsumo.ValueMember = "ID_Insumo";
            cbInsumo.DisplayMember = "Nombre";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCantidad.Text.Contains("."))
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

        private void cmd_Agregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.TextLength == 0)
            {
                ep.SetError(txtCantidad, "No se ha introducido una cantidad");
            }
            else if (Convert.ToDouble(txtCantidad.Text) <= 0)
            {
                ep.SetError(txtCantidad, "La cantidad no puede ser menor o igual a 0");
            }
            else
            {
                for (int i = 0; i < dgvReceta.Rows.Count; i++)
                {
                    if (dgvReceta.Rows[i].Cells[0].Value.ToString() == cbInsumo.Text)
                    {
                        dgvReceta.Rows[i].Cells[1].Value = Convert.ToDouble(dgvReceta.Rows[i].Cells[1].Value) + Convert.ToDouble(txtCantidad.Text);
                        return;
                    }
                }
                dgvReceta.Rows.Add(cbInsumo.Text.ToString(), txtCantidad.Text, cbInsumo.SelectedValue.ToString());
                txtCantidad.Focus();
                txtCantidad.Clear();
            }
        }

        private void cmd_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReceta.Rows.RemoveAt(dgvReceta.CurrentRow.Index);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dgvReceta.Rows.Clear();
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            dgvReceta.Rows.Clear();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
