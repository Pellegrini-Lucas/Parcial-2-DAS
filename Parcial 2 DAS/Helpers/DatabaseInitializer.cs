using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SistemaReservas.Helpers
{
    public static class DatabaseInitializer
    {
        public static void EnsureDatabaseExists()
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder(DatabaseHelper.GetConnectionString());
            string dbName = connectionStringBuilder.InitialCatalog;
            string masterConnectionString = $"Data Source={connectionStringBuilder.DataSource};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

            using (var connection = new SqlConnection(masterConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT db_id('{dbName}')";
                    var result = command.ExecuteScalar();

                    // Si la base de datos no existe (resultado es NULL), la creamos.
                    if (result == DBNull.Value)
                    {
                        // 1. Crear la base de datos vacía
                        command.CommandText = $"CREATE DATABASE [{dbName}]";
                        command.ExecuteNonQuery();

                        // Darle un momento al servidor para que la base de datos esté disponible
                        System.Threading.Thread.Sleep(2000);

                        // 2. Conectarse a la nueva base de datos y ejecutar el script para crear las tablas
                        using (var dbConnection = new SqlConnection(DatabaseHelper.GetConnectionString()))
                        {
                            dbConnection.Open();

                            // Leer el script SQL desde los recursos embebidos del proyecto
                            var assembly = Assembly.GetExecutingAssembly();
                            var resourceName = "Parcial_2_DAS.schema.sql"; // Namespace.FileName

                            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string sqlScript = reader.ReadToEnd();
                                // El script usa 'GO' que no es T-SQL estándar. Lo dividimos en lotes.
                                var batches = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                                foreach (var batch in batches)
                                {
                                    if (!string.IsNullOrWhiteSpace(batch))
                                    {
                                        using (var scriptCommand = dbConnection.CreateCommand())
                                        {
                                            scriptCommand.CommandText = batch;
                                            scriptCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
