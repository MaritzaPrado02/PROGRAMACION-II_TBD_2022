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
    public partial class frmAgregarPuestoTrabajo : Form
    {
        public frmAgregarPuestoTrabajo()
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

        #region Botones: Cerrar, Minimizar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void btnAgregarAreaTrabajo_Click(object sender, EventArgs e)
        {
            frmAgregarAreaTrabajo areaTrabajo = new frmAgregarAreaTrabajo();
            areaTrabajo.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbAreaTrabajo.Text == "")
            {
                errorProvider1.SetError(cmbAreaTrabajo, "Debe seleccionar el área de trabajo.");
                cmbAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(cmbAreaTrabajo, "");

            if (txtNombrePuesto.Text == "")
            {
                errorProvider1.SetError(txtNombrePuesto, "Debe ingresar el nombre del puesto de trabajo.");
                txtNombrePuesto.Focus();
                return;
            }
            errorProvider1.SetError(txtNombrePuesto, "");

            if (txtSueldo.Text == "")
            {
                errorProvider1.SetError(txtSueldo, "Debe ingresar el sueldo que le corresponde al puesto de trabajo.");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            double sueldo;
            if (!double.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Debe ingresar solo números en el campo de sueldo.");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "El sueldo tiene que un valor positivo.");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");


            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            cmbAreaTrabajo.SelectedIndex = -1;
            txtNombrePuesto.Text = "";
            txtSueldo.Text = "";
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbAreaTrabajo.Text == "")
            {
                errorProvider1.SetError(cmbAreaTrabajo, "Debe seleccionar el área de trabajo.");
                cmbAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(cmbAreaTrabajo, "");

            if (txtNombrePuesto.Text == "")
            {
                errorProvider1.SetError(txtNombrePuesto, "Debe ingresar el nombre del puesto de trabajo.");
                txtNombrePuesto.Focus();
                return;
            }
            errorProvider1.SetError(txtNombrePuesto, "");

            if (txtSueldo.Text == "")
            {
                errorProvider1.SetError(txtSueldo, "Debe ingresar el sueldo que le corresponde al puesto de trabajo.");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            double sueldo;
            if (!double.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Debe ingresar solo números en el campo de sueldo.");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "El sueldo tiene que un valor positivo.");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            #endregion
            limpiarControles();
        }
    }
}
