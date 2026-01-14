using Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormPrincipal : Form
    {
        private IconButton botonActual;
        private Panel bordeIzquierdoBoton;
        private Form formularioActualHijo;

        public FormPrincipal()
        {
            InitializeComponent();
            bordeIzquierdoBoton = new Panel();
            bordeIzquierdoBoton.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeIzquierdoBoton);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            cargarUsuarioActual();
            if (UsuarioCache.Rol == "Administrador")
            {
                this.habilitarBotonesFormAdmin();
            }
            else
            {
                if (UsuarioCache.Rol == "Bibliotecario")
                {
                    this.habilitarBotonesFormBibliotecario();
                }
                else
                {
                    this.habilitarBotonesFormSocio();
                }
            }
        }

        private void ocultarBotones()
        {
            this.btnIconPrestamos.Visible = false;
            this.btnIconCategorias.Visible = false;
            this.btnIconAutores.Visible = false;
            this.btnIconLibros.Visible = false;
            this.btnIconUsuarios.Visible = false;
            this.btnIconSocio.Visible = false;
        }
        private void habilitarBotonesFormAdmin()
        {
            this.btnIconPrestamos.Visible = true;
            this.btnIconCategorias.Visible = true;
            this.btnIconAutores.Visible = true;
            this.btnIconLibros.Visible = true;
            this.btnIconUsuarios.Visible = true;
            this.btnIconSocio.Visible = false;
        }

        private void habilitarBotonesFormBibliotecario()
        {
            this.btnIconPrestamos.Visible = true;
            this.btnIconCategorias.Visible = true;
            this.btnIconAutores.Visible = true;
            this.btnIconLibros.Visible = true;
            this.btnIconUsuarios.Visible = false;
            this.btnIconSocio.Visible = false;
        }

        private void habilitarBotonesFormSocio()
        {
            this.btnIconPrestamos.Visible = false;
            this.btnIconCategorias.Visible = false;
            this.btnIconAutores.Visible = false;
            this.btnIconLibros.Visible = false;
            this.btnIconUsuarios.Visible = false;
            this.btnIconSocio.Visible = true;
        }
        private void cargarUsuarioActual()
        {
            this.lblUsuarioActual.Text = UsuarioCache.LoginName;
            this.lblRolUsuarioActual.Text = UsuarioCache.Rol;
            this.pcbFotoUsuarioActual.Image = bytesToImage(UsuarioCache.Foto);
        }

        //Convierte Imagen a byte[]
        private byte[] imageToBytes(PictureBox pbxFoto)
        {
            MemoryStream ms = new System.IO.MemoryStream();
            pbxFoto.Image.Save(ms, ImageFormat.Png);
            byte[] imagenByte = ms.ToArray();
            return imagenByte;
        }
        //Convierte Byte a Imagen
        public Image bytesToImage(byte[] imagenByte)
        {
            MemoryStream ms = new MemoryStream(imagenByte);
            Image foto = Image.FromStream(ms);

            return foto;
        }

        //Estucts para almacenar una cantidad de colores rgb y luego pode rusarlos
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(198, 211, 11);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(100, 236, 58);

        }

        //metodo que nos dira si esta activo el boton
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBoton();
                this.botonActual = (IconButton)senderBtn;
                this.botonActual.BackColor = Color.FromArgb(37, 36, 81);
                this.botonActual.ForeColor = color;
                this.botonActual.TextAlign = ContentAlignment.MiddleCenter;
                this.botonActual.IconColor = color;
                this.botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                this.botonActual.ImageAlign = ContentAlignment.MiddleRight;
                this.bordeIzquierdoBoton.BackColor = color;
                this.bordeIzquierdoBoton.Location = new Point(0, botonActual.Location.Y);
                this.bordeIzquierdoBoton.Visible = true;
                this.bordeIzquierdoBoton.BringToFront();

                this.iconActualHijoDeFormulario.IconChar = botonActual.IconChar;
                this.iconActualHijoDeFormulario.IconColor = color;
            }
        }

        private void DisableBoton()
        {
            if (botonActual != null)
            {
                this.botonActual.BackColor = Color.FromArgb(0, 0, 64);
                this.botonActual.ForeColor = Color.White;
                this.botonActual.TextAlign = ContentAlignment.MiddleLeft;
                this.botonActual.IconColor = Color.White;
                this.botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                this.botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Metodo para colocar los formularios en el panel central
        private void AbrirFormularioHijo(Form formHijo)
        {
            if (formularioActualHijo != null)
            {
                formularioActualHijo.Close();
            }
            formularioActualHijo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            panelCentral.Controls.Add(formHijo);
            panelCentral.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            this.lblTituloDeFormularioHijo.Text = formHijo.Text;
        }

        private void btnIconPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnIconPrestamos_Click(object sender, EventArgs e)
        {

            ActivarBoton(sender, RGBColors.color2);
            AbrirFormularioHijo(new PrestamosDB());
        }

        private void btnIconCategorias_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            AbrirFormularioHijo(new FormCategoriasDB());
        }

        private void btnIconLibros_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new FormLibroDB());
        }

        private void btnIconUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            AbrirFormularioHijo(new FormUsuarios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDatosdeUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIconAutores_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
            AbrirFormularioHijo(new FormAutoresDB());
        }

        private void btnIconSocio_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new FormPrestamosRealizadosXsocio());
        }
    }
}
