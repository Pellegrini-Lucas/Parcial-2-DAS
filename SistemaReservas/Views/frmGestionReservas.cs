using SistemaReservas.Controllers;
using SistemaReservas.Enums;
using SistemaReservas.Interfaces;
using SistemaReservas.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaReservas.Views
{
    public partial class frmGestionReservas : Form
    {
        private readonly ReservaController _reservaController;
        private readonly LaboratorioController _laboratorioController;

        public frmGestionReservas(IReservaRepositorio reservaRepo, ILaboratorioRepositorio labRepo)
        {
            InitializeComponent();
            _reservaController = new ReservaController(reservaRepo, labRepo);
            _laboratorioController = new LaboratorioController(labRepo, reservaRepo);

            InicializarControles();
            CargarReservas();
        }

        private void InicializarControles()
        {
            // Cargar ComboBox de Tipo de Reserva
            cmbTipoReserva.Items.AddRange(new string[] { "Cuatrimestral", "Eventual" });
            cmbTipoReserva.SelectedIndex = 0;

            // Cargar ComboBox de Laboratorios
            cmbLaboratorio.DataSource = _laboratorioController.CargarLaboratorios();
            cmbLaboratorio.DisplayMember = "NumeroAsignado";
            cmbLaboratorio.ValueMember = "NumeroAsignado";

            // Cargar ComboBox de Frecuencia
            cmbFrecuencia.DataSource = Enum.GetValues(typeof(FrecuenciaReserva));

            // Configuración inicial de paneles
            pnlCuatrimestral.Visible = true;
            pnlEventual.Visible = false;
        }

        private void CargarReservas(string filtro = null, object valor = null)
        {
            try
            {
                dgvReservas.DataSource = null;
                var reservas = _reservaController.ConsultarReservas(filtro, valor);

                // Proyección para mostrar en el DataGridView
                dgvReservas.DataSource = reservas.Select(r => new {
                    r.IdReserva,
                    Laboratorio = r.LaboratorioAsignado.NumeroAsignado,
                    r.Carrera,
                    r.Asignatura,
                    r.Profesor,
                    Tipo = r is ReservaCuatrimestral ? "Cuatrimestral" : "Eventual"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCuatrimestral.Visible = (cmbTipoReserva.SelectedItem.ToString() == "Cuatrimestral");
            pnlEventual.Visible = (cmbTipoReserva.SelectedItem.ToString() == "Eventual");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                _reservaController.AltaReserva(
                    (int)cmbLaboratorio.SelectedValue,
                    txtCarrera.Text,
                    txtAsignatura.Text,
                    txtAnio.Text,
                    txtComision.Text,
                    txtProfesor.Text,
                    cmbTipoReserva.SelectedItem.ToString(),
                    dtpCuatriComienzo.Value,
                    dtpCuatriFin.Value,
                    (FrecuenciaReserva)cmbFrecuencia.SelectedItem,
                    dtpEventualComienzo.Value,
                    (int)numSemanas.Value
                );
                CargarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Alta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null) return;

            var confirm = MessageBox.Show("¿Está seguro de que desea eliminar la reserva seleccionada?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int idReserva = (int)dgvReservas.CurrentRow.Cells["IdReserva"].Value;
                    _reservaController.BajaReserva(idReserva);
                    CargarReservas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la Baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFiltroProfesor.Text))
            {
                CargarReservas("Profesor", txtFiltroProfesor.Text);
            }
            else if (!string.IsNullOrWhiteSpace(txtFiltroAsignatura.Text))
            {
                CargarReservas("Asignatura", txtFiltroAsignatura.Text);
            }
            else
            {
                CargarReservas("Fecha", dtpFiltroFecha.Value);
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null) return;

            try
            {
                int idReserva = (int)dgvReservas.CurrentRow.Cells["IdReserva"].Value;
                _reservaController.ModificarReserva(
                    idReserva,
                    (int)cmbLaboratorio.SelectedValue,
                    txtCarrera.Text,
                    txtAsignatura.Text,
                    txtAnio.Text,
                    txtComision.Text,
                    txtProfesor.Text,
                    cmbTipoReserva.SelectedItem.ToString(),
                    dtpCuatriComienzo.Value,
                    dtpCuatriFin.Value,
                    (FrecuenciaReserva)cmbFrecuencia.SelectedItem,
                    dtpEventualComienzo.Value,
                    (int)numSemanas.Value
                );
                CargarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null || dgvReservas.CurrentRow.DataBoundItem == null) return;

            // Obtener el ID de la reserva seleccionada en la vista anónima
            int idReserva = (int)dgvReservas.CurrentRow.Cells["IdReserva"].Value;

            // Buscar la reserva completa desde el repositorio
            var reservaCompleta = _reservaController.ConsultarReservas(null, null).FirstOrDefault(r => r.IdReserva == idReserva);

            if (reservaCompleta != null)
            {
                // Cargar datos comunes
                cmbLaboratorio.SelectedValue = reservaCompleta.LaboratorioAsignado.NumeroAsignado;
                txtCarrera.Text = reservaCompleta.Carrera;
                txtAsignatura.Text = reservaCompleta.Asignatura;
                txtAnio.Text = reservaCompleta.Anio.ToString();
                txtComision.Text = reservaCompleta.Comision;
                txtProfesor.Text = reservaCompleta.Profesor;

                // Cargar datos específicos del tipo
                if (reservaCompleta is ReservaCuatrimestral rc)
                {
                    cmbTipoReserva.SelectedItem = "Cuatrimestral";
                    dtpCuatriComienzo.Value = rc.FechaHoraComienzo;
                    dtpCuatriFin.Value = rc.FechaHoraFinalizacion;
                    cmbFrecuencia.SelectedItem = rc.Frecuencia;
                }
                else if (reservaCompleta is ReservaEventual re)
                {
                    cmbTipoReserva.SelectedItem = "Eventual";
                    dtpEventualComienzo.Value = re.FechaComienzoReserva;
                    numSemanas.Value = re.CantidadSemanas;
                }
            }
        }
    }
}
