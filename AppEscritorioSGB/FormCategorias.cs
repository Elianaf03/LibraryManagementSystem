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
    public partial class FormCategorias : Form
    {
        int idUltimoCategoria = 0;
        int idSeleccionar = 0;
        public FormCategorias()
        {
            InitializeComponent();
            Precarga();
            this.dgvCategorias.DataSource = Biblioteca.ListaCategorias;
            ObtenerUltimoIdCategoria();
        }

        public void Precarga()
        {
            Categoria c1 = new Categoria(1, "Tecnologia", "Libros de tecnologia y ciencia");
            Categoria c2 = new Categoria(2, "Historia", "Libros de historia");
            Categoria c3 = new Categoria(3, "Matematica", "Libros de ciencias exactas");
            Categoria c4 = new Categoria(4, "Informatica", "Libros de informatica y programacion");
            Biblioteca.ListaCategorias.Add(c1);
            Biblioteca.ListaCategorias.Add(c2);
            Biblioteca.ListaCategorias.Add(c3);
            Biblioteca.ListaCategorias.Add(c4);
        }
        public void CargarCategorias()
        {
            this.dgvCategorias.DataSource = null;
            RedibujatDGVCategorias();
            this.dgvCategorias.DataSource = Biblioteca.ListaCategorias;
        }
        private void FormCategorias_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtDescripcion.Text != "")
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = int.Parse(this.txtId.Text);
                    categoria.Nombre = this.txtNombre.Text;
                    categoria.Descripcion = this.txtDescripcion.Text;
                    Biblioteca.AgregarCategoria(categoria);
                    Limpiar();
                    CargarCategorias();

                    //Obtener ultimo ID
                    ObtenerUltimoIdCategoria();
                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar categoria", "Error");
            }
        }

        public void ObtenerUltimoIdCategoria()
        {
            this.idUltimoCategoria = Biblioteca.ObtenerUltimoID() + 1;
            this.txtId.Text = idUltimoCategoria.ToString();
        }
        private void Limpiar()
        {
            ObtenerUltimoIdCategoria();
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
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
                    Biblioteca.ModificarCategoria(categoria);
                    Limpiar();
                    CargarCategorias();

                    //Obtener ultimo ID
                    ObtenerUltimoIdCategoria();
                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar categoria", "Error");
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

                    if (result==DialogResult.Yes)
                    {
                        Biblioteca.EliminarCategoria(idSeleccionar);
                        Limpiar();
                        CargarCategorias();
                    }
                    else { }
                    

                    //Obtener ultimo ID
                    ObtenerUltimoIdCategoria();
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

        public void RedibujatDGVCategorias()
        {
            // dgvCategorias
            // 
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion});
            this.dgvCategorias.Location = new System.Drawing.Point(6, 205);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(433, 144);
            this.dgvCategorias.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 180;
            this.dgvCategorias.DataSource = Biblioteca.ListaCategorias;
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idSeleccionar = int.Parse(this.dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvCategorias.CurrentRow != null)
                {
                    this.txtId.Text = this.dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                    this.txtNombre.Text = this.dgvCategorias.CurrentRow.Cells[1].Value.ToString();
                    this.txtDescripcion.Text= this.dgvCategorias.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar DGV", "Error");
            }
        }
    }
}
