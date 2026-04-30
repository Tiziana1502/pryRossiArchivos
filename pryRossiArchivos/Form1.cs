using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            if (arc.ExisteCodigo(txtCodigo.Text))
            {
                MessageBox.Show("El código ingresado ya pertenece a otro cliente.", "Código Duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus(); // Pone el cursor en el error
                txtCodigo.SelectAll();
            }
            else
            {
                arc.Grabar(txtCodigo.Text, txtUsuario.Text, txtDeuda.Text, txtLimite.Text);
                MessageBox.Show("Los datos se grabaron correctamente", "Datos cargados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Limpio los controles una vez que se hayan cargado
            txtCodigo.Text = "";
            txtUsuario.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";
                      
        }
        

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }
    }
}
