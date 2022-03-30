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
    public partial class frmRecuperarContrasena : Form
    {
        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }
        frmCambiarContrasena cambiarContrasena = new frmCambiarContrasena();

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

        #region Botones: Cancelar, Validar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar el proceso?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtTelefono.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Los campos no deben de estar vacios", "Error Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Mostrar pantalla principal (se agrega la sentencia SQL para ver si existen el usuario)
            else
            {
                cambiarContrasena.Show();
                this.Hide();
            }
        }
        #endregion

        #region Botones: Minimizar, Cerrrar
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
    }
}
