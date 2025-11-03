using System;

namespace SistemaReservas.Models
{
    /// <summary>
    /// Representa un laboratorio de informática.
    /// </summary>
    public class Laboratorio
    {
        /// <summary>
        /// Número único que identifica al laboratorio (Clave Primaria).
        /// </summary>
        public int NumeroAsignado { get; set; }

        /// <summary>
        /// Ubicación del laboratorio, indicando el piso.
        /// </summary>
        public string UbicacionPiso { get; set; }

        /// <summary>
        /// Capacidad máxima de puestos de trabajo en el laboratorio.
        /// </summary>
        public int CapacidadPuestos { get; set; }
    }
}
