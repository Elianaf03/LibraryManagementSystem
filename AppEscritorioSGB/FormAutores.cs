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
    public partial class FormAutores : Form
    {
        int idUltimoAutor = 0;
        int idSeleccionar = 0;
        public FormAutores()
        {
            InitializeComponent();
            Precarga();
            this.dgvAutores.DataSource = Biblioteca.ListaAutores;
            ObtenerUltimoIdAutor();
        }
        
        public void Precarga()
        {
            Autor a1 = new Autor(1, "Diego", "Peretti");
            Autor a2 = new Autor(2, "Mauricio", "D'alessandro");
            Autor a3 = new Autor(3, "Federico", "D'Elia");
            Autor a4 = new Autor(4, "Mario", "Santos");
            Biblioteca.ListaAutores.Add(a1);
            Biblioteca.ListaAutores.Add(a2);
            Biblioteca.ListaAutores.Add(a3);
            Biblioteca.ListaAutores.Add(a4);
        }
        public void CargarAutores()
        {
            this.dgvAutores.DataSource = null;
            RedibujatDGVAutor();
            this.dgvAutores.DataSource = Biblioteca.ListaAutores;
        }
        public void ObtenerUltimoIdAutor()
        {
            this.idUltimoAutor = Biblioteca.ObtenerUltimoIDAutor() + 1;
            this.txtId.Text = idUltimoAutor.ToString();
        }
        private void Limpiar()
        {
            ObtenerUltimoIdAutor();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
        }
        public void RedibujatDGVAutor()
        {
            // dgvAutores
            // 
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido});
            this.dgvAutores.Location = new System.Drawing.Point(6, 179);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(433, 180);
            this.dgvAutores.TabIndex = 10;
            this.dgvAutores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellDoubleClick);
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
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 180;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtApellido.Text != "")
                {
                    Autor Autor = new Autor();
                    Autor.Id = int.Parse(this.txtId.Text);
                    Autor.Nombre = this.txtNombre.Text;
                    Autor.Apellido = this.txtApellido.Text;
                    Biblioteca.AgregarAutor(Autor);
                    Limpiar();
                    CargarAutores();

                    //Obtener ultimo ID
                    ObtenerUltimoIdAutor();
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
                    Autor Autor = new Autor();
                    Autor.Id = int.Parse(this.txtId.Text);
                    Autor.Nombre = this.txtNombre.Text;
                    Autor.Apellido = this.txtApellido.Text;
                    Biblioteca.ModificarAutor(Autor);
                    Limpiar();
                    CargarAutores();

                    //Obtener ultimo ID
                    ObtenerUltimoIdAutor();
                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Autor", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text != "" && this.txtNombre.Text != "" && this.txtApellido.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro de eliminar la Autor?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Biblioteca.EliminarAutor(idSeleccionar);
                        Limpiar();
                        CargarAutores();
                    }
                    else { }


                    //Obtener ultimo ID
                    ObtenerUltimoIdAutor();
                }
                else
                {
                    MessageBox.Show("Verifique de llenar los campos", "Carga de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Autor", "Error");
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
