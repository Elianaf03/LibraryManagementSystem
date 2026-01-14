using Controller;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormLoginDB : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public FormLoginDB()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (txtUsuario.Text != "USUARIO" && txtUsuario.Text.Length > 2)
                    {
                        if (txtPassword.Text != "PASSWORD")
                        {
                            UsuarioController login = new UsuarioController();

                            bool validarLogin = login.Login(this.txtUsuario.Text, this.txtPassword.Text);
                        if (validarLogin)
                        {
                            FormPrincipal formLibroDB = new FormPrincipal();
                            MessageBox.Show("Bienvenido al sistema de Biblioteca " + UsuarioCache.LoginName );
                            formLibroDB.Show();
                            
                            formLibroDB.FormClosed += Logout;
                            this.Hide();
                            }
                            else
                            {
                                lblMsjError.Text = "USUARIO O PASSWORD INCORRECTOS";
                                lblMsjError.Visible = true;
                            }
                        }
                        else
                        {
                            lblMsjError.Text = "Debe ingresar Contraseña";
                            lblMsjError.Visible = true;
                        }
                    }
                    else
                    {
                        lblMsjError.Text = "Debe ingresar Usuario y Contraseña";
                        lblMsjError.Visible = true;
                    }
                }
                catch (Exception er)
                {

                    MessageBox.Show("Error " + er.Message, "Atencion",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.txtUsuario.Text = "USUARIO";
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.UseSystemPasswordChar = false;
            this.lblMsjError.Visible = false;
            this.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            this.lblMsjError.Visible = false;
            if (this.txtUsuario.Text=="USUARIO")
            {
                this.txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            this.lblMsjError.Visible = false;
            if (this.txtUsuario.Text == "")
            {
                this.txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            this.lblMsjError.Visible = false;
            if (this.txtPassword.UseSystemPasswordChar)
            {
                this.txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            this.lblMsjError.Visible = false;
            if (this.txtPassword.Text=="")
            {
                this.txtPassword.Text = "CONTRASEÑA";
            }
        }

        private void chbVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVerContraseña.Checked==true && txtPassword.Text!="CONTRASEÑA")
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        // agregamos las librerias necesarias para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsj, int wparm, int lparm);

        private void FormLoginDB_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
