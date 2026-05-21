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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = -1;
            cmbModo.SelectedIndex = -1;

            switch (cmbModo.SelectedIndex)
            {
                case 0:
                    if (cmbCampo.SelectedIndex == 0)
                    {
                        clsArchivo.OrdenarPorCodigoAscendente();
                    }
                    else
                    {
                        clsArchivo.OrdenarPorCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbCampo.SelectedIndex == 1)
                    {
                        clsArchivo.OrdenarPorNombreAscendente();
                    }
                    else
                    {
                        clsArchivo.OrdenarPorNombreDescendente();
                    }
                    break;
                case 2:
                    if (cmbCampo.SelectedIndex == 2)
                    {
                        clsArchivo.OrdenarPorLimiteAscendente();
                    }
                    else
                    {
                        clsArchivo.OrdenarPorLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cmbCampo.SelectedIndex == 3)
                    {
                        clsArchivo.OrdenarPorDeudaAscendente();
                    }
                    else
                    {
                        clsArchivo.OrdenarPorDeudaDescendente();
                    }
                    break;
            }

            //dgvListado.Rows.Clear();
            //for (Int32 i = 0; i < clsVector.IND; i++)
            //{
              //  dgvListado.Rows.Add(clsVector.Clientes[i].Codigo, clsVector.Clientes[i].Nombre, clsVector.Clientes[i].Limite, clsVector.Clientes[i].Deuda);
            //}
        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            cmbCampo.Items.Add("Código");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Limite Crédito");
            cmbCampo.Items.Add("Deuda");

            cmbModo.Items.Add("Ascendente");
            cmbModo.Items.Add("Descendente");
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex != -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }

        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModo.SelectedIndex != -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }
    }
}
