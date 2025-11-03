using SistemaReservas.Interfaces;
using SistemaReservas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaReservas.Controllers
{
    public class LaboratorioController
    {
        private readonly ILaboratorioRepositorio _laboratorioRepositorio;
        private readonly IReservaRepositorio _reservaRepositorio;

        public LaboratorioController(ILaboratorioRepositorio laboratorioRepositorio, IReservaRepositorio reservaRepositorio)
        {
            _laboratorioRepositorio = laboratorioRepositorio;
            _reservaRepositorio = reservaRepositorio;
        }

        public List<Laboratorio> CargarLaboratorios()
        {
            return _laboratorioRepositorio.GetAll();
        }

        public void AltaLaboratorio(string num, string piso, string cap)
        {
            // 1. Validación de entradas
            if (string.IsNullOrWhiteSpace(num) || string.IsNullOrWhiteSpace(piso) || string.IsNullOrWhiteSpace(cap))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }

            int numeroAsignado;
            int capacidad;

            try
            {
                numeroAsignado = int.Parse(num);
                capacidad = int.Parse(cap);
            }
            catch (FormatException)
            {
                throw new FormatException("El número de laboratorio y la capacidad deben ser números enteros válidos.");
            }

            if (numeroAsignado <= 0 || capacidad <= 0)
            {
                throw new ArgumentException("El número de laboratorio y la capacidad deben ser valores positivos.");
            }

            if (_laboratorioRepositorio.GetByNumero(numeroAsignado) != null)
            {
                throw new InvalidOperationException($"Ya existe un laboratorio con el número {numeroAsignado}.");
            }

            // 2. Creación del objeto
            var laboratorio = new Laboratorio
            {
                NumeroAsignado = numeroAsignado,
                UbicacionPiso = piso,
                CapacidadPuestos = capacidad
            };

            // 3. Llamada al repositorio
            _laboratorioRepositorio.Add(laboratorio);
        }

        public void ModificarLaboratorio(int numeroOriginal, string piso, string cap)
        {
            // Validación similar a Alta, pero para los campos modificables.
            if (string.IsNullOrWhiteSpace(piso) || string.IsNullOrWhiteSpace(cap))
            {
                throw new ArgumentException("Los campos de piso y capacidad no pueden estar vacíos.");
            }

            int capacidad;
            try
            {
                capacidad = int.Parse(cap);
            }
            catch (FormatException)
            {
                throw new FormatException("La capacidad debe ser un número entero válido.");
            }

            if (capacidad <= 0)
            {
                throw new ArgumentException("La capacidad debe ser un valor positivo.");
            }

            var laboratorio = _laboratorioRepositorio.GetByNumero(numeroOriginal);
            if (laboratorio == null)
            {
                throw new InvalidOperationException("No se encontró el laboratorio a modificar.");
            }

            laboratorio.UbicacionPiso = piso;
            laboratorio.CapacidadPuestos = capacidad;

            _laboratorioRepositorio.Update(laboratorio);
        }

        /// <summary>
        /// Comprueba si un laboratorio tiene reservas asociadas y devuelve un mensaje de advertencia si es así.
        /// </summary>
        /// <returns>Un string con el mensaje de advertencia, o null si no hay reservas.</returns>
        public string ObtenerAdvertenciaBaja(int numeroAsignado)
        {
            var reservasAsociadas = _reservaRepositorio.GetByLaboratorioId(numeroAsignado);

            if (reservasAsociadas.Count > 0)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Este laboratorio tiene reservas asociadas y no puede ser eliminado sin cancelarlas primero.");
                sb.AppendLine("Reservas afectadas:");
                foreach (var reserva in reservasAsociadas)
                {
                    sb.AppendLine($"- ID: {reserva.IdReserva}, Asignatura: {reserva.Asignatura}, Profesor: {reserva.Profesor}");
                }
                return sb.ToString();
            }
            return null;
        }


        /// <summary>
        /// Procede con la baja definitiva del laboratorio.
        /// Este método debe ser llamado DESPUÉS de que el usuario haya confirmado la acción en la vista.
        /// </summary>
        public void BajaLaboratorio(int numeroAsignado)
        {
             // La lógica de confirmación (MessageBox) estará en la Vista.
             // El controlador asume que la decisión ya fue tomada.
            _laboratorioRepositorio.Delete(numeroAsignado);
        }
    }
}
