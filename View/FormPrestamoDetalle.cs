using Controller;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormPrestamoDetalle : Form
    {
        PrestamoController prestamoController = new PrestamoController();
        UsuarioController usuarioController = new UsuarioController();
        int idPrestamoParaTicket=0;
        //public FormPrestamoDetalle()
        //{
        //    InitializeComponent();
            
        //}
        public FormPrestamoDetalle( int idPrestamo)
        {
            InitializeComponent();
            if (UsuarioCache.Rol == "Socio")
            {
                deshabilitarControles();
            }
            MostrarDatosDelPrestamo(idPrestamo);
            cargarDetalleDePrestamo(idPrestamo);
            this.idPrestamoParaTicket = idPrestamo;
        }

        private void deshabilitarControles()
        {
            this.dtpFechaDePrestamo.Enabled = false;
            this.dtpFechaDeDevolucion.Enabled = false;
            this.cmbEstado.Visible = false;
            this.txtUsuarioLector.Enabled = false;
            this.lblEstado.Visible = true;
            this.btnDevolver.Visible = false;
            this.btnLimpiar.Visible = false;
        }
        public void cargarDetalleDePrestamo(int idPrestamo)
        {
            this.dgvListaLibros.DataSource = prestamoController.MostrarDetallePrestamoXIdPrestamo(idPrestamo);
        }
        int IdUsuarioParaDevolucion=0;
        public void MostrarDatosDelPrestamo(int idPrestamo)
        {
            Prestamo p = prestamoController.ObtenerPrestamoXId(idPrestamo);
            Usuario u = usuarioController.ObtenerUsuarioXId(p.IdUsuario);
            this.lblIdPrestamoId.Text = p.IdPrestamo.ToString();
            this.dtpFechaDePrestamo.Text = p.FechaPrestamo.ToString();
            this.dtpFechaDeDevolucion.Text = p.FechaDevolucion.ToString();
            this.cmbEstado.Text = p.Estado;
            this.lblEstado.Text = p.Estado;
            if (p.Estado =="Devuelto")
            {
                this.cmbEstado.ForeColor = Color.White;
                this.cmbEstado.BackColor = Color.DarkGreen;

                this.lblEstado.ForeColor = Color.White;
                this.lblEstado.BackColor = Color.DarkGreen;
            }
            else
            {
                if (p.Estado == "Activo")
                {
                    this.cmbEstado.ForeColor = Color.White;
                    this.cmbEstado.BackColor = Color.DarkRed;

                    this.lblEstado.ForeColor = Color.White;
                    this.lblEstado.BackColor = Color.DarkRed;
                }
            }
            this.txtUsuarioLector.Text = u.IdUsuario + "-" + u.Nombre + " " + u.Apellido;
            this.IdUsuarioParaDevolucion = u.IdUsuario;
            //CargarListaDeLibros(idPrestamo);

        }

        private void dgvListaLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //mostrar los datos del libro seleccionado
            try
            {
                // se debe modificar el procedimiento almacenado en la columna con "Ver Funciones" as op
                if (e.RowIndex < 0 || e.ColumnIndex != dgvListaLibros.Columns["Detalle"].Index)
                {
                    return;
                }
                else
                {

                    if (this.dgvListaLibros.CurrentRow != null)
                    {
                        string nombre;
                        string apellido;
                        this.lblNombreDelLibro.Text = this.dgvListaLibros.CurrentRow.Cells[1].Value.ToString();
                        nombre = this.dgvListaLibros.CurrentRow.Cells[8].Value.ToString();
                        apellido = this.dgvListaLibros.CurrentRow.Cells[9].Value.ToString();
                        this.lblAutorNombreCompleto.Text = nombre + " " + apellido;
                        this.lblCategoria.Text = this.dgvListaLibros.CurrentRow.Cells[10].Value.ToString();

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar DataGrid Lista Libros " + ex, "Error");
            }
        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            //instanciar formulario de reporte y agregarle as su propiedad IdPrestamo
            FormReportePrestamoDetalle formReportePrestamoDetalle = new FormReportePrestamoDetalle();
            formReportePrestamoDetalle.IdPrestamo = this.idPrestamoParaTicket;
            formReportePrestamoDetalle.ShowDialog();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = new Prestamo();
                
                prestamo.IdPrestamo = Convert.ToInt32(this.lblIdPrestamoId.Text);
                prestamo.FechaPrestamo = Convert.ToDateTime(this.dtpFechaDePrestamo.Text);
                prestamo.FechaDevolucion= Convert.ToDateTime(this.dtpFechaDeDevolucion.Text);
                prestamo.Estado = this.cmbEstado.Text;
                prestamo.IdUsuario = IdUsuarioParaDevolucion;

                prestamoController.devolverprestamo(prestamo);
                MessageBox.Show("Devolucion Registrado con Exito");
                //Limpiar();
                //cargarPrestamosRealizados();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en Registrar Prestamo " + ex, "Error");
            }
        }
    }
}
