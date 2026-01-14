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
    public partial class FormPrestamosRealizadosXsocio : Form
    {
        PrestamoController prestamoController = new PrestamoController();
        public FormPrestamosRealizadosXsocio()
        {
            InitializeComponent();
            cargarPrestamosRealizados(UsuarioCache.IdUsuario);
        }
        private void cargarPrestamosRealizados(int idUsuario)
        {
            this.dgvPrestamosRealizados.DataSource = prestamoController.listarPrestamosXIdUsuario(idUsuario);
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
    }
}
