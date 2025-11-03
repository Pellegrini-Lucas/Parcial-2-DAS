using System;
using System.Windows.Forms;
using Parcial_2_DAS.Views;

namespace Parcial_2_DAS
{
    public partial class frmMenuPrincipal : Form
    {
        // Instancias únicas de los repositorios para toda la aplicación.
        private readonly SistemaReservas.Interfaces.ILaboratorioRepositorio _laboratorioRepo;
        private readonly SistemaReservas.Interfaces.IReservaRepositorio _reservaRepo;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            // Inyección de dependencias manual: se crean los repositorios una sola vez.
            _laboratorioRepo = new SistemaReservas.Repositories.LaboratorioRepositorio();
            _reservaRepo = new SistemaReservas.Repositories.ReservaRepositorio(_laboratorioRepo);
        }

        private void btnGestionReservas_Click(object sender, EventArgs e)
        {
            // Se pasan las instancias existentes a los formularios.
            var formGestionReservas = new frmGestionReservas(_reservaRepo, _laboratorioRepo);
            formGestionReservas.ShowDialog();
        }

        private void btnGestionLaboratorios_Click(object sender, EventArgs e)
        {
            // Se pasan las instancias existentes a los formularios.
            var formGestionLabs = new frmGestionLaboratorios(_laboratorioRepo, _reservaRepo);
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
