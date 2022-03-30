using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        frmRecuperarContrasena recuperar = new frmRecuperarContrasena();

        #region Método para mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Cerrar, Minimizar
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Eventos de campos de texto
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Ingrese nombre de usuario";
                txtUser.ForeColor = Color.Black;
                lblUsuario.Visible = false;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Ingrese nombre de usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
                lblUsuario.Visible = true;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Ingrese contraseña")
            {
                txtPass.Text = "";
                txtUser.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Ingrese contraseña";
                txtUser.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        #endregion

        #region Programacion botones
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Validacion campos vacios
            frmMenuPrincipal panPrincipal = new frmMenuPrincipal();
            //Validacion campos nulos
            if (txtPass.Text == "" || txtUser.Text == "" || txtPass.Text == "Ingrese contraseña" || txtUser.Text == "Ingrese nombre de usuario")
            {
                MessageBox.Show("Los campos no deben de estar vacios", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Mostrar pantalla principal (se agrega la sentencia SQL para ver si existen el usuario)
            else
            {
                panPrincipal.Show();
                this.Hide();
            }
            #endregion
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro panRegistro = new frmRegistro();
            panRegistro.Show();
            this.Hide();
        }
        #endregion

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recuperar.Show();
            this.Hide();
        }


        private void pcbBloquer_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            pcbDesbloquear.Visible = true;
            pcbBloquear.Visible = false;
        }

        private void pcbDesbloquear_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            pcbDesbloquear.Visible = false;
            pcbBloquear.Visible = true;
        }
    }
}
