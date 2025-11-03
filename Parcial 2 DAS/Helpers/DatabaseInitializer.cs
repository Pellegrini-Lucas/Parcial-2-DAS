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

            // 1. Asegurarse de que la base de datos exista
            connectionStringBuilder.InitialCatalog = "master"; // Conectarse a master para verificar/crear
            string masterConnectionString = connectionStringBuilder.ToString();

            using (var masterConnection = new SqlConnection(masterConnectionString))
            {
                masterConnection.Open();
                using (var command = masterConnection.CreateCommand())
                {
                    command.CommandText = $"SELECT db_id('{dbName}')";
                    bool dbExists = (command.ExecuteScalar() != DBNull.Value);

                    if (!dbExists)
                    {
                        command.CommandText = $"CREATE DATABASE [{dbName}]";
                        command.ExecuteNonQuery();
                    }
                }
            }

            // 2. Asegurarse de que las tablas existan dentro de la base de datos
            using (var dbConnection = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                dbConnection.Open();
                bool tablesExist;
                using (var command = dbConnection.CreateCommand())
                {
                    // La forma más robusta de verificar si una tabla específica existe
                    command.CommandText = "IF OBJECT_ID(N'dbo.Laboratorios', N'U') IS NOT NULL SELECT 1 ELSE SELECT 0";
                    tablesExist = (int)command.ExecuteScalar() == 1;
                }

                // Si las tablas no existen, ejecutar el script de creación
                if (!tablesExist)
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceName = "Parcial_2_DAS.schema.sql";

                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    {
                        if (stream == null)
                        {
                            throw new FileNotFoundException($"Error crítico: No se pudo encontrar el script de inicialización '{resourceName}'. " +
                                                            "Asegúrese de que el archivo 'schema.sql' esté presente y marcado como 'Recurso incrustado'.", resourceName);
                        }

                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string sqlScript = reader.ReadToEnd();
                            var batches = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                            foreach (var batch in batches)
                            {
                                if (!string.IsNullOrWhiteSpace(batch))
                                {
                                    using (var scriptCommand = dbConnection.CreateCommand())
                                    {
                                        scriptCommand.CommandText = batch;
                                        try
                                        {
                                            scriptCommand.ExecuteNonQuery();
                                        }
                                        catch (SqlException ex)
                                        {
                                            throw new Exception($"Error ejecutando el lote de comandos SQL:\n---\n{batch}\n---\nError: {ex.Message}", ex);
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
