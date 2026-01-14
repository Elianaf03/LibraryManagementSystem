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
    public partial class FormReportePrestamoDetalle : Form
    {
        public int IdPrestamo { get; set; }
        public FormReportePrestamoDetalle()
        {
            InitializeComponent();
        }

        private void FormReportePrestamoDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsResportePrestamoDetalle.spReporteTicketPrestamo2' Puede moverla o quitarla según sea necesario.
            this.spReporteTicketPrestamo2TableAdapter.Fill(this.dsResportePrestamoDetalle.spReporteTicketPrestamo2, IdPrestamo);

            this.reportViewer1.RefreshReport();
        }
    }
}
