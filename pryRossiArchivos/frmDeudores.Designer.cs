namespace pryRossiArchivos
{
    partial class frmDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantClie = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblTotalCli = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.dgvClientes);
            this.gbConsulta.Controls.Add(this.lblPromedio);
            this.gbConsulta.Controls.Add(this.lblCantClie);
            this.gbConsulta.Controls.Add(this.lblPromDeuda);
            this.gbConsulta.Controls.Add(this.lblTotalCli);
            this.gbConsulta.Controls.Add(this.lblTotalDeuda);
            this.gbConsulta.Controls.Add(this.lblClientes);
            this.gbConsulta.Location = new System.Drawing.Point(16, 15);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(4);
            this.gbConsulta.Size = new System.Drawing.Size(659, 468);
            this.gbConsulta.TabIndex = 14;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de Datos";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda,
            this.colLimite});
            this.dgvClientes.Location = new System.Drawing.Point(8, 47);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(627, 224);
            this.dgvClientes.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(509, 409);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(125, 32);
            this.lblPromedio.TabIndex = 11;
            // 
            // lblCantClie
            // 
            this.lblCantClie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClie.Location = new System.Drawing.Point(509, 357);
            this.lblCantClie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClie.Name = "lblCantClie";
            this.lblCantClie.Size = new System.Drawing.Size(125, 32);
            this.lblCantClie.TabIndex = 9;
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(351, 410);
            this.lblPromDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(139, 20);
            this.lblPromDeuda.TabIndex = 10;
            this.lblPromDeuda.Text = "Promedio Deuda:";
            // 
            // lblTotalCli
            // 
            this.lblTotalCli.AutoSize = true;
            this.lblTotalCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCli.Location = new System.Drawing.Point(348, 310);
            this.lblTotalCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCli.Name = "lblTotalCli";
            this.lblTotalCli.Size = new System.Drawing.Size(105, 20);
            this.lblTotalCli.TabIndex = 6;
            this.lblTotalCli.Text = "Total Deuda:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(509, 298);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(125, 32);
            this.lblTotalDeuda.TabIndex = 7;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(348, 358);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(146, 20);
            this.lblClientes.TabIndex = 8;
            this.lblClientes.Text = "Cantidad Clientes:";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 170;
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Limite Crédito";
            this.colLimite.MinimumWidth = 6;
            this.colLimite.Name = "colLimite";
            this.colLimite.Width = 125;
            // 
            // frmDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 502);
            this.Controls.Add(this.gbConsulta);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES DEUDORES";
            this.Load += new System.EventHandler(this.frmDeudores_Load);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantClie;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Label lblTotalCli;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
    }
}