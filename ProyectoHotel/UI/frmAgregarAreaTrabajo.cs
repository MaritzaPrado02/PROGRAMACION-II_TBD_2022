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
using BUSINESS;

namespace UI
{
    public partial class frmAgregarAreaTrabajo : Form
    {
        public frmAgregarAreaTrabajo()
        {
            InitializeComponent();
        }

        #region Método para arrastrar el formulario
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtAreaTrabajo.Text == "")
            {
                errorProvider1.SetError(txtAreaTrabajo, "Debe ingresar el nombre del área de trabajo.");
                txtAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(txtAreaTrabajo, "");

            Regex reNombre = new Regex (@"[a-zA-ZñÑ\s]", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtAreaTrabajo.Text))
            {
                errorProvider1.SetError(txtAreaTrabajo, "Debe colocar un nombre de área válido.");
                txtAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(txtAreaTrabajo, "");
            
            


            #endregion
            limpiarControles();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtAreaTrabajo.Text == "")
            {
                errorProvider1.SetError(txtAreaTrabajo, "Este campo no debe quedar vacio.");
                txtAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(txtAreaTrabajo, "");

            Regex reNombre = new Regex(@"[a-zA-ZñÑ\s]", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtAreaTrabajo.Text))
            {
                errorProvider1.SetError(txtAreaTrabajo, "Debe colocar un nombre de área válido.");
                txtAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(txtAreaTrabajo, "");

            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            txtAreaTrabajo.Text = "";
        }

        #region Validacion soloLetras
        //Copiar
        /*Regex reSoloLetras = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
           if (!reSoloLetras.IsMatch(txtAreaTrabajo.Text))
           {
               errorProvider1.SetError(txtAreaTrabajo, "Debe colocar un nombre de área válido.");
               txtAreaTrabajo.Focus();
               return;
           }
            errorProvider1.SetError(txtAreaTrabajo, "");*/
        #endregion

    }
}
