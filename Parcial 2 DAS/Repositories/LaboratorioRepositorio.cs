using SistemaReservas.Helpers;
using SistemaReservas.Interfaces;
using SistemaReservas.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace SistemaReservas.Repositories
{
    public class LaboratorioRepositorio : ILaboratorioRepositorio
    {
        private readonly string _connectionString;

        public LaboratorioRepositorio()
        {
            _connectionString = DatabaseHelper.GetConnectionString();
        }

        public void Add(Laboratorio lab)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Laboratorios (NumeroAsignado, UbicacionPiso, CapacidadPuestos) VALUES (@Numero, @Piso, @Capacidad)", connection);
                command.Parameters.AddWithValue("@Numero", lab.NumeroAsignado);
                command.Parameters.AddWithValue("@Piso", lab.UbicacionPiso);
                command.Parameters.AddWithValue("@Capacidad", lab.CapacidadPuestos);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Laboratorio lab)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Laboratorios SET UbicacionPiso = @Piso, CapacidadPuestos = @Capacidad WHERE NumeroAsignado = @Numero", connection);
                command.Parameters.AddWithValue("@Piso", lab.UbicacionPiso);
                command.Parameters.AddWithValue("@Capacidad", lab.CapacidadPuestos);
                command.Parameters.AddWithValue("@Numero", lab.NumeroAsignado);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int numeroAsignado)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Laboratorios WHERE NumeroAsignado = @Numero", connection);
                command.Parameters.AddWithValue("@Numero", numeroAsignado);
                command.ExecuteNonQuery();
            }
        }

        public Laboratorio GetByNumero(int numeroAsignado)
        {
            Laboratorio lab = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Laboratorios WHERE NumeroAsignado = @Numero", connection);
                command.Parameters.AddWithValue("@Numero", numeroAsignado);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lab = new Laboratorio
                        {
                            NumeroAsignado = (int)reader["NumeroAsignado"],
                            UbicacionPiso = (string)reader["UbicacionPiso"],
                            CapacidadPuestos = (int)reader["CapacidadPuestos"]
                        };
                    }
                }
            }
            return lab;
        }

        public List<Laboratorio> GetAll()
        {
            var laboratorios = new List<Laboratorio>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Laboratorios", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        laboratorios.Add(new Laboratorio
                        {
                            NumeroAsignado = (int)reader["NumeroAsignado"],
                            UbicacionPiso = (string)reader["UbicacionPiso"],
                            CapacidadPuestos = (int)reader["CapacidadPuestos"]
                        });
                    }
                }
            }
            return laboratorios;
        }
    }
}
