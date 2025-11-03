namespace Parcial_2_DAS.Views
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
            lblTitulo = new Label();
            lblIntegrante1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(35, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(208, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Equipo de Desarrollo";
            // 
            // lblIntegrante1
            // 
            lblIntegrante1.AutoSize = true;
            lblIntegrante1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntegrante1.Location = new Point(35, 81);
            lblIntegrante1.Margin = new Padding(4, 0, 4, 0);
            lblIntegrante1.Name = "lblIntegrante1";
            lblIntegrante1.Size = new Size(355, 17);
            lblIntegrante1.TabIndex = 1;
            lblIntegrante1.Text = "Pellegrini, Lucas, Lucas.Pellegrini@alumnos.uai.edu.ar";
            // 
            // frmIntegrantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 173);
            Controls.Add(lblIntegrante1);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmIntegrantes";
            Text = "Integrantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntegrante1;
    }
}
