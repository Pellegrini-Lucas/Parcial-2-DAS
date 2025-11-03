using System;
using System.Windows.Forms;
using Parcial_2_DAS.Views;

namespace Parcial_2_DAS
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionReservas_Click(object sender, EventArgs e)
        {
            // Aquí se instanciarían los repositorios y controladores.
            // Por simplicidad en este ejemplo, se crearán directamente.
            var laboratorioRepo = new SistemaReservas.Repositories.LaboratorioRepositorio();
            var reservaRepo = new SistemaReservas.Repositories.ReservaRepositorio(laboratorioRepo);
            var formGestionReservas = new frmGestionReservas(reservaRepo, laboratorioRepo);
            formGestionReservas.ShowDialog();
        }

        private void btnGestionLaboratorios_Click(object sender, EventArgs e)
        {
            var laboratorioRepo = new SistemaReservas.Repositories.LaboratorioRepositorio();
            var reservaRepo = new SistemaReservas.Repositories.ReservaRepositorio(laboratorioRepo);
            var formGestionLabs = new frmGestionLaboratorios(laboratorioRepo, reservaRepo);
            formGestionLabs.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var formReportes = new frmReportes();
            formReportes.ShowDialog();
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            var formIntegrantes = new frmIntegrantes();
            formIntegrantes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
