using System;
using SistemaReservas.Enums;

namespace SistemaReservas.Models
{
    /// <summary>
    /// Representa una reserva que se repite de forma semanal o quincenal
    /// durante un período cuatrimestral.
    /// </summary>
    public class ReservaCuatrimestral : Reserva
    {
        public DateTime FechaHoraComienzo { get; set; }
        public DateTime FechaHoraFinalizacion { get; set; }
        public FrecuenciaReserva Frecuencia { get; set; }

        /// <summary>
        /// Valida que el horario de la reserva (inferido de las fechas de inicio y fin)
        /// cumpla con las políticas de la institución.
        /// </summary>
        public override void ValidarHorario()
        {
            // La lógica de validación se basa en el día de la semana y la hora del día,
            // que son los mismos para cada ocurrencia de la reserva.
            // Se utiliza el método de ayuda de la clase base.
            base.VerificarHorario(FechaHoraComienzo, FechaHoraFinalizacion);
        }
    }
}
