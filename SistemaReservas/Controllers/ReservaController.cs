using SistemaReservas.Interfaces;
using SistemaReservas.Models;
using SistemaReservas.Enums;
using System;
using System.Collections.Generic;

namespace SistemaReservas.Controllers
{
    public class ReservaController
    {
        private readonly IReservaRepositorio _reservaRepositorio;
        private readonly ILaboratorioRepositorio _laboratorioRepositorio;

        public ReservaController(IReservaRepositorio reservaRepositorio, ILaboratorioRepositorio laboratorioRepositorio)
        {
            _reservaRepositorio = reservaRepositorio;
            _laboratorioRepositorio = laboratorioRepositorio;
        }

        public void AltaReserva(
            // Parámetros comunes
            int laboratorioId, string carrera, string asignatura, string anioStr, string comision, string profesor,
            // Parámetros de tipo de reserva
            string tipoReserva,
            // Parámetros Cuatrimestral
            DateTime fechaHoraComienzo, DateTime fechaHoraFinalizacion, FrecuenciaReserva frecuencia,
            // Parámetros Eventual
            DateTime fechaComienzoEventual, int cantidadSemanas)
        {
            // 1. Validación de datos comunes
            if (string.IsNullOrWhiteSpace(carrera) || string.IsNullOrWhiteSpace(asignatura) ||
                string.IsNullOrWhiteSpace(anioStr) || string.IsNullOrWhiteSpace(comision) || string.IsNullOrWhiteSpace(profesor))
            {
                throw new ArgumentException("Todos los campos de la reserva son obligatorios.");
            }

            if (!int.TryParse(anioStr, out int anio) || anio < 1900 || anio > DateTime.Now.Year + 5)
            {
                throw new FormatException("El año debe ser un número válido.");
            }

            var laboratorio = _laboratorioRepositorio.GetByNumero(laboratorioId);
            if (laboratorio == null)
            {
                throw new InvalidOperationException("El laboratorio seleccionado no existe.");
            }

            // 2. Factoría para crear el objeto de reserva específico
            Reserva nuevaReserva;

            if (tipoReserva == "Cuatrimestral")
            {
                if (fechaHoraFinalizacion <= fechaHoraComienzo)
                {
                    throw new ArgumentException("La fecha de finalización debe ser posterior a la de comienzo.");
                }
                nuevaReserva = new ReservaCuatrimestral
                {
                    FechaHoraComienzo = fechaHoraComienzo,
                    FechaHoraFinalizacion = fechaHoraFinalizacion,
                    Frecuencia = frecuencia
                };
            }
            else if (tipoReserva == "Eventual")
            {
                if (cantidadSemanas <= 0)
                {
                    throw new ArgumentException("La cantidad de semanas debe ser mayor a cero.");
                }
                nuevaReserva = new ReservaEventual
                {
                    FechaComienzoReserva = fechaComienzoEventual,
                    CantidadSemanas = cantidadSemanas
                };
            }
            else
            {
                throw new ArgumentException("Tipo de reserva no válido.");
            }

            // 3. Llenar propiedades comunes
            nuevaReserva.LaboratorioAsignado = laboratorio;
            nuevaReserva.Carrera = carrera;
            nuevaReserva.Asignatura = asignatura;
            nuevaReserva.Anio = anio;
            nuevaReserva.Comision = comision;
            nuevaReserva.Profesor = profesor;

            // 4. Validación de reglas de negocio (horario)
            nuevaReserva.ValidarHorario();

            // 5. Persistencia
            _reservaRepositorio.Add(nuevaReserva);
        }

        public void ModificarReserva(
            int idReserva,
            // Parámetros comunes
            int laboratorioId, string carrera, string asignatura, string anioStr, string comision, string profesor,
            // Parámetros de tipo de reserva
            string tipoReserva,
            // Parámetros Cuatrimestral
            DateTime fechaHoraComienzo, DateTime fechaHoraFinalizacion, FrecuenciaReserva frecuencia,
            // Parámetros Eventual
            DateTime fechaComienzoEventual, int cantidadSemanas)
        {
            // Validaciones (similares a Alta)
            if (string.IsNullOrWhiteSpace(carrera) || string.IsNullOrWhiteSpace(asignatura) ||
                string.IsNullOrWhiteSpace(anioStr) || string.IsNullOrWhiteSpace(comision) || string.IsNullOrWhiteSpace(profesor))
            {
                throw new ArgumentException("Todos los campos de la reserva son obligatorios.");
            }
            if (!int.TryParse(anioStr, out int anio) || anio < 1900 || anio > DateTime.Now.Year + 5)
            {
                throw new FormatException("El año debe ser un número válido.");
            }
            var laboratorio = _laboratorioRepositorio.GetByNumero(laboratorioId);
            if (laboratorio == null)
            {
                throw new InvalidOperationException("El laboratorio seleccionado no existe.");
            }

            // Factoría para crear el objeto
            Reserva reservaActualizada;
             if (tipoReserva == "Cuatrimestral")
            {
                reservaActualizada = new ReservaCuatrimestral
                {
                    FechaHoraComienzo = fechaHoraComienzo,
                    FechaHoraFinalizacion = fechaHoraFinalizacion,
                    Frecuencia = frecuencia
                };
            }
            else
            {
                reservaActualizada = new ReservaEventual
                {
                    FechaComienzoReserva = fechaComienzoEventual,
                    CantidadSemanas = cantidadSemanas
                };
            }

            // Llenar propiedades comunes
            reservaActualizada.IdReserva = idReserva; // Clave para el UPDATE
            reservaActualizada.LaboratorioAsignado = laboratorio;
            reservaActualizada.Carrera = carrera;
            reservaActualizada.Asignatura = asignatura;
            reservaActualizada.Anio = anio;
            reservaActualizada.Comision = comision;
            reservaActualizada.Profesor = profesor;

            // Validación de reglas de negocio
            reservaActualizada.ValidarHorario();

            // Persistencia
            _reservaRepositorio.Update(reservaActualizada);
        }

        public void BajaReserva(int idReserva)
        {
            _reservaRepositorio.Delete(idReserva);
        }

        public List<Reserva> ConsultarReservas(string tipoFiltro, object valorFiltro)
        {
            if (valorFiltro == null)
                return _reservaRepositorio.GetAll();

            switch (tipoFiltro)
            {
                case "Fecha":
                    return _reservaRepositorio.GetByFecha((DateTime)valorFiltro);
                case "Profesor":
                    return _reservaRepositorio.GetByProfesor((string)valorFiltro);
                case "Asignatura":
                    return _reservaRepositorio.GetByAsignatura((string)valorFiltro);
                default:
                    // Si el filtro no es válido o no se proporciona valor, devolver todo.
                    return _reservaRepositorio.GetAll();
            }
        }
    }
}
