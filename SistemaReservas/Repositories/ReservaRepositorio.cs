using SistemaReservas.Helpers;
using SistemaReservas.Interfaces;
using SistemaReservas.Models;
using SistemaReservas.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SistemaReservas.Repositories
{
    public class ReservaRepositorio : IReservaRepositorio
    {
        private readonly string _connectionString;
        private readonly ILaboratorioRepositorio _laboratorioRepositorio;

        // Inyectamos el repositorio de laboratorios para poder componer el objeto Reserva completo.
        public ReservaRepositorio(ILaboratorioRepositorio laboratorioRepositorio)
        {
            _connectionString = DatabaseHelper.GetConnectionString();
            _laboratorioRepositorio = laboratorioRepositorio;
        }

        public void Add(Reserva reserva)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command;

                string insertClause = @"INSERT INTO Reservas (NumeroLaboratorio, Carrera, Asignatura, Anio, Comision, Profesor, TipoReserva,
                                          FechaHoraComienzo, FechaHoraFinalizacion, Frecuencia,
                                          FechaComienzoEventual, CantidadSemanas)
                                   VALUES (@NumLab, @Carrera, @Asignatura, @Anio, @Comision, @Profesor, @Tipo,
                                          @FHC, @FHF, @Frec, @FCE, @CantSem)";

                command = new SqlCommand(insertClause, connection);

                // Parámetros comunes
                command.Parameters.AddWithValue("@NumLab", reserva.LaboratorioAsignado.NumeroAsignado);
                command.Parameters.AddWithValue("@Carrera", reserva.Carrera);
                command.Parameters.AddWithValue("@Asignatura", reserva.Asignatura);
                command.Parameters.AddWithValue("@Anio", reserva.Anio);
                command.Parameters.AddWithValue("@Comision", reserva.Comision);
                command.Parameters.AddWithValue("@Profesor", reserva.Profesor);

                if (reserva is ReservaCuatrimestral r_cuatri)
                {
                    command.Parameters.AddWithValue("@Tipo", "Cuatrimestral");
                    command.Parameters.AddWithValue("@FHC", r_cuatri.FechaHoraComienzo);
                    command.Parameters.AddWithValue("@FHF", r_cuatri.FechaHoraFinalizacion);
                    command.Parameters.AddWithValue("@Frec", r_cuatri.Frecuencia.ToString());
                    command.Parameters.AddWithValue("@FCE", DBNull.Value);
                    command.Parameters.AddWithValue("@CantSem", DBNull.Value);
                }
                else if (reserva is ReservaEventual r_eventual)
                {
                    command.Parameters.AddWithValue("@Tipo", "Eventual");
                    command.Parameters.AddWithValue("@FHC", DBNull.Value);
                    command.Parameters.AddWithValue("@FHF", DBNull.Value);
                    command.Parameters.AddWithValue("@Frec", DBNull.Value);
                    command.Parameters.AddWithValue("@FCE", r_eventual.FechaComienzoReserva);
                    command.Parameters.AddWithValue("@CantSem", r_eventual.CantidadSemanas);
                }
                else
                {
                    throw new ArgumentException("El tipo de reserva no es soportado.");
                }

                command.ExecuteNonQuery();
            }
        }

        public void Update(Reserva reserva)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string updateClause = @"UPDATE Reservas SET
                                          NumeroLaboratorio = @NumLab, Carrera = @Carrera, Asignatura = @Asignatura,
                                          Anio = @Anio, Comision = @Comision, Profesor = @Profesor, TipoReserva = @Tipo,
                                          FechaHoraComienzo = @FHC, FechaHoraFinalizacion = @FHF, Frecuencia = @Frec,
                                          FechaComienzoEventual = @FCE, CantidadSemanas = @CantSem
                                      WHERE IdReserva = @IdReserva";

                var command = new SqlCommand(updateClause, connection);

                // Parámetros comunes
                command.Parameters.AddWithValue("@IdReserva", reserva.IdReserva);
                command.Parameters.AddWithValue("@NumLab", reserva.LaboratorioAsignado.NumeroAsignado);
                command.Parameters.AddWithValue("@Carrera", reserva.Carrera);
                command.Parameters.AddWithValue("@Asignatura", reserva.Asignatura);
                command.Parameters.AddWithValue("@Anio", reserva.Anio);
                command.Parameters.AddWithValue("@Comision", reserva.Comision);
                command.Parameters.AddWithValue("@Profesor", reserva.Profesor);

                if (reserva is ReservaCuatrimestral r_cuatri)
                {
                    command.Parameters.AddWithValue("@Tipo", "Cuatrimestral");
                    command.Parameters.AddWithValue("@FHC", r_cuatri.FechaHoraComienzo);
                    command.Parameters.AddWithValue("@FHF", r_cuatri.FechaHoraFinalizacion);
                    command.Parameters.AddWithValue("@Frec", r_cuatri.Frecuencia.ToString());
                    command.Parameters.AddWithValue("@FCE", DBNull.Value);
                    command.Parameters.AddWithValue("@CantSem", DBNull.Value);
                }
                else if (reserva is ReservaEventual r_eventual)
                {
                    command.Parameters.AddWithValue("@Tipo", "Eventual");
                    command.Parameters.AddWithValue("@FHC", DBNull.Value);
                    command.Parameters.AddWithValue("@FHF", DBNull.Value);
                    command.Parameters.AddWithValue("@Frec", DBNull.Value);
                    command.Parameters.AddWithValue("@FCE", r_eventual.FechaComienzoReserva);
                    command.Parameters.AddWithValue("@CantSem", r_eventual.CantidadSemanas);
                }
                else
                {
                    throw new ArgumentException("El tipo de reserva no es soportado.");
                }

                command.ExecuteNonQuery();
            }
        }


        public void Delete(int idReserva)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Reservas WHERE IdReserva = @Id", connection);
                command.Parameters.AddWithValue("@Id", idReserva);
                command.ExecuteNonQuery();
            }
        }

        public Reserva GetById(int idReserva)
        {
            return ExecuteQuery("SELECT * FROM Reservas WHERE IdReserva = @Id", new SqlParameter("@Id", idReserva))[0];
        }

        public List<Reserva> GetAll()
        {
            return ExecuteQuery("SELECT * FROM Reservas");
        }

        public List<Reserva> GetByLaboratorioId(int numeroLaboratorio)
        {
            return ExecuteQuery("SELECT * FROM Reservas WHERE NumeroLaboratorio = @NumLab", new SqlParameter("@NumLab", numeroLaboratorio));
        }

        public List<Reserva> GetByProfesor(string profesor)
        {
            // Usamos LIKE para búsquedas parciales
            return ExecuteQuery("SELECT * FROM Reservas WHERE Profesor LIKE @Prof", new SqlParameter("@Prof", $"%{profesor}%"));
        }

        public List<Reserva> GetByAsignatura(string asignatura)
        {
            return ExecuteQuery("SELECT * FROM Reservas WHERE Asignatura LIKE @Asig", new SqlParameter("@Asig", $"%{asignatura}%"));
        }

        public List<Reserva> GetByFecha(DateTime fecha)
        {
            // Esta consulta busca reservas que estén activas en un día específico.
            string query = @"SELECT * FROM Reservas WHERE
                             (TipoReserva = 'Cuatrimestral' AND @Fecha >= CAST(FechaHoraComienzo AS DATE) AND @Fecha <= CAST(FechaHoraFinalizacion AS DATE))
                             OR
                             (TipoReserva = 'Eventual' AND @Fecha >= CAST(FechaComienzoEventual AS DATE) AND @Fecha <= CAST(DATEADD(week, CantidadSemanas, FechaComienzoEventual) AS DATE))";

            return ExecuteQuery(query, new SqlParameter("@Fecha", fecha.Date));
        }

        /// <summary>
        /// Método privado de ayuda para ejecutar consultas y mapear los resultados a una lista de Reservas.
        /// </summary>
        private List<Reserva> ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            var reservas = new List<Reserva>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservas.Add(MapReaderToReserva(reader));
                    }
                }
            }
            return reservas;
        }

        /// <summary>
        /// Mapea una fila de un SqlDataReader a un objeto Reserva (Cuatrimestral o Eventual).
        /// </summary>
        private Reserva MapReaderToReserva(SqlDataReader reader)
        {
            string tipoReserva = (string)reader["TipoReserva"];
            Reserva reserva;

            if (tipoReserva == "Cuatrimestral")
            {
                reserva = new ReservaCuatrimestral
                {
                    FechaHoraComienzo = (DateTime)reader["FechaHoraComienzo"],
                    FechaHoraFinalizacion = (DateTime)reader["FechaHoraFinalizacion"],
                    Frecuencia = (FrecuenciaReserva)Enum.Parse(typeof(FrecuenciaReserva), (string)reader["Frecuencia"])
                };
            }
            else if (tipoReserva == "Eventual")
            {
                reserva = new ReservaEventual
                {
                    FechaComienzoReserva = (DateTime)reader["FechaComienzoEventual"],
                    CantidadSemanas = (int)reader["CantidadSemanas"]
                };
            }
            else
            {
                throw new DataException("Tipo de reserva desconocido en la base de datos.");
            }

            // Mapeo de propiedades comunes
            reserva.IdReserva = (int)reader["IdReserva"];
            reserva.Carrera = (string)reader["Carrera"];
            reserva.Asignatura = (string)reader["Asignatura"];
            reserva.Anio = (int)reader["Anio"];
            reserva.Comision = (string)reader["Comision"];
            reserva.Profesor = (string)reader["Profesor"];

            // Componer el objeto Laboratorio
            int numeroLaboratorio = (int)reader["NumeroLaboratorio"];
            reserva.LaboratorioAsignado = _laboratorioRepositorio.GetByNumero(numeroLaboratorio);

            return reserva;
        }
    }
}
