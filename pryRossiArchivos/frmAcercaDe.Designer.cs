namespace pryRossiArchivos
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.lblDatos = new System.Windows.Forms.Label();
            this.pbaboutme = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbaboutme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatos.Location = new System.Drawing.Point(25, 264);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(242, 167);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.Text = "NOMBRE: Tiziana Nahir Rossi\r\nDNI: 47586152\r\nCARRERA: Analista en Sistemas de Comp" +
    "utación\r\nMATERIA: Laboratorio de Programación II\r\nPROFESORA: Sebastian Benito";
            // 
            // pbaboutme
            // 
            this.pbaboutme.Image = ((System.Drawing.Image)(resources.GetObject("pbaboutme.Image")));
            this.pbaboutme.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbaboutme.InitialImage")));
            this.pbaboutme.Location = new System.Drawing.Point(44, 11);
            this.pbaboutme.Margin = new System.Windows.Forms.Padding(2);
            this.pbaboutme.Name = "pbaboutme";
            this.pbaboutme.Size = new System.Drawing.Size(201, 211);
            this.pbaboutme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbaboutme.TabIndex = 13;
            this.pbaboutme.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(39, 233);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 31);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "ACERCA DE MI...";
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 415);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pbaboutme);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.pbaboutme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.PictureBox pbaboutme;
        private System.Windows.Forms.Label lblTitulo;
    }
}