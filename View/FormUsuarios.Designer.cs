
namespace View
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lblIdUsuario = new Guna.UI.WinForms.GunaLabel();
            this.btnCambiarFoto = new Guna.UI.WinForms.GunaButton();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiar = new Guna.UI.WinForms.GunaButton();
            this.btnReporte = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtFiltroBuscarUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.chkApellido = new Guna.UI.WinForms.GunaCheckBox();
            this.chkDni = new Guna.UI.WinForms.GunaCheckBox();
            this.chkNombre = new Guna.UI.WinForms.GunaCheckBox();
            this.cmbRol = new Guna.UI.WinForms.GunaComboBox();
            this.txtCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtLoginName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtApellido = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.pbFotoUsuario = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvUsuarios = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).BeginInit();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Aqua;
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel9);
            this.gunaGroupBox1.Controls.Add(this.lblIdUsuario);
            this.gunaGroupBox1.Controls.Add(this.btnCambiarFoto);
            this.gunaGroupBox1.Controls.Add(this.btnAgregar);
            this.gunaGroupBox1.Controls.Add(this.btnEditar);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnLimpiar);
            this.gunaGroupBox1.Controls.Add(this.btnReporte);
            this.gunaGroupBox1.Controls.Add(this.gunaGroupBox2);
            this.gunaGroupBox1.Controls.Add(this.cmbRol);
            this.gunaGroupBox1.Controls.Add(this.txtCorreo);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox1.Controls.Add(this.txtPassword);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.txtDireccion);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.txtLoginName);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.txtDni);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txtApellido);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtNombre);
            this.gunaGroupBox1.Controls.Add(this.pbFotoUsuario);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Aqua;
            this.gunaGroupBox1.Location = new System.Drawing.Point(19, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(788, 294);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "DATOS DE USUARIO";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel9.Location = new System.Drawing.Point(11, 38);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(21, 15);
            this.gunaLabel9.TabIndex = 27;
            this.gunaLabel9.Text = "ID:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdUsuario.Location = new System.Drawing.Point(32, 38);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(13, 15);
            this.lblIdUsuario.TabIndex = 26;
            this.lblIdUsuario.Text = "0";
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.AnimationHoverSpeed = 0.07F;
            this.btnCambiarFoto.AnimationSpeed = 0.03F;
            this.btnCambiarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarFoto.BaseColor = System.Drawing.Color.Gray;
            this.btnCambiarFoto.BorderColor = System.Drawing.Color.Black;
            this.btnCambiarFoto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambiarFoto.FocusedColor = System.Drawing.Color.Empty;
            this.btnCambiarFoto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFoto.ForeColor = System.Drawing.Color.White;
            this.btnCambiarFoto.Image = null;
            this.btnCambiarFoto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCambiarFoto.Location = new System.Drawing.Point(31, 59);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCambiarFoto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCambiarFoto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCambiarFoto.OnHoverImage = null;
            this.btnCambiarFoto.OnPressedColor = System.Drawing.Color.Black;
            this.btnCambiarFoto.Radius = 10;
            this.btnCambiarFoto.Size = new System.Drawing.Size(121, 32);
            this.btnCambiarFoto.TabIndex = 25;
            this.btnCambiarFoto.Text = "Cambiar foto";
            this.btnCambiarFoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCambiarFoto.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = null;
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(655, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Radius = 10;
            this.btnAgregar.Size = new System.Drawing.Size(113, 32);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = null;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(655, 94);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 10;
            this.btnEditar.Size = new System.Drawing.Size(113, 32);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(655, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(113, 32);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AnimationHoverSpeed = 0.07F;
            this.btnLimpiar.AnimationSpeed = 0.03F;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiar.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = null;
            this.btnLimpiar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiar.Location = new System.Drawing.Point(655, 241);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiar.OnHoverImage = null;
            this.btnLimpiar.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiar.Radius = 10;
            this.btnLimpiar.Size = new System.Drawing.Size(113, 32);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AnimationHoverSpeed = 0.07F;
            this.btnReporte.AnimationSpeed = 0.03F;
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReporte.BorderColor = System.Drawing.Color.Black;
            this.btnReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReporte.FocusedColor = System.Drawing.Color.Empty;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = null;
            this.btnReporte.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReporte.Location = new System.Drawing.Point(655, 192);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReporte.OnHoverImage = null;
            this.btnReporte.OnPressedColor = System.Drawing.Color.Black;
            this.btnReporte.Radius = 10;
            this.btnReporte.Size = new System.Drawing.Size(113, 32);
            this.btnReporte.TabIndex = 20;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGroupBox2.BorderSize = 2;
            this.gunaGroupBox2.Controls.Add(this.txtFiltroBuscarUsuario);
            this.gunaGroupBox2.Controls.Add(this.chkApellido);
            this.gunaGroupBox2.Controls.Add(this.chkDni);
            this.gunaGroupBox2.Controls.Add(this.chkNombre);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.Location = new System.Drawing.Point(35, 231);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 10;
            this.gunaGroupBox2.Size = new System.Drawing.Size(587, 52);
            this.gunaGroupBox2.TabIndex = 19;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtFiltroBuscarUsuario
            // 
            this.txtFiltroBuscarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtFiltroBuscarUsuario.BaseColor = System.Drawing.Color.White;
            this.txtFiltroBuscarUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtFiltroBuscarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroBuscarUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFiltroBuscarUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFiltroBuscarUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFiltroBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroBuscarUsuario.Location = new System.Drawing.Point(310, 13);
            this.txtFiltroBuscarUsuario.Name = "txtFiltroBuscarUsuario";
            this.txtFiltroBuscarUsuario.PasswordChar = '\0';
            this.txtFiltroBuscarUsuario.Radius = 10;
            this.txtFiltroBuscarUsuario.Size = new System.Drawing.Size(266, 26);
            this.txtFiltroBuscarUsuario.TabIndex = 20;
            this.txtFiltroBuscarUsuario.TextChanged += new System.EventHandler(this.txtFiltroBuscarUsuario_TextChanged);
            // 
            // chkApellido
            // 
            this.chkApellido.BaseColor = System.Drawing.Color.White;
            this.chkApellido.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkApellido.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkApellido.FillColor = System.Drawing.Color.White;
            this.chkApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkApellido.Location = new System.Drawing.Point(214, 19);
            this.chkApellido.Name = "chkApellido";
            this.chkApellido.Size = new System.Drawing.Size(70, 20);
            this.chkApellido.TabIndex = 2;
            this.chkApellido.Text = "Apellido";
            this.chkApellido.CheckedChanged += new System.EventHandler(this.chkApellido_CheckedChanged);
            // 
            // chkDni
            // 
            this.chkDni.BaseColor = System.Drawing.Color.White;
            this.chkDni.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkDni.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkDni.FillColor = System.Drawing.Color.White;
            this.chkDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDni.Location = new System.Drawing.Point(123, 19);
            this.chkDni.Name = "chkDni";
            this.chkDni.Size = new System.Drawing.Size(49, 20);
            this.chkDni.TabIndex = 1;
            this.chkDni.Text = "DNI";
            this.chkDni.CheckedChanged += new System.EventHandler(this.chkDni_CheckedChanged);
            // 
            // chkNombre
            // 
            this.chkNombre.BaseColor = System.Drawing.Color.White;
            this.chkNombre.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkNombre.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkNombre.FillColor = System.Drawing.Color.White;
            this.chkNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkNombre.Location = new System.Drawing.Point(13, 19);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(70, 20);
            this.chkNombre.TabIndex = 0;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BaseColor = System.Drawing.Color.White;
            this.cmbRol.BorderColor = System.Drawing.Color.Silver;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.Black;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Socio",
            "Bibliotecario"});
            this.cmbRol.Location = new System.Drawing.Point(466, 84);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRol.Radius = 10;
            this.cmbRol.Size = new System.Drawing.Size(145, 26);
            this.cmbRol.TabIndex = 18;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BaseColor = System.Drawing.Color.White;
            this.txtCorreo.BorderColor = System.Drawing.Color.Silver;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(466, 41);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.Radius = 10;
            this.txtCorreo.Size = new System.Drawing.Size(146, 26);
            this.txtCorreo.TabIndex = 14;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel7.Location = new System.Drawing.Point(420, 46);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(46, 15);
            this.gunaLabel7.TabIndex = 15;
            this.gunaLabel7.Text = "Correo:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel8.Location = new System.Drawing.Point(406, 176);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel8.TabIndex = 17;
            this.gunaLabel8.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(466, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 10;
            this.txtPassword.Size = new System.Drawing.Size(146, 26);
            this.txtPassword.TabIndex = 16;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel6.Location = new System.Drawing.Point(167, 173);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.BaseColor = System.Drawing.Color.White;
            this.txtDireccion.BorderColor = System.Drawing.Color.Silver;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.Location = new System.Drawing.Point(228, 170);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.Radius = 10;
            this.txtDireccion.Size = new System.Drawing.Size(146, 26);
            this.txtDireccion.TabIndex = 12;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel5.Location = new System.Drawing.Point(394, 134);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 15);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "LoginName:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginName.BaseColor = System.Drawing.Color.White;
            this.txtLoginName.BorderColor = System.Drawing.Color.Silver;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLoginName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLoginName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginName.Location = new System.Drawing.Point(466, 127);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.Radius = 10;
            this.txtLoginName.Size = new System.Drawing.Size(146, 26);
            this.txtLoginName.TabIndex = 10;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel4.Location = new System.Drawing.Point(439, 88);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(27, 15);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Rol:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel3.Location = new System.Drawing.Point(197, 136);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(30, 15);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Transparent;
            this.txtDni.BaseColor = System.Drawing.Color.White;
            this.txtDni.BorderColor = System.Drawing.Color.Silver;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(228, 129);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.Radius = 10;
            this.txtDni.Size = new System.Drawing.Size(146, 26);
            this.txtDni.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel2.Location = new System.Drawing.Point(173, 95);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(54, 15);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.BaseColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.Silver;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellido.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellido.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(228, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.Radius = 10;
            this.txtApellido.Size = new System.Drawing.Size(146, 26);
            this.txtApellido.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel1.Location = new System.Drawing.Point(173, 53);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 15);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(228, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 10;
            this.txtNombre.Size = new System.Drawing.Size(146, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // pbFotoUsuario
            // 
            this.pbFotoUsuario.BaseColor = System.Drawing.Color.White;
            this.pbFotoUsuario.Image = global::View.Properties.Resources.pngwing_com;
            this.pbFotoUsuario.Location = new System.Drawing.Point(40, 102);
            this.pbFotoUsuario.Name = "pbFotoUsuario";
            this.pbFotoUsuario.Size = new System.Drawing.Size(104, 107);
            this.pbFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUsuario.TabIndex = 0;
            this.pbFotoUsuario.TabStop = false;
            this.pbFotoUsuario.UseTransfarantBackground = false;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.Black;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGroupBox3.BorderSize = 2;
            this.gunaGroupBox3.Controls.Add(this.dgvUsuarios);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGroupBox3.Location = new System.Drawing.Point(16, 322);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Radius = 10;
            this.gunaGroupBox3.Size = new System.Drawing.Size(791, 199);
            this.gunaGroupBox3.TabIndex = 1;
            this.gunaGroupBox3.Text = "LISTA DE USUARIOS";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 30;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Correo,
            this.Direccion,
            this.LoginName,
            this.Password,
            this.Rol,
            this.Foto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(10, 33);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(771, 161);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvUsuarios.ThemeStyle.ReadOnly = false;
            this.dgvUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "IdUsuario";
            this.ID.FillWeight = 137.0558F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 95.36802F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.FillWeight = 95.36802F;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "Dni";
            this.DNI.FillWeight = 95.36802F;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.FillWeight = 95.36802F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.FillWeight = 95.36802F;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.FillWeight = 95.36802F;
            this.LoginName.HeaderText = "LoginName";
            this.LoginName.Name = "LoginName";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.FillWeight = 95.36802F;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "Rol";
            this.Rol.FillWeight = 95.36802F;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Visible = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(819, 533);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarios";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).EndInit();
            this.gunaGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btnReporte;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaTextBox txtFiltroBuscarUsuario;
        private Guna.UI.WinForms.GunaCheckBox chkApellido;
        private Guna.UI.WinForms.GunaCheckBox chkDni;
        private Guna.UI.WinForms.GunaCheckBox chkNombre;
        private Guna.UI.WinForms.GunaComboBox cmbRol;
        private Guna.UI.WinForms.GunaTextBox txtCorreo;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtDireccion;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtLoginName;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtDni;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtApellido;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaCirclePictureBox pbFotoUsuario;
        private Guna.UI.WinForms.GunaButton btnCambiarFoto;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnLimpiar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaDataGridView dgvUsuarios;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel lblIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
    }
}