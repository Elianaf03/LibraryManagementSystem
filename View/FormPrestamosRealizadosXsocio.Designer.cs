
namespace View
{
    partial class FormPrestamosRealizadosXsocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvPrestamosRealizados = new System.Windows.Forms.DataGridView();
            this.IdPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadLibros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvPrestamosRealizados);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(141, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(604, 249);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TUS PRESTAMOS";
            // 
            // dgvPrestamosRealizados
            // 
            this.dgvPrestamosRealizados.AllowUserToAddRows = false;
            this.dgvPrestamosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosRealizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrestamo,
            this.CantidadLibros,
            this.Socio,
            this.FechaPrestamo,
            this.Estado,
            this.DetalleL});
            this.dgvPrestamosRealizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamosRealizados.Location = new System.Drawing.Point(3, 17);
            this.dgvPrestamosRealizados.Name = "dgvPrestamosRealizados";
            this.dgvPrestamosRealizados.ReadOnly = true;
            this.dgvPrestamosRealizados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrestamosRealizados.Size = new System.Drawing.Size(598, 229);
            this.dgvPrestamosRealizados.TabIndex = 11;
            this.dgvPrestamosRealizados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamosRealizados_CellClick);
            // 
            // IdPrestamo
            // 
            this.IdPrestamo.DataPropertyName = "ID";
            this.IdPrestamo.HeaderText = "Id";
            this.IdPrestamo.Name = "IdPrestamo";
            this.IdPrestamo.ReadOnly = true;
            this.IdPrestamo.Width = 40;
            // 
            // CantidadLibros
            // 
            this.CantidadLibros.DataPropertyName = "CantidadLibros";
            this.CantidadLibros.HeaderText = "Cantidad";
            this.CantidadLibros.Name = "CantidadLibros";
            this.CantidadLibros.ReadOnly = true;
            this.CantidadLibros.Width = 70;
            // 
            // Socio
            // 
            this.Socio.DataPropertyName = "NombreCompleto";
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            this.Socio.Width = 120;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.HeaderText = "Fecha";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // DetalleL
            // 
            this.DetalleL.DataPropertyName = "Detalle";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DetalleL.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetalleL.HeaderText = "Detalle";
            this.DetalleL.Name = "DetalleL";
            this.DetalleL.ReadOnly = true;
            this.DetalleL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormPrestamosRealizadosXsocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Name = "FormPrestamosRealizadosXsocio";
            this.Text = "FormPrestamosRealizadosXsocio";
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosRealizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPrestamosRealizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn DetalleL;
    }
}