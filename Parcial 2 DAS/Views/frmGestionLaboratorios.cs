using SistemaReservas.Controllers;
using SistemaReservas.Interfaces;
using SistemaReservas.Models;
using System;
using System.Windows.Forms;

namespace Parcial_2_DAS.Views
{
    public partial class frmGestionLaboratorios : Form
    {
        private readonly LaboratorioController _controller;

        public frmGestionLaboratorios(ILaboratorioRepositorio laboratorioRepo, IReservaRepositorio reservaRepo)
        {
            InitializeComponent();
            _controller = new LaboratorioController(laboratorioRepo, reservaRepo);
            CargarLaboratorios();
        }

        private void CargarLaboratorios()
        {
            try
            {
                dgvLaboratorios.DataSource = null; // Limpiar para refrescar
                dgvLaboratorios.DataSource = _controller.CargarLaboratorios();
                dgvLaboratorios.Columns["NumeroAsignado"].HeaderText = "Número";
                dgvLaboratorios.Columns["UbicacionPiso"].HeaderText = "Piso";
                dgvLaboratorios.Columns["CapacidadPuestos"].HeaderText = "Capacidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AltaLaboratorio(txtNumero.Text, txtPiso.Text, txtCapacidad.Text);
                CargarLaboratorios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.CurrentRow == null) return;

            try
            {
                int numeroOriginal = (int)dgvLaboratorios.CurrentRow.Cells["NumeroAsignado"].Value;
                _controller.ModificarLaboratorio(numeroOriginal, txtPiso.Text, txtCapacidad.Text);
                CargarLaboratorios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.CurrentRow == null) return;

            int numeroAsignado = (int)dgvLaboratorios.CurrentRow.Cells["NumeroAsignado"].Value;

            try
            {
                string advertencia = _controller.ObtenerAdvertenciaBaja(numeroAsignado);

                DialogResult confirmacion;
                if (advertencia != null)
                {
                    confirmacion = MessageBox.Show(advertencia, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar el laboratorio {numeroAsignado}?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (confirmacion == DialogResult.Yes)
                {
                    _controller.BajaLaboratorio(numeroAsignado);
                    CargarLaboratorios();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error en la Baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLaboratorios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLaboratorios.CurrentRow != null)
            {
                var lab = (Laboratorio)dgvLaboratorios.CurrentRow.DataBoundItem;
                txtNumero.Text = lab.NumeroAsignado.ToString();
                txtPiso.Text = lab.UbicacionPiso;
                txtCapacidad.Text = lab.CapacidadPuestos.ToString();
                txtNumero.Enabled = false; // El número no se puede cambiar
            }
        }

        private void LimpiarCampos()
        {
            txtNumero.Clear();
            txtPiso.Clear();
            txtCapacidad.Clear();
            txtNumero.Enabled = true;
            dgvLaboratorios.ClearSelection();
        }
    }
}
