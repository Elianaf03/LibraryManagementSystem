
namespace View
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDatosdeUsuario = new System.Windows.Forms.Panel();
            this.lblRolUsuarioActual = new Guna.UI.WinForms.GunaLabel();
            this.lblUsuarioActual = new Guna.UI.WinForms.GunaLabel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTituloDeFormularioHijo = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.iconActualHijoDeFormulario = new FontAwesome.Sharp.IconPictureBox();
            this.btnIconSocio = new FontAwesome.Sharp.IconButton();
            this.btnIconAutores = new FontAwesome.Sharp.IconButton();
            this.btnIconUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnIconLibros = new FontAwesome.Sharp.IconButton();
            this.btnIconCategorias = new FontAwesome.Sharp.IconButton();
            this.btnIconPrestamos = new FontAwesome.Sharp.IconButton();
            this.btnIconPrincipal = new FontAwesome.Sharp.IconButton();
            this.pcbFotoUsuarioActual = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panelMenu.SuspendLayout();
            this.panelDatosdeUsuario.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualHijoDeFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuarioActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnIconSocio);
            this.panelMenu.Controls.Add(this.btnIconAutores);
            this.panelMenu.Controls.Add(this.btnIconUsuarios);
            this.panelMenu.Controls.Add(this.btnIconLibros);
            this.panelMenu.Controls.Add(this.btnIconCategorias);
            this.panelMenu.Controls.Add(this.btnIconPrestamos);
            this.panelMenu.Controls.Add(this.btnIconPrincipal);
            this.panelMenu.Controls.Add(this.panelDatosdeUsuario);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(197, 589);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // panelDatosdeUsuario
            // 
            this.panelDatosdeUsuario.Controls.Add(this.lblRolUsuarioActual);
            this.panelDatosdeUsuario.Controls.Add(this.lblUsuarioActual);
            this.panelDatosdeUsuario.Controls.Add(this.pcbFotoUsuarioActual);
            this.panelDatosdeUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosdeUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelDatosdeUsuario.Name = "panelDatosdeUsuario";
            this.panelDatosdeUsuario.Size = new System.Drawing.Size(197, 134);
            this.panelDatosdeUsuario.TabIndex = 0;
            this.panelDatosdeUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDatosdeUsuario_MouseDown);
            // 
            // lblRolUsuarioActual
            // 
            this.lblRolUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuarioActual.ForeColor = System.Drawing.Color.Yellow;
            this.lblRolUsuarioActual.Location = new System.Drawing.Point(114, 76);
            this.lblRolUsuarioActual.Name = "lblRolUsuarioActual";
            this.lblRolUsuarioActual.Size = new System.Drawing.Size(80, 18);
            this.lblRolUsuarioActual.TabIndex = 2;
            this.lblRolUsuarioActual.Text = "ROL";
            this.lblRolUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.Yellow;
            this.lblUsuarioActual.Location = new System.Drawing.Point(114, 38);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(80, 22);
            this.lblUsuarioActual.TabIndex = 1;
            this.lblUsuarioActual.Text = "USUARIO";
            this.lblUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelSuperior.Controls.Add(this.panel1);
            this.panelSuperior.Controls.Add(this.lblTituloDeFormularioHijo);
            this.panelSuperior.Controls.Add(this.iconActualHijoDeFormulario);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(197, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(816, 60);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(740, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 60);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSalir.Location = new System.Drawing.Point(51, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(22, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinimizar.Location = new System.Drawing.Point(24, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // lblTituloDeFormularioHijo
            // 
            this.lblTituloDeFormularioHijo.AutoSize = true;
            this.lblTituloDeFormularioHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDeFormularioHijo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloDeFormularioHijo.Location = new System.Drawing.Point(58, 16);
            this.lblTituloDeFormularioHijo.Name = "lblTituloDeFormularioHijo";
            this.lblTituloDeFormularioHijo.Size = new System.Drawing.Size(82, 24);
            this.lblTituloDeFormularioHijo.TabIndex = 1;
            this.lblTituloDeFormularioHijo.Text = "Principal";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Black;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(197, 60);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(816, 529);
            this.panelCentral.TabIndex = 2;
            // 
            // iconActualHijoDeFormulario
            // 
            this.iconActualHijoDeFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconActualHijoDeFormulario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconActualHijoDeFormulario.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconActualHijoDeFormulario.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconActualHijoDeFormulario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActualHijoDeFormulario.IconSize = 35;
            this.iconActualHijoDeFormulario.Location = new System.Drawing.Point(9, 11);
            this.iconActualHijoDeFormulario.Name = "iconActualHijoDeFormulario";
            this.iconActualHijoDeFormulario.Size = new System.Drawing.Size(35, 35);
            this.iconActualHijoDeFormulario.TabIndex = 0;
            this.iconActualHijoDeFormulario.TabStop = false;
            // 
            // btnIconSocio
            // 
            this.btnIconSocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconSocio.FlatAppearance.BorderSize = 0;
            this.btnIconSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconSocio.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnIconSocio.IconColor = System.Drawing.Color.White;
            this.btnIconSocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconSocio.IconSize = 40;
            this.btnIconSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconSocio.Location = new System.Drawing.Point(0, 494);
            this.btnIconSocio.Name = "btnIconSocio";
            this.btnIconSocio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconSocio.Size = new System.Drawing.Size(197, 60);
            this.btnIconSocio.TabIndex = 7;
            this.btnIconSocio.Text = "Socio";
            this.btnIconSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconSocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconSocio.UseVisualStyleBackColor = true;
            this.btnIconSocio.Click += new System.EventHandler(this.btnIconSocio_Click);
            // 
            // btnIconAutores
            // 
            this.btnIconAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconAutores.FlatAppearance.BorderSize = 0;
            this.btnIconAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconAutores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconAutores.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnIconAutores.IconColor = System.Drawing.Color.White;
            this.btnIconAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconAutores.IconSize = 40;
            this.btnIconAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconAutores.Location = new System.Drawing.Point(0, 434);
            this.btnIconAutores.Name = "btnIconAutores";
            this.btnIconAutores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconAutores.Size = new System.Drawing.Size(197, 60);
            this.btnIconAutores.TabIndex = 6;
            this.btnIconAutores.Text = "Autores";
            this.btnIconAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconAutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconAutores.UseVisualStyleBackColor = true;
            this.btnIconAutores.Click += new System.EventHandler(this.btnIconAutores_Click);
            // 
            // btnIconUsuarios
            // 
            this.btnIconUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconUsuarios.FlatAppearance.BorderSize = 0;
            this.btnIconUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnIconUsuarios.IconColor = System.Drawing.Color.White;
            this.btnIconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconUsuarios.IconSize = 40;
            this.btnIconUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconUsuarios.Location = new System.Drawing.Point(0, 374);
            this.btnIconUsuarios.Name = "btnIconUsuarios";
            this.btnIconUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconUsuarios.Size = new System.Drawing.Size(197, 60);
            this.btnIconUsuarios.TabIndex = 5;
            this.btnIconUsuarios.Text = "Usuarios";
            this.btnIconUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconUsuarios.UseVisualStyleBackColor = true;
            this.btnIconUsuarios.Click += new System.EventHandler(this.btnIconUsuarios_Click);
            // 
            // btnIconLibros
            // 
            this.btnIconLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconLibros.FlatAppearance.BorderSize = 0;
            this.btnIconLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnIconLibros.IconColor = System.Drawing.Color.White;
            this.btnIconLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconLibros.IconSize = 40;
            this.btnIconLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconLibros.Location = new System.Drawing.Point(0, 314);
            this.btnIconLibros.Name = "btnIconLibros";
            this.btnIconLibros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconLibros.Size = new System.Drawing.Size(197, 60);
            this.btnIconLibros.TabIndex = 4;
            this.btnIconLibros.Text = "Libros";
            this.btnIconLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconLibros.UseVisualStyleBackColor = true;
            this.btnIconLibros.Click += new System.EventHandler(this.btnIconLibros_Click);
            // 
            // btnIconCategorias
            // 
            this.btnIconCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconCategorias.FlatAppearance.BorderSize = 0;
            this.btnIconCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconCategorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconCategorias.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnIconCategorias.IconColor = System.Drawing.Color.White;
            this.btnIconCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconCategorias.IconSize = 40;
            this.btnIconCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconCategorias.Location = new System.Drawing.Point(0, 254);
            this.btnIconCategorias.Name = "btnIconCategorias";
            this.btnIconCategorias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconCategorias.Size = new System.Drawing.Size(197, 60);
            this.btnIconCategorias.TabIndex = 3;
            this.btnIconCategorias.Text = "Categorias";
            this.btnIconCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconCategorias.UseVisualStyleBackColor = true;
            this.btnIconCategorias.Click += new System.EventHandler(this.btnIconCategorias_Click);
            // 
            // btnIconPrestamos
            // 
            this.btnIconPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconPrestamos.FlatAppearance.BorderSize = 0;
            this.btnIconPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconPrestamos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconPrestamos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnIconPrestamos.IconColor = System.Drawing.Color.White;
            this.btnIconPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconPrestamos.IconSize = 40;
            this.btnIconPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconPrestamos.Location = new System.Drawing.Point(0, 194);
            this.btnIconPrestamos.Name = "btnIconPrestamos";
            this.btnIconPrestamos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconPrestamos.Size = new System.Drawing.Size(197, 60);
            this.btnIconPrestamos.TabIndex = 2;
            this.btnIconPrestamos.Text = "Prestamos";
            this.btnIconPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconPrestamos.UseVisualStyleBackColor = true;
            this.btnIconPrestamos.Click += new System.EventHandler(this.btnIconPrestamos_Click);
            // 
            // btnIconPrincipal
            // 
            this.btnIconPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIconPrincipal.FlatAppearance.BorderSize = 0;
            this.btnIconPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnIconPrincipal.IconColor = System.Drawing.Color.White;
            this.btnIconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconPrincipal.IconSize = 40;
            this.btnIconPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconPrincipal.Location = new System.Drawing.Point(0, 134);
            this.btnIconPrincipal.Name = "btnIconPrincipal";
            this.btnIconPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIconPrincipal.Size = new System.Drawing.Size(197, 60);
            this.btnIconPrincipal.TabIndex = 1;
            this.btnIconPrincipal.Text = "Principal";
            this.btnIconPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconPrincipal.UseVisualStyleBackColor = true;
            this.btnIconPrincipal.Click += new System.EventHandler(this.btnIconPrincipal_Click);
            // 
            // pcbFotoUsuarioActual
            // 
            this.pcbFotoUsuarioActual.BaseColor = System.Drawing.Color.White;
            this.pcbFotoUsuarioActual.Image = global::View.Properties.Resources.pngwing_com;
            this.pcbFotoUsuarioActual.Location = new System.Drawing.Point(12, 18);
            this.pcbFotoUsuarioActual.Name = "pcbFotoUsuarioActual";
            this.pcbFotoUsuarioActual.Size = new System.Drawing.Size(95, 95);
            this.pcbFotoUsuarioActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoUsuarioActual.TabIndex = 0;
            this.pcbFotoUsuarioActual.TabStop = false;
            this.pcbFotoUsuarioActual.UseTransfarantBackground = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.panelDatosdeUsuario.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconActualHijoDeFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuarioActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnIconUsuarios;
        private FontAwesome.Sharp.IconButton btnIconLibros;
        private FontAwesome.Sharp.IconButton btnIconCategorias;
        private FontAwesome.Sharp.IconButton btnIconPrestamos;
        private FontAwesome.Sharp.IconButton btnIconPrincipal;
        private System.Windows.Forms.Panel panelDatosdeUsuario;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloDeFormularioHijo;
        private FontAwesome.Sharp.IconPictureBox iconActualHijoDeFormulario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelCentral;
        private Guna.UI.WinForms.GunaLabel lblRolUsuarioActual;
        private Guna.UI.WinForms.GunaLabel lblUsuarioActual;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbFotoUsuarioActual;
        private FontAwesome.Sharp.IconButton btnIconAutores;
        private FontAwesome.Sharp.IconButton btnIconSocio;
    }
}

