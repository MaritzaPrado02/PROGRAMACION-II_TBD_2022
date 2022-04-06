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
    public partial class frmAgregarTipoVehiculo : Form
    {
        public frmAgregarTipoVehiculo()
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
            if (txtTipoVehiculo.Text == "")
            {
                errorProvider1.SetError(txtTipoVehiculo, "Debe seleccionar el área de trabajo.");
                txtTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(txtTipoVehiculo, "");

            if (txtCosto.Text == "")
            {
                errorProvider1.SetError(txtCosto, "Debe ingresar el sueldo que le corresponde al puesto de trabajo.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            Regex reNombre = new Regex(@"[a-zA-ZñÑ\s]", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtTipoVehiculo.Text))
            {
                errorProvider1.SetError(txtTipoVehiculo, "Debe colocar un nombre de tipo vehiculo válido.");
                txtTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(txtTipoVehiculo, "");

            double costo;
            if (!double.TryParse(txtCosto.Text, out costo))
            {
                errorProvider1.SetError(txtCosto, "Debe ingresar solo números en el campo de sueldo.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            if (costo < 0)
            {
                errorProvider1.SetError(txtCosto, "El sueldo tiene que un valor positivo.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            txtTipoVehiculo.Text = "";
            txtCosto.Text = "";
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtTipoVehiculo.Text == "")
            {
                errorProvider1.SetError(txtTipoVehiculo, "Debe seleccionar el área de trabajo.");
                txtTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(txtTipoVehiculo, "");


            #endregion
            limpiarControles();
        }
    }
}
