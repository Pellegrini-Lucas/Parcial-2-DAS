namespace SistemaReservas.Views
{
    partial class frmGestionReservas
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
            this.grpDatosReserva = new System.Windows.Forms.GroupBox();
            this.pnlEventual = new System.Windows.Forms.Panel();
            this.numSemanas = new System.Windows.Forms.NumericUpDown();
            this.lblSemanas = new System.Windows.Forms.Label();
            this.dtpEventualComienzo = new System.Windows.Forms.DateTimePicker();
            this.lblEventualComienzo = new System.Windows.Forms.Label();
            this.pnlCuatrimestral = new System.Windows.Forms.Panel();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.dtpCuatriFin = new System.Windows.Forms.DateTimePicker();
            this.lblCuatriFin = new System.Windows.Forms.Label();
            this.dtpCuatriComienzo = new System.Windows.Forms.DateTimePicker();
            this.lblCuatriComienzo = new System.Windows.Forms.Label();
            this.cmbTipoReserva = new System.Windows.Forms.ComboBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltroAsignatura = new System.Windows.Forms.TextBox();
            this.lblFiltroAsignatura = new System.Windows.Forms.Label();
            this.txtFiltroProfesor = new System.Windows.Forms.TextBox();
            this.lblFiltroProfesor = new System.Windows.Forms.Label();
            this.dtpFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroFecha = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.grpDatosReserva.SuspendLayout();
            this.pnlEventual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSemanas)).BeginInit();
            this.pnlCuatrimestral.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            //
            // grpDatosReserva
            //
            this.grpDatosReserva.Controls.Add(this.pnlEventual);
            this.grpDatosReserva.Controls.Add(this.pnlCuatrimestral);
            this.grpDatosReserva.Controls.Add(this.cmbTipoReserva);
            this.grpDatosReserva.Controls.Add(this.lblTipoReserva);
            this.grpDatosReserva.Controls.Add(this.txtProfesor);
            this.grpDatosReserva.Controls.Add(this.lblProfesor);
            this.grpDatosReserva.Controls.Add(this.txtComision);
            this.grpDatosReserva.Controls.Add(this.lblComision);
            this.grpDatosReserva.Controls.Add(this.txtAnio);
            this.grpDatosReserva.Controls.Add(this.lblAnio);
            this.grpDatosReserva.Controls.Add(this.txtAsignatura);
            this.grpDatosReserva.Controls.Add(this.lblAsignatura);
            this.grpDatosReserva.Controls.Add(this.txtCarrera);
            this.grpDatosReserva.Controls.Add(this.lblCarrera);
            this.grpDatosReserva.Controls.Add(this.cmbLaboratorio);
            this.grpDatosReserva.Controls.Add(this.lblLaboratorio);
            this.grpDatosReserva.Location = new System.Drawing.Point(12, 12);
            this.grpDatosReserva.Name = "grpDatosReserva";
            this.grpDatosReserva.Size = new System.Drawing.Size(760, 220);
            this.grpDatosReserva.TabIndex = 0;
            this.grpDatosReserva.TabStop = false;
            this.grpDatosReserva.Text = "Datos de la Reserva";
            //
            // pnlEventual
            //
            this.pnlEventual.Controls.Add(this.numSemanas);
            this.pnlEventual.Controls.Add(this.lblSemanas);
            this.pnlEventual.Controls.Add(this.dtpEventualComienzo);
            this.pnlEventual.Controls.Add(this.lblEventualComienzo);
            this.pnlEventual.Location = new System.Drawing.Point(400, 55);
            this.pnlEventual.Name = "pnlEventual";
            this.pnlEventual.Size = new System.Drawing.Size(350, 150);
            this.pnlEventual.TabIndex = 15;
            //
            // numSemanas
            //
            this.numSemanas.Location = new System.Drawing.Point(130, 45);
            this.numSemanas.Name = "numSemanas";
            this.numSemanas.Size = new System.Drawing.Size(200, 20);
            this.numSemanas.TabIndex = 3;
            //
            // lblSemanas
            //
            this.lblSemanas.AutoSize = true;
            this.lblSemanas.Location = new System.Drawing.Point(10, 47);
            this.lblSemanas.Name = "lblSemanas";
            this.lblSemanas.Size = new System.Drawing.Size(113, 13);
            this.lblSemanas.TabIndex = 2;
            this.lblSemanas.Text = "Cantidad de Semanas:";
            //
            // dtpEventualComienzo
            //
            this.dtpEventualComienzo.Location = new System.Drawing.Point(130, 10);
            this.dtpEventualComienzo.Name = "dtpEventualComienzo";
            this.dtpEventualComienzo.Size = new System.Drawing.Size(200, 20);
            this.dtpEventualComienzo.TabIndex = 1;
            //
            // lblEventualComienzo
            //
            this.lblEventualComienzo.AutoSize = true;
            this.lblEventualComienzo.Location = new System.Drawing.Point(10, 16);
            this.lblEventualComienzo.Name = "lblEventualComienzo";
            this.lblEventualComienzo.Size = new System.Drawing.Size(96, 13);
            this.lblEventualComienzo.TabIndex = 0;
            this.lblEventualComienzo.Text = "Fecha de Comienzo:";
            //
            // pnlCuatrimestral
            //
            this.pnlCuatrimestral.Controls.Add(this.cmbFrecuencia);
            this.pnlCuatrimestral.Controls.Add(this.lblFrecuencia);
            this.pnlCuatrimestral.Controls.Add(this.dtpCuatriFin);
            this.pnlCuatrimestral.Controls.Add(this.lblCuatriFin);
            this.pnlCuatrimestral.Controls.Add(this.dtpCuatriComienzo);
            this.pnlCuatrimestral.Controls.Add(this.lblCuatriComienzo);
            this.pnlCuatrimestral.Location = new System.Drawing.Point(400, 55);
            this.pnlCuatrimestral.Name = "pnlCuatrimestral";
            this.pnlCuatrimestral.Size = new System.Drawing.Size(350, 150);
            this.pnlCuatrimestral.TabIndex = 14;
            //
            // cmbFrecuencia
            //
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Location = new System.Drawing.Point(130, 80);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(200, 21);
            this.cmbFrecuencia.TabIndex = 5;
            //
            // lblFrecuencia
            //
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(10, 83);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia.TabIndex = 4;
            this.lblFrecuencia.Text = "Frecuencia:";
            //
            // dtpCuatriFin
            //
            this.dtpCuatriFin.Location = new System.Drawing.Point(130, 45);
            this.dtpCuatriFin.Name = "dtpCuatriFin";
            this.dtpCuatriFin.Size = new System.Drawing.Size(200, 20);
            this.dtpCuatriFin.TabIndex = 3;
            //
            // lblCuatriFin
            //
            this.lblCuatriFin.AutoSize = true;
            this.lblCuatriFin.Location = new System.Drawing.Point(10, 51);
            this.lblCuatriFin.Name = "lblCuatriFin";
            this.lblCuatriFin.Size = new System.Drawing.Size(107, 13);
            this.lblCuatriFin.TabIndex = 2;
            this.lblCuatriFin.Text = "Fecha de Finalización:";
            //
            // dtpCuatriComienzo
            //
            this.dtpCuatriComienzo.Location = new System.Drawing.Point(130, 10);
            this.dtpCuatriComienzo.Name = "dtpCuatriComienzo";
            this.dtpCuatriComienzo.Size = new System.Drawing.Size(200, 20);
            this.dtpCuatriComienzo.TabIndex = 1;
            //
            // lblCuatriComienzo
            //
            this.lblCuatriComienzo.AutoSize = true;
            this.lblCuatriComienzo.Location = new System.Drawing.Point(10, 16);
            this.lblCuatriComienzo.Name = "lblCuatriComienzo";
            this.lblCuatriComienzo.Size = new System.Drawing.Size(96, 13);
            this.lblCuatriComienzo.TabIndex = 0;
            this.lblCuatriComienzo.Text = "Fecha de Comienzo:";
            //
            // cmbTipoReserva
            //
            this.cmbTipoReserva.FormattingEnabled = true;
            this.cmbTipoReserva.Location = new System.Drawing.Point(520, 25);
            this.cmbTipoReserva.Name = "cmbTipoReserva";
            this.cmbTipoReserva.Size = new System.Drawing.Size(210, 21);
            this.cmbTipoReserva.TabIndex = 13;
            this.cmbTipoReserva.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReserva_SelectedIndexChanged);
            //
            // lblTipoReserva
            //
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(410, 28);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(89, 13);
            this.lblTipoReserva.TabIndex = 12;
            this.lblTipoReserva.Text = "Tipo de Reserva:";
            //
            // txtProfesor
            //
            this.txtProfesor.Location = new System.Drawing.Point(100, 185);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(280, 20);
            this.txtProfesor.TabIndex = 11;
            //
            // lblProfesor
            //
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(20, 188);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(49, 13);
            this.lblProfesor.TabIndex = 10;
            this.lblProfesor.Text = "Profesor:";
            //
            // txtComision
            //
            this.txtComision.Location = new System.Drawing.Point(100, 155);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(280, 20);
            this.txtComision.TabIndex = 9;
            //
            // lblComision
            //
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(20, 158);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 13);
            this.lblComision.TabIndex = 8;
            this.lblComision.Text = "Comisión:";
            //
            // txtAnio
            //
            this.txtAnio.Location = new System.Drawing.Point(100, 125);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(280, 20);
            this.txtAnio.TabIndex = 7;
            //
            // lblAnio
            //
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(20, 128);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 6;
            this.lblAnio.Text = "Año:";
            //
            // txtAsignatura
            //
            this.txtAsignatura.Location = new System.Drawing.Point(100, 90);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(280, 20);
            this.txtAsignatura.TabIndex = 5;
            //
            // lblAsignatura
            //
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(20, 93);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(60, 13);
            this.lblAsignatura.TabIndex = 4;
            this.lblAsignatura.Text = "Asignatura:";
            //
            // txtCarrera
            //
            this.txtCarrera.Location = new System.Drawing.Point(100, 58);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(280, 20);
            this.txtCarrera.TabIndex = 3;
            //
            // lblCarrera
            //
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(20, 61);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 2;
            this.lblCarrera.Text = "Carrera:";
            //
            // cmbLaboratorio
            //
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(100, 25);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(280, 21);
            this.cmbLaboratorio.TabIndex = 1;
            //
            // lblLaboratorio
            //
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(20, 28);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(63, 13);
            this.lblLaboratorio.TabIndex = 0;
            this.lblLaboratorio.Text = "Laboratorio:";
            //
            // btnBaja
            //
            this.btnBaja.Location = new System.Drawing.Point(652, 238);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(120, 30);
            this.btnBaja.TabIndex = 11;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            //
            // btnModificacion
            //
            this.btnModificacion.Location = new System.Drawing.Point(526, 238);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(120, 30);
            this.btnModificacion.TabIndex = 10;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            //
            // btnAlta
            //
            this.btnAlta.Location = new System.Drawing.Point(400, 238);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(120, 30);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            //
            // grpConsulta
            //
            this.grpConsulta.Controls.Add(this.btnBuscar);
            this.grpConsulta.Controls.Add(this.txtFiltroAsignatura);
            this.grpConsulta.Controls.Add(this.lblFiltroAsignatura);
            this.grpConsulta.Controls.Add(this.txtFiltroProfesor);
            this.grpConsulta.Controls.Add(this.lblFiltroProfesor);
            this.grpConsulta.Controls.Add(this.dtpFiltroFecha);
            this.grpConsulta.Controls.Add(this.lblFiltroFecha);
            this.grpConsulta.Location = new System.Drawing.Point(12, 274);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(760, 70);
            this.grpConsulta.TabIndex = 12;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de Reservas";
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(634, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // txtFiltroAsignatura
            //
            this.txtFiltroAsignatura.Location = new System.Drawing.Point(448, 31);
            this.txtFiltroAsignatura.Name = "txtFiltroAsignatura";
            this.txtFiltroAsignatura.Size = new System.Drawing.Size(180, 20);
            this.txtFiltroAsignatura.TabIndex = 5;
            //
            // lblFiltroAsignatura
            //
            this.lblFiltroAsignatura.AutoSize = true;
            this.lblFiltroAsignatura.Location = new System.Drawing.Point(445, 15);
            this.lblFiltroAsignatura.Name = "lblFiltroAsignatura";
            this.lblFiltroAsignatura.Size = new System.Drawing.Size(81, 13);
            this.lblFiltroAsignatura.TabIndex = 4;
            this.lblFiltroAsignatura.Text = "Por Asignatura:";
            //
            // txtFiltroProfesor
            //
            this.txtFiltroProfesor.Location = new System.Drawing.Point(247, 31);
            this.txtFiltroProfesor.Name = "txtFiltroProfesor";
            this.txtFiltroProfesor.Size = new System.Drawing.Size(180, 20);
            this.txtFiltroProfesor.TabIndex = 3;
            //
            // lblFiltroProfesor
            //
            this.lblFiltroProfesor.AutoSize = true;
            this.lblFiltroProfesor.Location = new System.Drawing.Point(244, 15);
            this.lblFiltroProfesor.Name = "lblFiltroProfesor";
            this.lblFiltroProfesor.Size = new System.Drawing.Size(69, 13);
            this.lblFiltroProfesor.TabIndex = 2;
            this.lblFiltroProfesor.Text = "Por Profesor:";
            //
            // dtpFiltroFecha
            //
            this.dtpFiltroFecha.Location = new System.Drawing.Point(23, 31);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFiltroFecha.TabIndex = 1;
            //
            // lblFiltroFecha
            //
            this.lblFiltroFecha.AutoSize = true;
            this.lblFiltroFecha.Location = new System.Drawing.Point(20, 15);
            this.lblFiltroFecha.Name = "lblFiltroFecha";
            this.lblFiltroFecha.Size = new System.Drawing.Size(59, 13);
            this.lblFiltroFecha.TabIndex = 0;
            this.lblFiltroFecha.Text = "Por Fecha:";
            //
            // dgvReservas
            //
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(12, 350);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(760, 200);
            this.dgvReservas.TabIndex = 13;
            this.dgvReservas.SelectionChanged += new System.EventHandler(this.dgvReservas_SelectionChanged);
            //
            // frmGestionReservas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.grpDatosReserva);
            this.Name = "frmGestionReservas";
            this.Text = "Gestión de Reservas";
            this.grpDatosReserva.ResumeLayout(false);
            this.grpDatosReserva.PerformLayout();
            this.pnlEventual.ResumeLayout(false);
            this.pnlEventual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSemanas)).EndInit();
            this.pnlCuatrimestral.ResumeLayout(false);
            this.pnlCuatrimestral.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosReserva;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Panel pnlCuatrimestral;
        private System.Windows.Forms.ComboBox cmbTipoReserva;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.Panel pnlEventual;
        private System.Windows.Forms.NumericUpDown numSemanas;
        private System.Windows.Forms.Label lblSemanas;
        private System.Windows.Forms.DateTimePicker dtpEventualComienzo;
        private System.Windows.Forms.Label lblEventualComienzo;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.DateTimePicker dtpCuatriFin;
        private System.Windows.Forms.Label lblCuatriFin;
        private System.Windows.Forms.DateTimePicker dtpCuatriComienzo;
        private System.Windows.Forms.Label lblCuatriComienzo;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltroAsignatura;
        private System.Windows.Forms.Label lblFiltroAsignatura;
        private System.Windows.Forms.TextBox txtFiltroProfesor;
        private System.Windows.Forms.Label lblFiltroProfesor;
        private System.Windows.Forms.DateTimePicker dtpFiltroFecha;
        private System.Windows.Forms.Label lblFiltroFecha;
        private System.Windows.Forms.DataGridView dgvReservas;
    }
}
