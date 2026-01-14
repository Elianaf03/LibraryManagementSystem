using AppEscritorioSGB.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioSGB
{
    public partial class FormLibro : Form
    {
        int idUltimoLibro=0;
        int idLibroSeleccionado = 0;
        //int idUltimoLibro = 0;
        Autor autorSeleccionado;
        Categoria categoriaSeleccionar;

        public FormLibro()
        {
            InitializeComponent();
            Precarga();
            ObtenerUltimoIDLibro();
            CargarCategoriasYAutores();
            this.dgvLibros.DataSource = Biblioteca.ListaLibros;
        }
        
        public void Precarga()
        {
            Libro l1 = new Libro(1, "Matematica de Primero", Biblioteca.ListaAutores[1],Biblioteca.ListaCategorias[2]);
            Libro l2 = new Libro(2, "Historia Argentina", Biblioteca.ListaAutores[1], Biblioteca.ListaCategorias[1]);
            Libro l3 = new Libro(3, "Fisica I", Biblioteca.ListaAutores[2], Biblioteca.ListaCategorias[1]);
            Biblioteca.ListaLibros.Add(l1);
            Biblioteca.ListaLibros.Add(l2);
            Biblioteca.ListaLibros.Add(l3);
        }

        public void CargarCategoriasYAutores()
        {
            this.dgvCategorias.DataSource = null;
            this.dgvCategorias.DataSource = Biblioteca.ListaCategorias;

            this.dgvAutores.DataSource = null;
            this.dgvAutores.DataSource = Biblioteca.ListaAutores;
        }

        public void CargarLibros()
        {
            this.dgvLibros.DataSource = null;
            this.redibujarDGVlibros();
        }

        public void Limpiar()
        {
            this.txtId.Clear();
            this.txtTitulo.Clear();
            this.txtAutor.Clear();
            this.txtCategoria.Clear();
            ObtenerUltimoIDLibro();
        }

        public void ObtenerUltimoIDLibro()
        {
            this.idUltimoLibro = Biblioteca.ObtenerUltimoIDLibro() + 1;
            this.txtId.Text = idUltimoLibro.ToString();
        }

        public void redibujarDGVlibros()
        {
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorcito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoriita = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Categoria,
            this.Autorcito,
            this.Categoriita});
            this.dgvLibros.Location = new System.Drawing.Point(19, 309);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(581, 150);
            this.dgvLibros.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 40;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 120;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "DatosAutor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 170;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "DatosCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 170;
            // 
            // Autorcito
            // 
            this.Autorcito.DataPropertyName = "Autor";
            this.Autorcito.HeaderText = "AutorC";
            this.Autorcito.Name = "Autorcito";
            this.Autorcito.Visible = false;
            // 
            // Categoriita
            // 
            this.Categoriita.DataPropertyName = "Categoria";
            this.Categoriita.HeaderText = "CategoriaC";
            this.Categoriita.Name = "Categoriita";
            this.Categoriita.Visible = false;
            this.dgvLibros.DataSource = Biblioteca.ListaLibros;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAutor.Text != "" && txtCategoria.Text != "")
                {
                    Libro lib = new Libro();
                    lib.Id = int.Parse(this.txtId.Text);
                    lib.Titulo = this.txtTitulo.Text;
                    lib.Autor = autorSeleccionado;
                    lib.Categoria = categoriaSeleccionar;
                    Biblioteca.AgregarLibro(lib);
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

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvCategorias.CurrentRow != null)
                {
                    Categoria cat = new Categoria();
                    cat.Id = int.Parse(this.dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                    cat.Nombre = this.dgvCategorias.CurrentRow.Cells[1].Value.ToString();
                    cat.Descripcion = this.dgvCategorias.CurrentRow.Cells[2].Value.ToString();
                    this.txtCategoria.Text = cat.ObtenerCategoria();
                    categoriaSeleccionar = cat;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar categoria" + ex, "Cargar campos");
            }
        }

        private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvAutores.CurrentRow != null)
                {
                    Autor aut = new Autor();
                    aut.Id = int.Parse(this.dgvAutores.CurrentRow.Cells[0].Value.ToString());
                    aut.Nombre = this.dgvAutores.CurrentRow.Cells[1].Value.ToString();
                    aut.Apellido = this.dgvAutores.CurrentRow.Cells[2].Value.ToString();
                    this.txtAutor.Text = aut.ObtenerAutor();
                    autorSeleccionado = aut;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar autor" + ex, "Cargar campos");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAutor.Text != "" && txtCategoria.Text != "")
                {
                    Libro lib = new Libro();
                    lib.Id = int.Parse(this.txtId.Text);
                    lib.Titulo = this.txtTitulo.Text;
                    lib.Autor = autorSeleccionado;
                    lib.Categoria = categoriaSeleccionar;
                    Biblioteca.ModificarLibro(lib);
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

                MessageBox.Show("Error al modificar libro" + ex, "Modificar campos");
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idLibroSeleccionado=int.Parse(this.dgvLibros.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvLibros.CurrentRow != null)
                {
                    Libro li = new Libro();
                    li.Id = idLibroSeleccionado;
                    li.Titulo= this.dgvLibros.CurrentRow.Cells[1].Value.ToString();

                    Autor au = new Autor();
                    au = Biblioteca.ObtenerAutorLibro(this.idLibroSeleccionado);
                    li.Autor = au;
                    this.autorSeleccionado = au;

                    Categoria ca = new Categoria();
                    ca = Biblioteca.ObtenerCategoriaLibro(this.idLibroSeleccionado);
                    li.Categoria = ca;
                    this.categoriaSeleccionar = ca;

                    this.txtId.Text= this.dgvLibros.CurrentRow.Cells[0].Value.ToString();
                    this.txtTitulo.Text= this.dgvLibros.CurrentRow.Cells[1].Value.ToString();
                    this.txtAutor.Text = li.DatosAutor;
                    this.txtCategoria.Text = li.DatosCategoria;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar autor" + ex, "Cargar campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAutor.Text != "" && txtCategoria.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Seguro de que quiere eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Biblioteca.EliminarLibro(int.Parse(this.txtId.Text));
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
            ObtenerUltimoIDLibro();
        }
        FormAutores formAutores = new FormAutores();
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

        private void Volver(object sender, EventArgs e)
        {
            this.CargarCategoriasYAutores();
        }
        
        FormCategorias formCategorias = new FormCategorias();
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
    }
}
