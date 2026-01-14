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
    public partial class FormAutoresDB : Form
    {
        AutorController autorController = new AutorController();
        int idSeleccionar=0;
        public FormAutoresDB()
        {
            InitializeComponent();
            CargarAutores();
        }
        private void CargarAutores()
        {
            this.dgvAutores.DataSource = autorController.ListarAutores();
        }

        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text != "" && this.txtApellido.Text != "")
                {
                    Autor autor = new Autor();
                    //autor.Id = int.Parse(this.txtId.Text);
                    autor.Nombre = this.txtNombre.Text;
                    autor.Apellido = this.txtApellido.Text;
                    autorController.agregarautor(autor);
                    Limpiar();
                    CargarAutores();

                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Autor", "Error");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtApellido.Text != "")
                {
                    Autor autor = new Autor();
                    autor.Id = int.Parse(this.txtId.Text);
                    autor.Nombre = this.txtNombre.Text;
                    autor.Apellido = this.txtApellido.Text;
                    autorController.editarautor(autor);
                    Limpiar();
                    CargarAutores();

                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar Autor "+ex, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtApellido.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro de eliminar la categoria?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        autorController.eliminarautor(idSeleccionar);
                        Limpiar();
                        CargarAutores();
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar autor", "Error");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idSeleccionar = int.Parse(this.dgvAutores.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvAutores.CurrentRow != null)
                {
                    this.txtId.Text = this.dgvAutores.CurrentRow.Cells[0].Value.ToString();
                    this.txtNombre.Text = this.dgvAutores.CurrentRow.Cells[1].Value.ToString();
                    this.txtApellido.Text = this.dgvAutores.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar DGV", "Error");
            }
        }
    }
}
