namespace Parcial_2_DAS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Asegurarse de que la base de datos y las tablas existan antes de iniciar la app.
                SistemaReservas.Helpers.DatabaseInitializer.EnsureDatabaseExists();

                ApplicationConfiguration.Initialize();
                Application.Run(new frmMenuPrincipal());
            }
            catch (Exception ex)
            {
                // Si algo falla catastróficamente durante la inicialización, mostrar el error.
                MessageBox.Show($"Error fatal al iniciar la aplicación: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}