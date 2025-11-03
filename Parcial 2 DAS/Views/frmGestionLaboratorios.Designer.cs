namespace Parcial_2_DAS.Views
{
    partial class frmGestionLaboratorios
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
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvLaboratorios
            //
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Location = new System.Drawing.Point(12, 12);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            this.dgvLaboratorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratorios.Size = new System.Drawing.Size(460, 200);
            this.dgvLaboratorios.TabIndex = 0;
            this.dgvLaboratorios.SelectionChanged += new System.EventHandler(this.dgvLaboratorios_SelectionChanged);
            //
            // grpDatos
            //
            this.grpDatos.Controls.Add(this.btnBaja);
            this.grpDatos.Controls.Add(this.btnModificacion);
            this.grpDatos.Controls.Add(this.btnAlta);
            this.grpDatos.Controls.Add(this.txtCapacidad);
            this.grpDatos.Controls.Add(this.lblCapacidad);
            this.grpDatos.Controls.Add(this.txtPiso);
            this.grpDatos.Controls.Add(this.lblPiso);
            this.grpDatos.Controls.Add(this.txtNumero);
            this.grpDatos.Controls.Add(this.lblNumero);
            this.grpDatos.Location = new System.Drawing.Point(12, 220);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(460, 130);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Laboratorio";
            //
            // btnBaja
            //
            this.btnBaja.Location = new System.Drawing.Point(320, 90);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(120, 30);
            this.btnBaja.TabIndex = 8;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            //
            // btnModificacion
            //
            this.btnModificacion.Location = new System.Drawing.Point(320, 55);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(120, 30);
            this.btnModificacion.TabIndex = 7;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            //
            // btnAlta
            //
            this.btnAlta.Location = new System.Drawing.Point(320, 20);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(120, 30);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            //
            // txtCapacidad
            //
            this.txtCapacidad.Location = new System.Drawing.Point(130, 90);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(150, 20);
            this.txtCapacidad.TabIndex = 5;
            //
            // lblCapacidad
            //
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(20, 93);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(104, 13);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Capacidad Puestos:";
            //
            // txtPiso
            //
            this.txtPiso.Location = new System.Drawing.Point(130, 58);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(150, 20);
            this.txtPiso.TabIndex = 3;
            //
            // lblPiso
            //
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(20, 61);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(84, 13);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Ubicación Piso:";
            //
            // txtNumero
            //
            this.txtNumero.Location = new System.Drawing.Point(130, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 1;
            //
            // lblNumero
            //
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(95, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número Asignado:";
            //
            // frmGestionLaboratorios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dgvLaboratorios);
            this.Name = "frmGestionLaboratorios";
            this.Text = "Gestión de Laboratorios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
    }
}
