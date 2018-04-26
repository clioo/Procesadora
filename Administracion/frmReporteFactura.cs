using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procesadora.Administracion;

namespace Procesadora
{
    public partial class frmReporteFactura : Form
    {
        Conexion conexion = new Conexion();
        public frmReporteFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.Select1Valor("select 'True' from v_facturas_desarrolladas where factura = "+ textBox1.Text) == "True")
            {
                frmReportes rep = new frmReportes();
                facturas fac = new facturas();
                fac.SetParameterValue("@id_factura",textBox1.Text);
                rep.crystalReportViewer1.ReportSource = fac;
                rep.Show();
            }
            else
            {
                ep.SetError(textBox1,"Esa factura de venta no existe");
            }
        }
    }
}
