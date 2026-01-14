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
    public partial class FormCategoriasDB : Form
    {
        CategoriaController categoriaController = new CategoriaController();
        public FormCategoriasDB()
        {
            InitializeComponent();
            CargarCategorias();
        }
        public void CargarCategorias()
        {
            dgvCategorias.DataSource = categoriaController.ListarCategorias();
        }
        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
        }
        int idSeleccionar;
        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idSeleccionar = int.Parse(this.dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvCategorias.CurrentRow != null)
                {
                    this.txtId.Text = this.dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                    this.txtNombre.Text = this.dgvCategorias.CurrentRow.Cells[1].Value.ToString();
                    this.txtDescripcion.Text = this.dgvCategorias.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar DGV", "Error");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if ( this.txtNombre.Text != "" && this.txtDescripcion.Text != "")
                {
                    Categoria categoria = new Categoria();
                    categoria.Nombre = this.txtNombre.Text;
                    categoria.Descripcion = this.txtDescripcion.Text;
                    categoriaController.agregarCategoria(categoria);
                    Limpiar();
                    CargarCategorias();

                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar categoria", "Error" + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtDescripcion.Text != "")
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = int.Parse(this.txtId.Text);
                    categoria.Nombre = this.txtNombre.Text;
                    categoria.Descripcion = this.txtDescripcion.Text;
                    categoriaController.editarCategoria(categoria);
                    Limpiar();
                    CargarCategorias();

                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar categoria "+ex, "Error" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtDescripcion.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro de eliminar la categoria?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        categoriaController.eliminarCategoria(idSeleccionar);
                        Limpiar();
                        CargarCategorias();
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
                MessageBox.Show("Error al eliminar categoria", "Error");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
