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
    public partial class frmRegistrarFalloMobiliario : Form
    {
        Conexion conexion = new Conexion();
        public frmRegistrarFalloMobiliario()
        {
            InitializeComponent();
        }

        private void frmBajaMobiliario_Load(object sender, EventArgs e)
        {
            cbMobiliario.DataSource = conexion.Select("id_insumo,nombre","v_mobiliario","sucursal = " + Globales.ID_SucursalL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtComentario.Text == "")
            {
                ep.SetError(txtComentario, "El comentario es obligatorio para poder ser atendida la queja");
            }
            else
            {
                string funciona;
                if (rbSi.Checked == true)
                {
                    funciona = "S";
                }
                else
                {
                    funciona = "N";
                }
                if (conexion.Insert("falloMaquinaria","id_sucursal,id_mobiliario,fecha,descripcion,funciona",com(Globales.ID_SucursalL) + "," + 
                    com(cbMobiliario.SelectedValue.ToString()) + "," + com(dtp.Value.ToString("yyyyMMdd")) + "," + 
                    com(txtComentario.Text) + "," + com(funciona)))
                {
                    MessageBox.Show("Falla reportada con éxito");
                    this.Close();
                }
            }
        }
        private string com(string cad) { return "'" + cad + "'"; }
    }
}
