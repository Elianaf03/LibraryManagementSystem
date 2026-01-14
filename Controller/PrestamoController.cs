using Entities;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PrestamoController
    {
        PrestamoDao prestamoDao = new PrestamoDao();
        public DataTable ListarPrestamosDetalle()
        {
            return prestamoDao.listarPrestamosDetalle(); 
        }

        public DataTable ListarPrestamosString()
        {
            return prestamoDao.listarPrestamosString();
        }

        public DataTable listarPrestamosXIdUsuario(int id)
        {
            return prestamoDao.listarPrestamosXIdUsuario(id);
        }
        public void registrarprestamo(Prestamo prestamo, List<PrestamoDetalle> lst)
        {
            prestamoDao.registrarPrestamo(prestamo, lst);
        }

        public void agregarprestamo(Prestamo prestamo)
        {
            prestamoDao.agregarPrestamos(prestamo);
        }

        public void editarprestamo(Prestamo prestamo)
        {
            prestamoDao.editarPrestamos(prestamo);
        }

        public void eliminarprestamo(int id)
        {
            prestamoDao.eliminarPrestamos(id);
        }

        public void devolverprestamo(Prestamo prestamo)
        {
            prestamoDao.devolverPrestamo(prestamo);
        }

        //Mostrar detalle de Prestamo
        public DataTable MostrarDetallePrestamoXIdPrestamo(int idPrestamo)
        {
            return this.prestamoDao.mostrarDetallePrestamoXIdPrestamo(idPrestamo);
        }

        //Obtener Prestamo por id
        public Prestamo ObtenerPrestamoXId(int idPrestamo)
        {
            return this.prestamoDao.obtenrPrestamoXId(idPrestamo);
        }
    }
}
