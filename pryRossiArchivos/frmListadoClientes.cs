using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRossiArchivos
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsArchivo arc = new clsArchivo();

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            arc.Listar(dgvClientes);
            lblTotalDeuda.Text = "$" + arc.TotalDeuda().ToString();
            lblCantClie.Text = arc.CantClientes().ToString();            
            lblPromedio.Text = "$" + arc.Promedio().ToString(); 
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            arc.GenerarReporte();
            MessageBox.Show("El reporte ha sido realizado", "Reporte Generado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
