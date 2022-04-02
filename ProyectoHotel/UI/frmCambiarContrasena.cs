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
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        #region Método para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLogoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones: Cancelar, Guardar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar el proceso?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text == "" || txtConfirmarContrasena.Text == "")
            {
                MessageBox.Show("Los campos no deben de estar vacios", "Error Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Mostrar pantalla principal (se agrega la sentencia SQL para ver si existen el usuario)
            else if (txtNuevaContrasena.Text == txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Nueva contraseña guardada");
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La confirmación de la nueva contraseña no coincide", "Error Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botones Minimizar, Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar el proceso?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }
        #endregion

        #region Iconos de bloquear y desbloquear
        private void btnBloquearNC_Click(object sender, EventArgs e)
        {
            txtNuevaContrasena.UseSystemPasswordChar = false;
            btnDesbloquearNC.Visible = true;
            btnBloquearNC.Visible = false;
        }

        private void btnDesbloquearNC_Click(object sender, EventArgs e)
        {
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            btnDesbloquearNC.Visible = false;
            btnBloquearNC.Visible = true;
        }

        private void btnDesbloquearCC_Click(object sender, EventArgs e)
        {
         

            txtConfirmarContrasena.UseSystemPasswordChar = true;
            btnDesbloquearCC.Visible = false;
            btnBloquerCC.Visible = true;
        }
  
        private void btnBloquerCC_Click(object sender, EventArgs e)
        {
            txtNuevaContrasena.UseSystemPasswordChar = false;
            btnDesbloquearNC.Visible = true;
            btnBloquearNC.Visible = false;
        }
        #endregion

        #region Eventos de cuadros de texto: Nueva contraseña y confirmar contraseña
        private void txtNuevaContrasena_Enter(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text == "Ingrese nueva contraseña")
            {
                txtNuevaContrasena.Text = "";
                txtNuevaContrasena.ForeColor = Color.Black;
                txtNuevaContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtNuevaContrasena_Leave(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text == "")
            {
                txtNuevaContrasena.Text = "Ingrese nueva contraseña";
                txtNuevaContrasena.ForeColor = Color.Black;
                txtNuevaContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarContrasena_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContrasena.Text == "Confirme contraseña")
            {
                txtConfirmarContrasena.Text = "";
                txtConfirmarContrasena.ForeColor = Color.Black;
                txtConfirmarContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmarContrasena_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContrasena.Text == "")
            {
                txtConfirmarContrasena.Text = "Ingrese contraseña";
                txtConfirmarContrasena.ForeColor = Color.Black;
                txtConfirmarContrasena.UseSystemPasswordChar = false;
            }
        }

        #endregion
    }
}
