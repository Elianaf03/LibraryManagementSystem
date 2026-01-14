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
    public partial class FormReporteUsuarios : Form
    {
        public FormReporteUsuarios()
        {
            InitializeComponent();
        }

        private void FormReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds_ReporteUsuarios.sp_ReporteUsuarios' Puede moverla o quitarla según sea necesario.
            this.sp_ReporteUsuariosTableAdapter.Fill(this.ds_ReporteUsuarios.sp_ReporteUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
