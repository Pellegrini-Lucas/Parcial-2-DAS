using System;

namespace SistemaReservas.Models
{
    /// <summary>
    /// Representa una reserva para un evento específico que dura una
    /// cantidad determinada de semanas.
    /// </summary>
    public class ReservaEventual : Reserva
    {
        public DateTime FechaComienzoReserva { get; set; }
        public int CantidadSemanas { get; set; }

        /// <summary>
        /// Valida que el horario de la reserva cumpla con las políticas de la institución.
        /// Para una reserva eventual, se asume que la duración es de 2 horas desde el inicio.
        /// Esta es una suposición razonable ya que no hay una fecha de fin explícita.
        /// </summary>
        public override void ValidarHorario()
        {
            // Como no tenemos una hora de fin, asumimos una duración estándar (ej. 2 horas)
            // para validar el horario. Esta lógica podría ajustarse si el negocio lo requiere.
            DateTime fechaFinEstimada = FechaComienzoReserva.AddHours(2);
            base.VerificarHorario(FechaComienzoReserva, fechaFinEstimada);
        }
    }
}
