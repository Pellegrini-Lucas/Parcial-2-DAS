namespace SistemaReservas.Views
{
    partial class frmMenuPrincipal
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
            this.btnGestionReservas = new System.Windows.Forms.Button();
            this.btnGestionLaboratorios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnIntegrantes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnGestionReservas
            //
            this.btnGestionReservas.Location = new System.Drawing.Point(50, 30);
            this.btnGestionReservas.Name = "btnGestionReservas";
            this.btnGestionReservas.Size = new System.Drawing.Size(200, 40);
            this.btnGestionReservas.TabIndex = 0;
            this.btnGestionReservas.Text = "Gestión de Reservas";
            this.btnGestionReservas.UseVisualStyleBackColor = true;
            this.btnGestionReservas.Click += new System.EventHandler(this.btnGestionReservas_Click);
            //
            // btnGestionLaboratorios
            //
            this.btnGestionLaboratorios.Location = new System.Drawing.Point(50, 80);
            this.btnGestionLaboratorios.Name = "btnGestionLaboratorios";
            this.btnGestionLaboratorios.Size = new System.Drawing.Size(200, 40);
            this.btnGestionLaboratorios.TabIndex = 1;
            this.btnGestionLaboratorios.Text = "Gestión de Laboratorios";
            this.btnGestionLaboratorios.UseVisualStyleBackColor = true;
            this.btnGestionLaboratorios.Click += new System.EventHandler(this.btnGestionLaboratorios_Click);
            //
            // btnReportes
            //
            this.btnReportes.Location = new System.Drawing.Point(50, 130);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 40);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Generación de Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            //
            // btnIntegrantes
            //
            this.btnIntegrantes.Location = new System.Drawing.Point(50, 180);
            this.btnIntegrantes.Name = "btnIntegrantes";
            this.btnIntegrantes.Size = new System.Drawing.Size(200, 40);
            this.btnIntegrantes.TabIndex = 3;
            this.btnIntegrantes.Text = "Integrantes del Desarrollo";
            this.btnIntegrantes.UseVisualStyleBackColor = true;
            this.btnIntegrantes.Click += new System.EventHandler(this.btnIntegrantes_Click);
            //
            // btnSalir
            //
            this.btnSalir.Location = new System.Drawing.Point(50, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // frmMenuPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIntegrantes);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnGestionLaboratorios);
            this.Controls.Add(this.btnGestionReservas);
            this.Name = "frmMenuPrincipal";
            this.Text = "Sistema de Reservas - Menú Principal";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGestionReservas;
        private System.Windows.Forms.Button btnGestionLaboratorios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnIntegrantes;
        private System.Windows.Forms.Button btnSalir;
    }
}
