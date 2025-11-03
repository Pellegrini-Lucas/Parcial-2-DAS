using SistemaReservas.Models;
using System;
using System.Collections.Generic;

namespace SistemaReservas.Interfaces
{
    /// <summary>
    /// Define el contrato para el repositorio de reservas.
    /// </summary>
    public interface IReservaRepositorio
    {
        void Add(Reserva reserva);
        void Update(Reserva reserva);
        void Delete(int idReserva);
        Reserva GetById(int idReserva);
        List<Reserva> GetAll();
        List<Reserva> GetByFecha(DateTime fecha);
        List<Reserva> GetByProfesor(string profesor);
        List<Reserva> GetByAsignatura(string asignatura);
        List<Reserva> GetByLaboratorioId(int numeroLaboratorio);
    }
}
