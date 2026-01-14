using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PrestamoDetalle
    {
        public int IdPrestamoDetalle { get; set; }
        public int IdPrestamo { get; set; }
        public int IdLibro { get; set; }

        public PrestamoDetalle(int idPrestamoDetalle, int idPrestamo, int idLibro)
        {
            IdPrestamoDetalle = idPrestamoDetalle;
            IdPrestamo = idPrestamo;
            IdLibro = idLibro;
        }

        public PrestamoDetalle()
        {
        }
    }
}
