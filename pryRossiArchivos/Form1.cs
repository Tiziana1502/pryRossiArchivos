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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsArchivo arc = new clsArchivo();    

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }

        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            arc.Grabar(txtCodigo.Text, txtUsuario.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Los datos se grabaron correctamente", "Datos cargados", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpio los controles una vez que se hayan cargado
            txtCodigo.Text = "";
            txtUsuario.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";
                      
        }
    }
}
