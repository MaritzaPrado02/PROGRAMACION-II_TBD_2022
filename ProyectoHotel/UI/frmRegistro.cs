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
//PENDIENTE VALIACIÓN RFC

namespace UI
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        #region Cerrar, Minimizar formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Método para mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pnlLogoRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            #region Validaciones
            Regex soloLetras = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            Regex reNombre = new Regex (@"[a-zA-ZñÑ\s]", RegexOptions.Compiled);

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre del nuevo empleado.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");
    
            if (!soloLetras.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe colocar un nombre de área válido.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApellidoPaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoPaterno, "Debe ingresar el apellido paterno.");
                txtApellidoPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (!soloLetras.IsMatch(txtApellidoPaterno.Text))
            {
                errorProvider1.SetError(txtApellidoPaterno, "Debe colocar un nombre de área válido.");
                txtApellidoPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (txtRFC.Text == "")
            {
                errorProvider1.SetError(txtRFC, "Debe ingresar el RFC del empleado.");
                txtRFC.Focus();
                return;
            }
            errorProvider1.SetError(txtRFC, "");

            //EXPRESION REGULAR 
            //
            Regex reRFC = new Regex(@"^(([ÑA - Z | ña - z | &]{ 3 } |[AZ | az]{ 4})\d{ 2} ((0[1 - 9] | 1[012])(0[1 - 9] | 1\d |
                2[0 - 8]) | (0[13456789] | 1[012])(29 | 30) | (0[13578] | 1[02])31) (\w{ 2})([A | a | 0 - 9]{ 1}))$|
                ^(([ÑA - Z | ña - z | &]{ 3}|[AZ | az]{ 4} )([02468][048] |[13579][26])0229)(\w{ 2})([A | a | 0 - 9]{ 1})$", RegexOptions.Compiled);
            if (!reRFC.IsMatch(txtRFC.Text))
            {
                errorProvider1.SetError(txtRFC, "Debe colocar RFC válido.");
                txtRFC.Focus();
                return;
            }
            errorProvider1.SetError(txtRFC, "");


            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar el telefono del empleado");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Debe colocar un número de telefono válido.");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre del nuevo empleado.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            Regex reEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                   + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                   + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                   + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                   + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!reEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Debe ingresar una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            if (cmbAreaTrabajo.Text == "")
            {
                errorProvider1.SetError(cmbAreaTrabajo, "Seleccione el área de trabajo.");
                cmbAreaTrabajo.Focus();
                return;
            }
            errorProvider1.SetError(cmbAreaTrabajo, "");

            if (cmbPuesto.Text == "")
            {
                errorProvider1.SetError(cmbPuesto, "Seleccione el puesto.");
                cmbPuesto.Focus();
                return;
            }
            errorProvider1.SetError(cmbPuesto, "");

            if (txtRegistrarUsuario.Text == "")
            {
                errorProvider1.SetError(txtRegistrarUsuario, "Debe ingresar el nombre de usuario");
                txtRegistrarUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtRegistrarUsuario, "");

            if (txtContrasena.Text == "")
            {
                errorProvider1.SetError(txtContrasena, "Debe ingresar el nombre del nuevo empleado.");
                txtContrasena.Focus();
                return;
            }
            errorProvider1.SetError(txtContrasena, "");

            if (txtConfirmarContrasena.Text == "")
            {
                errorProvider1.SetError(txtConfirmarContrasena, "Debe confirmar la contraseña.");
                txtConfirmarContrasena.Focus();
                return;
            }
            errorProvider1.SetError(txtConfirmarContrasena, "");

            if (txtContrasena.Text == txtConfirmarContrasena.Text)
            {
                errorProvider1.SetError(txtConfirmarContrasena, "No coincide con la contraseña definida.");
                txtConfirmarContrasena.Focus();
                return;
            }
            errorProvider1.SetError(txtConfirmarContrasena, "");


            if (cmbEstado.Text == "")
            {
                errorProvider1.SetError(cmbEstado, "Debe seleccionar el estado.");
                cmbEstado.Focus();
                return;
            }
            errorProvider1.SetError(cmbEstado, "");

            if (cmbMunicipio.Text == "")
            {
                errorProvider1.SetError(cmbMunicipio, "Debe seleccionar el municipio.");
                cmbMunicipio.Focus();
                return;
            }
            errorProvider1.SetError(cmbMunicipio, "");

            if (txtCP.Text == "")
            {
                errorProvider1.SetError(txtCP, "Debe seleccionar el estado.");
                txtCP.Focus();
                return;
            }
            errorProvider1.SetError(txtCP, "");

            Regex reCP = new Regex("[0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reCP.IsMatch(txtCP.Text))
            {
                errorProvider1.SetError(txtCP, "Debe colocar un CP válido.");
               txtCP.Focus();
                return;
            }
            errorProvider1.SetError(txtCP, "");

            if (txtCalle.Text == "")
            {
                errorProvider1.SetError(txtCalle, "Debe seleccionar el estado.");
                txtCalle.Focus();
                return;
            }
            errorProvider1.SetError(txtCalle, "");

            if (txtColonia.Text == "")
            {
                errorProvider1.SetError(txtColonia, "Debe seleccionar el estado.");
                txtColonia.Focus();
                return;
            }
            errorProvider1.SetError(txtColonia, "");

             if (!soloLetras.IsMatch(txtCalle.Text))
            {
                errorProvider1.SetError(txtCalle, "Debe colocar un nombre de calle válido.");
                txtCalle.Focus();
                return;
            }
            errorProvider1.SetError(txtCalle, "");

            if (txtNumero.Text == "")
            {
                errorProvider1.SetError(txtNumero, "Debe seleccionar el estado.");
                txtNumero.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero, "");
            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtRFC.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cmbAreaTrabajo.SelectedIndex = -1;
            cmbPuesto.SelectionLength = -1;
            txtRegistrarUsuario.Text = "";
            txtContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
            cmbEstado.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;
            txtCP.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtNumero.Text = "";
        }

    }
}
