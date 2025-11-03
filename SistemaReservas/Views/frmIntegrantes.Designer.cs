namespace SistemaReservas.Views
{
    partial class frmIntegrantes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIntegrante1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Equipo de Desarrollo";
            //
            // lblIntegrante1
            //
            this.lblIntegrante1.AutoSize = true;
            this.lblIntegrante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante1.Location = new System.Drawing.Point(30, 70);
            this.lblIntegrante1.Name = "lblIntegrante1";
            this.lblIntegrante1.Size = new System.Drawing.Size(350, 17);
            this.lblIntegrante1.TabIndex = 1;
            this.lblIntegrante1.Text = "Apellido, Nombres, email.institucional@uai.edu.ar";
            //
            // frmIntegrantes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 150);
            this.Controls.Add(this.lblIntegrante1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmIntegrantes";
            this.Text = "Integrantes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntegrante1;
    }
}
