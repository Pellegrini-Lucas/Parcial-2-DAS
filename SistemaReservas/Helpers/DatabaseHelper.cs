using System.Configuration;

namespace SistemaReservas.Helpers
{
    /// <summary>
    /// Proporciona acceso a la configuración de la base de datos.
    /// </summary>
    public static class DatabaseHelper
    {
        /// <summary>
        /// Obtiene la cadena de conexión desde el archivo App.config.
        /// </summary>
        /// <returns>La cadena de conexión a la base de datos.</returns>
        public static string GetConnectionString()
        {
            // Se necesita una referencia al ensamblado System.Configuration en el proyecto.
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"];

            if (connectionString == null)
            {
                throw new ConfigurationErrorsException("No se encontró la cadena de conexión 'DefaultConnection' en el archivo App.config.");
            }

            return connectionString.ConnectionString;
        }
    }
}
