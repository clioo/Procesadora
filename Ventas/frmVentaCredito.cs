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
    public partial class frmVentaCredito : Form
    {
        Conexion conexion = new Conexion();
        string id_venta, id_cliente;
        public frmVentaCredito(string id_venta, string id_cliente)
        {
            InitializeComponent();
            this.id_venta = id_venta;
            this.id_cliente = id_cliente;
        }

        private void frmVentaCredito_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (conexion.Insert("cuentasXcobrar","id_venta,id_cliente,fechaLimite",com(id_venta) + "," + com(id_cliente) + "," + com(dateTimePicker1.Value.ToString("yyyyMMdd"))))
            {
                MessageBox.Show("Registrado con éxito");
                this.Close();
                frmVentaGeneral vg = new frmVentaGeneral();
                vg.Show();
            }
            else
            {
                MessageBox.Show("Error con la base de datos");
            }
        }
        private string com(string cadena) { return "'" + cadena + "'"; }
    }
}
