using SistemaReservas.Models;
using System.Collections.Generic;

namespace SistemaReservas.Interfaces
{
    /// <summary>
    /// Define el contrato para el repositorio de laboratorios.
    /// </summary>
    public interface ILaboratorioRepositorio
    {
        void Add(Laboratorio lab);
        void Update(Laboratorio lab);
        void Delete(int numeroAsignado);
        Laboratorio GetByNumero(int numeroAsignado);
        List<Laboratorio> GetAll();
    }
}
