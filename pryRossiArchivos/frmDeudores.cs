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
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        clsArchivo arc = new clsArchivo();

        private void frmDeudores_Load(object sender, EventArgs e)
        {
            arc.Listar(dgvClientes);
        }
    }
}
