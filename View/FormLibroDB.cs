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
    public partial class FormLibroDB : Form
    {
        LibroController libroController = new LibroController();
        AutorController autorController = new AutorController();
        CategoriaController categoriaController = new CategoriaController();
        int idLibroSeleccionado = 0;
        public FormLibroDB()
        {
            InitializeComponent();
            CargarLibros();
            ListarAutores();
            ListarCategorias();
        }
        private void CargarLibros()
        {
            this.dgvLibros.DataSource = libroController.ListarLibrosString();
        }

        private void ListarAutores()
        {
            this.autorCMB.DataSource = autorController.ListarAutoresString();
            this.autorCMB.DisplayMember = "DatosAutor";
            this.autorCMB.ValueMember = "IdAutor";
        }

        private void ListarCategorias()
        {
            this.categoriaCMB.DataSource = categoriaController.ListarCategoriasString();
            this.categoriaCMB.DisplayMember = "DatosCategoria";
            this.categoriaCMB.ValueMember = "IdCategoria";
        }

        public void Limpiar()
        {
            this.txtId.Clear();
            this.txtTitulo.Clear();
            this.autorCMB.Text = "";
            this.categoriaCMB.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.Text != "")
                {
                    Libro lib = new Libro();
                    //lib.Id = int.Parse(this.txtId.Text);
                    lib.Titulo = this.txtTitulo.Text;
                    lib.Categoria = Convert.ToInt32(this.categoriaCMB.SelectedValue);
                    lib.Autor = Convert.ToInt32(this.autorCMB.SelectedValue);
                    libroController.agregarlibro(lib);
                    CargarLibros();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Verifique que los campos esten completos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar libro" + ex, "Cargar campos");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    Libro lib = new Libro();
                    lib.Id = int.Parse(this.txtId.Text);
                    lib.Titulo = this.txtTitulo.Text;
                    lib.Autor = Convert.ToInt32(this.autorCMB.SelectedValue);
                    lib.Categoria = Convert.ToInt32(this.categoriaCMB.SelectedValue);
                    libroController.editarlibro(lib);
                    CargarLibros();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Verifique que los campos esten completos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar libro" + ex, "Cargar campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Seguro de que quiere eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        libroController.eliminarlibro(int.Parse(this.txtId.Text));
                        CargarLibros();
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Cargar campos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar autor" + ex, "Cargar campos");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idLibroSeleccionado = int.Parse(this.dgvLibros.CurrentRow.Cells[2].Value.ToString());
                if (this.dgvLibros.CurrentRow != null)
                {
                    this.txtId.Text = this.dgvLibros.CurrentRow.Cells[2].Value.ToString();
                    this.txtTitulo.Text = this.dgvLibros.CurrentRow.Cells[3].Value.ToString();
                    this.autorCMB.Text = this.dgvLibros.CurrentRow.Cells[4].Value.ToString();
                    this.categoriaCMB.Text = this.dgvLibros.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar autor" + ex, "Cargar campos");
            }
        }

        FormCategoriasDB formCategorias = new FormCategoriasDB();
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                formCategorias.FormClosed += Volver;
                formCategorias.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex, "Categorias");
            }
        }

        private void Volver(object sender, EventArgs e)
        {
            this.ListarAutores();
            this.ListarCategorias();
        }

        FormAutoresDB formAutores = new FormAutoresDB();
        private void btnAutores_Click(object sender, EventArgs e)
        {
            try
            {
                formAutores.FormClosed += Volver;
                formAutores.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex, "Autores");
            }
        }
    }
}
