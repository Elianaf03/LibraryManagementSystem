using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }

        public Prestamo(int idPrestamo, DateTime fechaPrestamo, DateTime fechaDevolucion, string estado, int idUsuario)
        {
            IdPrestamo = idPrestamo;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Estado = estado;
            IdUsuario = idUsuario;
        }

        public Prestamo()
        {
        }
    }
}
