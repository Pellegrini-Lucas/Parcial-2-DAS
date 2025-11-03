using System;

namespace SistemaReservas.Models
{
    /// <summary>
    /// Clase abstracta que representa una reserva de laboratorio.
    /// Contiene las propiedades y la lógica comunes a todos los tipos de reserva.
    /// </summary>
    public abstract class Reserva
    {
        public int IdReserva { get; set; }
        public Laboratorio LaboratorioAsignado { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
        public int Anio { get; set; }
        public string Comision { get; set; }
        public string Profesor { get; set; }

        /// <summary>
        /// Método abstracto que cada tipo de reserva debe implementar para validar
        /// si su horario específico cumple con las reglas de la institución.
        /// </summary>
        public abstract void ValidarHorario();

        /// <summary>
        /// Método de ayuda protegido para ser utilizado por las clases hijas.
        /// Verifica que un intervalo de tiempo (inicio y fin) sea válido.
        /// Lanza una excepción si el horario no es permitido.
        /// </summary>
        /// <param name="inicio">La fecha y hora de inicio de la clase.</param>
        /// <param name="fin">La fecha y hora de fin de la clase.</param>
        protected void VerificarHorario(DateTime inicio, DateTime fin)
        {
            TimeSpan horaInicio = inicio.TimeOfDay;
            TimeSpan horaFin = fin.TimeOfDay;
            DayOfWeek dia = inicio.DayOfWeek;

            bool esHorarioValido = false;

            if (dia >= DayOfWeek.Monday && dia <= DayOfWeek.Friday)
            {
                // Lunes a Viernes: 7:00 a 23:00
                if (horaInicio >= new TimeSpan(7, 0, 0) && horaFin <= new TimeSpan(23, 0, 0))
                {
                    esHorarioValido = true;
                }
            }
            else if (dia == DayOfWeek.Saturday)
            {
                // Sábados: 08:00 a 12:00
                if (horaInicio >= new TimeSpan(8, 0, 0) && horaFin <= new TimeSpan(12, 0, 0))
                {
                    esHorarioValido = true;
                }
            }

            if (!esHorarioValido)
            {
                throw new InvalidOperationException($"El horario de {horaInicio} a {horaFin} el día {dia} no está dentro del rango permitido.");
            }
        }
    }
}
