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
    public partial class PrestamosDB : Form
    {
        LibroController libroController = new LibroController();
        PrestamoController prestamoController = new PrestamoController();
        UsuarioController usuarioController = new UsuarioController();

        public PrestamosDB()
        {
            InitializeComponent();
            cargarLibros();
            cargarUsuarios();
            cargarPrestamosRealizados();
        }
        private void cargarPrestamosRealizados()
        {
            this.dgvPrestamosRealizados.DataSource = prestamoController.ListarPrestamosDetalle();
        }
        private void cargarLibros()
        {
            this.dgvLibros.DataSource = libroController.ListarLibrosString();
        }
        private void cargarUsuarios()
        {
            this.dgvUsuarios.DataSource = usuarioController.ListarUsuarios("");
        }

        int idLibroSeleccionado = 0;
        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idLibroSeleccionado = int.Parse(this.dgvLibros.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvLibros.CurrentRow != null)
                {
                    string IdLibro = this.dgvLibros.CurrentRow.Cells[0].Value.ToString();
                    string Titulo = this.dgvLibros.CurrentRow.Cells[1].Value.ToString();

                    this.dgvListaLibros.Rows.Add(new object[] { IdLibro, Titulo, "Detalle", "Eliminar" });
                    this.lblLibroSeleccionado.Text = IdLibro;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en Seleccionar Libro del DataGrid " + ex, "Error");
            }
        }

        private void dgvListaLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvListaLibros.Columns["Op"].Index)
            {
                return;
            }
            else
            {
                dgvListaLibros.Rows.RemoveAt(e.RowIndex);

            }
        }

        int idUsuarioSeleccionadoParaPrestamo;
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idUsuarioSeleccionadoParaPrestamo = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvUsuarios.CurrentRow != null)
                {
                    string socioSeleccionado;
                    string id = this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                    string nombre = this.dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                    string apellido = this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                    socioSeleccionado = id + " - " + nombre + " " + apellido;
                    this.lblSocioSeleccionado.Text = id;
                    this.txtUsuarioLector.Text = socioSeleccionado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar DataGrid Socio " + ex, "Error");
            }
        }

        private void Limpiar()
        {
            this.dgvListaLibros.Rows.Clear();
            this.dtpFechaPrestamo.Text = "";
            this.dtpFechaDevolucion.Text = "";
            this.cmbEstado.Text = "";
            this.txtUsuarioLector.Text = "";
            this.lblLibroSeleccionado.Text = "0";
            this.lblSocioSeleccionado.Text = "0";
        }
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PrestamoDetalle> lst = new List<PrestamoDetalle>();

                foreach (DataGridViewRow dr in dgvListaLibros.Rows)
                {
                    PrestamoDetalle oPrestamoDetalle = new PrestamoDetalle();
                    oPrestamoDetalle.IdLibro = Int32.Parse(dr.Cells[0].Value.ToString());
                    lst.Add(oPrestamoDetalle);
                }
                Prestamo oPrestamo = new Prestamo();
                oPrestamo.FechaDevolucion = Convert.ToDateTime(this.dtpFechaDevolucion.Text);
                oPrestamo.Estado = this.cmbEstado.Text;
                oPrestamo.IdUsuario = idUsuarioSeleccionadoParaPrestamo;

                prestamoController.registrarprestamo(oPrestamo, lst);
                MessageBox.Show("Prestamo Registrado con Exito");
                Limpiar();
                cargarPrestamosRealizados();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en Registrar Prestamo " + ex, "Error");
            }
        }

        private void dgvPrestamosRealizados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvPrestamosRealizados.Columns["DetalleL"].Index)
            {
                return;
            }
            else
            {

                int idPrestamo = int.Parse(this.dgvPrestamosRealizados.CurrentRow.Cells[0].Value.ToString());
                FormPrestamoDetalle formPrestamoDetalle = new FormPrestamoDetalle(idPrestamo);
                formPrestamoDetalle.ShowDialog();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       
        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            this.dgvLibros.DataSource = libroController.ListarLibro(txtBuscarLibro.Text);
        }
    }
}
