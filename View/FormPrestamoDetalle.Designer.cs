
namespace View
{
    partial class FormPrestamoDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lblIdPrestamoId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvListaLibros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsuarioLector = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaDeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaDePrestamo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAutorNombreCompleto = new System.Windows.Forms.Label();
            this.lblNombreDelLibro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnDevolver);
            this.groupBox1.Controls.Add(this.lblIdPrestamoId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtUsuarioLector);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFechaDeDevolucion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaDePrestamo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE PRESTAMO";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(138, 149);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(189, 366);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 31);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDevolver.Location = new System.Drawing.Point(17, 366);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(132, 31);
            this.btnDevolver.TabIndex = 17;
            this.btnDevolver.Text = "DEVOLVER";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblIdPrestamoId
            // 
            this.lblIdPrestamoId.AutoSize = true;
            this.lblIdPrestamoId.Location = new System.Drawing.Point(132, 31);
            this.lblIdPrestamoId.Name = "lblIdPrestamoId";
            this.lblIdPrestamoId.Size = new System.Drawing.Size(72, 15);
            this.lblIdPrestamoId.TabIndex = 15;
            this.lblIdPrestamoId.Text = "IDPrestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Prestamo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvListaLibros);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(17, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 147);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LISTA DE PRESTAMOS";
            // 
            // dgvListaLibros
            // 
            this.dgvListaLibros.AllowUserToAddRows = false;
            this.dgvListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titulo,
            this.Detalle,
            this.FechaPrestamo,
            this.FechaDevolucion,
            this.IdUsuario,
            this.UsuarioLector,
            this.NombreAutor,
            this.ApellidoAutor,
            this.Categoria,
            this.Estado});
            this.dgvListaLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaLibros.Location = new System.Drawing.Point(3, 17);
            this.dgvListaLibros.Name = "dgvListaLibros";
            this.dgvListaLibros.Size = new System.Drawing.Size(298, 127);
            this.dgvListaLibros.TabIndex = 0;
            this.dgvListaLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaLibros_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdLibro";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 120;
            // 
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle1;
            this.Detalle.HeaderText = "Ver";
            this.Detalle.Name = "Detalle";
            this.Detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.HeaderText = "FechaPrestamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.Visible = false;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.DataPropertyName = "FechaDevolucion";
            this.FechaDevolucion.HeaderText = "FechaDevolucion";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            // 
            // UsuarioLector
            // 
            this.UsuarioLector.DataPropertyName = "UsuarioLector";
            this.UsuarioLector.HeaderText = "UsuarioLector";
            this.UsuarioLector.Name = "UsuarioLector";
            this.UsuarioLector.Visible = false;
            // 
            // NombreAutor
            // 
            this.NombreAutor.DataPropertyName = "NombreAutor";
            this.NombreAutor.HeaderText = "NombreAutor";
            this.NombreAutor.Name = "NombreAutor";
            this.NombreAutor.Visible = false;
            // 
            // ApellidoAutor
            // 
            this.ApellidoAutor.DataPropertyName = "ApellidoAutor";
            this.ApellidoAutor.HeaderText = "ApellidoAutor";
            this.ApellidoAutor.Name = "ApellidoAutor";
            this.ApellidoAutor.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = false;
            // 
            // txtUsuarioLector
            // 
            this.txtUsuarioLector.Location = new System.Drawing.Point(135, 185);
            this.txtUsuarioLector.Name = "txtUsuarioLector";
            this.txtUsuarioLector.Size = new System.Drawing.Size(200, 21);
            this.txtUsuarioLector.TabIndex = 2;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Devuelto",
            "Vencido",
            "Renovado",
            "Cancelado",
            "Perdido"});
            this.cmbEstado.Location = new System.Drawing.Point(135, 144);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 23);
            this.cmbEstado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Socio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado:";
            // 
            // dtpFechaDeDevolucion
            // 
            this.dtpFechaDeDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeDevolucion.Location = new System.Drawing.Point(135, 105);
            this.dtpFechaDeDevolucion.Name = "dtpFechaDeDevolucion";
            this.dtpFechaDeDevolucion.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaDeDevolucion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Devolucion:";
            // 
            // dtpFechaDePrestamo
            // 
            this.dtpFechaDePrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDePrestamo.Location = new System.Drawing.Point(135, 66);
            this.dtpFechaDePrestamo.Name = "dtpFechaDePrestamo";
            this.dtpFechaDePrestamo.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaDePrestamo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Prestamo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.lblAutorNombreCompleto);
            this.groupBox2.Controls.Add(this.lblNombreDelLibro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(373, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 137);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LIBRO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.Gold;
            this.lblCategoria.Location = new System.Drawing.Point(77, 102);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 15);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblAutorNombreCompleto
            // 
            this.lblAutorNombreCompleto.AutoSize = true;
            this.lblAutorNombreCompleto.ForeColor = System.Drawing.Color.Gold;
            this.lblAutorNombreCompleto.Location = new System.Drawing.Point(77, 66);
            this.lblAutorNombreCompleto.Name = "lblAutorNombreCompleto";
            this.lblAutorNombreCompleto.Size = new System.Drawing.Size(35, 15);
            this.lblAutorNombreCompleto.TabIndex = 16;
            this.lblAutorNombreCompleto.Text = "Autor";
            // 
            // lblNombreDelLibro
            // 
            this.lblNombreDelLibro.AutoSize = true;
            this.lblNombreDelLibro.ForeColor = System.Drawing.Color.Gold;
            this.lblNombreDelLibro.Location = new System.Drawing.Point(77, 31);
            this.lblNombreDelLibro.Name = "lblNombreDelLibro";
            this.lblNombreDelLibro.Size = new System.Drawing.Size(52, 15);
            this.lblNombreDelLibro.TabIndex = 15;
            this.lblNombreDelLibro.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Categoria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Autor:";
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimirTicket.FlatAppearance.BorderSize = 0;
            this.btnImprimirTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnImprimirTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimirTicket.Location = new System.Drawing.Point(408, 270);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(134, 31);
            this.btnImprimirTicket.TabIndex = 16;
            this.btnImprimirTicket.Text = "Imprimir Ticket";
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);
            // 
            // FormPrestamoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(610, 420);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrestamoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrestamoDetalle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdPrestamoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvListaLibros;
        private System.Windows.Forms.TextBox txtUsuarioLector;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaDeDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaDePrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAutorNombreCompleto;
        private System.Windows.Forms.Label lblNombreDelLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lblEstado;
    }
}