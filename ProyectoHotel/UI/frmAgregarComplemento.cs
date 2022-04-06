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
using System.Text.RegularExpressions;

namespace UI
{
    public partial class frmAgregarComplemento : Form
    {
        public frmAgregarComplemento()
        {
            InitializeComponent();
        }

        #region Método para mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones: Minimizar, Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtNombreComplemento.Text == "")
            {
                errorProvider1.SetError(txtNombreComplemento, "Debe ingresar el nombre del áre de trabajo.");
                txtNombreComplemento.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreComplemento, "");

            Regex reNombre = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreComplemento.Text))
            {
                errorProvider1.SetError(txtNombreComplemento, "Debe colocar un nombre de complemento válido.");
                txtNombreComplemento.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreComplemento, "");

            #endregion
            limpiarControles();

        }

        public void limpiarControles()
        {
            txtNombreComplemento.Text = "";
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtNombreComplemento.Text == "")
            {
                errorProvider1.SetError(txtNombreComplemento, "Debe ingresar el nombre del áre de trabajo.");
                txtNombreComplemento.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreComplemento, "");

            Regex reNombre = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreComplemento.Text))
            {
                errorProvider1.SetError(txtNombreComplemento, "Debe colocar un nombre de complemento válido.");
                txtNombreComplemento.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreComplemento, "");

            #endregion
            limpiarControles();
        }
    }
}
