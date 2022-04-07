using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class frmReservaciones : Form
    {
        public frmReservaciones()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn checkIn = new frmCheckIn();
            checkIn.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut checkOut = new frmCheckOut();
            checkOut.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbEmpleado.Text == "")
            {
                errorProvider1.SetError(cmbEmpleado, "Seleccione el empleado que realiza la reservación.");
                cmbEmpleado.Focus();
                return;
            }
            errorProvider1.SetError(cmbEmpleado, "");

            if (dtpFechaReservacion.Value > dtpFechaIngreso.Value)
            {
                errorProvider1.SetError(dtpFechaIngreso, "La fecha resulta incongruente.");
                dtpFechaIngreso.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaIngreso, "");



            if (dtpFechaSalida.Value < dtpFechaIngreso.Value)
            {
                errorProvider1.SetError(dtpFechaSalida, "La fecha resulta incongruente.");
                dtpFechaSalida.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaSalida, "");

            if (ckbSiAplica.ThreeState == true)
            {
                if (cmbPromocion.Text == "")
                {
                    errorProvider1.SetError(cmbPromocion, "Debe sselecionar la promoción que aplica");
                    cmbPromocion.Focus();
                    return;
                }
                errorProvider1.SetError(cmbPromocion, "");
            }

            Regex soloLetras = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El campo de nombre no debe quedar vacio.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (!soloLetras.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar un nombre válido.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApellidoPaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoPaterno, "El campo de apellido paterno no debe quedar vacio.");
                txtApellidoPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (!soloLetras.IsMatch(txtApellidoPaterno.Text))
            {
                errorProvider1.SetError(txtApellidoPaterno, "Debe ingresar un apellido válido.");
                txtApellidoPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (txtApellidoMaterno.Text != "")
            {
                if (!soloLetras.IsMatch(txtApellidoMaterno.Text))
                {
                    errorProvider1.SetError(txtApellidoMaterno, "Debe ingresar un apellido válido.");
                    txtApellidoMaterno.Focus();
                    return;
                }
                errorProvider1.SetError(txtApellidoMaterno, "");
            }

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "El campo de número de teléfono no debe quedar vacio.");
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
                errorProvider1.SetError(txtEmail, "El campo de correo electrónico no debe quedar vacio.");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

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

            #endregion
            limpiarControles();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbEmpleado.Text == "")
            {
                errorProvider1.SetError(cmbEmpleado, "Seleccione el empleado que realiza la reservación.");
                cmbEmpleado.Focus();
                return;
            }
            errorProvider1.SetError(cmbEmpleado, "");

            if (dtpFechaReservacion.Value > dtpFechaIngreso.Value)
            {
                errorProvider1.SetError(dtpFechaIngreso, "La fecha resulta incongruente.");
                dtpFechaIngreso.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaIngreso, "");

            if (dtpFechaSalida.Value < dtpFechaIngreso.Value)
            {
                errorProvider1.SetError(dtpFechaSalida, "La fecha resulta incongruente.");
                dtpFechaSalida.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaSalida, "");

            if (ckbSiAplica.ThreeState == true)
            {
                if (cmbPromocion.Text == "")
                {
                    errorProvider1.SetError(cmbPromocion, "Debe sselecionar la promoción que aplica");
                    cmbPromocion.Focus();
                    return;
                }
                errorProvider1.SetError(cmbPromocion, "");
            }

            Regex soloLetras = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El campo de nombre no debe quedar vacio.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (!soloLetras.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar un nombre válido.");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApellidoPaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoPaterno, "El campo de apellido paterno no debe quedar vacio.");
                txtApellidoPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (!soloLetras.IsMatch(txtApellidoPaterno.Text))
            {
                errorProvider1.SetError(txtApellidoPaterno, "Debe ingresar un apellido válido.");
                txtApellidoPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (txtApellidoMaterno.Text != "")
            {
                if (!soloLetras.IsMatch(txtApellidoMaterno.Text))
                {
                    errorProvider1.SetError(txtApellidoMaterno, "Debe ingresar un apellido válido.");
                    txtApellidoMaterno.Focus();
                    return;
                }
                errorProvider1.SetError(txtApellidoMaterno, "");
            }

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "El campo de número de teléfono no debe quedar vacio.");
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
                errorProvider1.SetError(txtEmail, "El campo de correo electrónico no debe quedar vacio.");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

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

            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            cmbEmpleado.SelectedIndex = -1;
            dtpFechaReservacion.Value = DateTime.Now;
            dtpFechaIngreso.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cmbHabitacion.SelectedIndex = -1;
            cmbEstacionamiento.SelectedIndex = -1;
            rdbSiEstacionamiento.Checked = false;
            rdbNoEstacionamiento.Checked = false;
        }

        private void rdbSiEstacionamiento_Enter(object sender, EventArgs e)
        {
            lblEspacioEstacionamiento.Visible = true;
            cmbEstacionamiento.Visible = true;
            btnAgregarEstacionamiento.Visible = true;
            dgvEstacionamiento.Visible = true;
        }

        private void rdbNoEstacionamiento_Enter(object sender, EventArgs e)
        {
            lblEspacioEstacionamiento.Visible = false;
            cmbEstacionamiento.Visible = false;
            btnAgregarEstacionamiento.Visible = false;
            dgvEstacionamiento.Visible = false;
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbHabitacion.Text == "")
            {
                errorProvider1.SetError(cmbHabitacion, "Seleccione una habitación.");
                cmbHabitacion.Focus();
                return;
            }
            errorProvider1.SetError(cmbHabitacion, "");
            #endregion
            cmbHabitacion.SelectedIndex = -1;
        }

        private void btnAgregarEstacionamiento_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbEstacionamiento.Text == "")
            {
                errorProvider1.SetError(cmbEstacionamiento, "Seleccione espacio de estacionamiento.");
                cmbEstacionamiento.Focus();
                return;
            }
            errorProvider1.SetError(cmbEstacionamiento, "");
            #endregion
            cmbEstacionamiento.SelectedIndex = -1;
        }
    }
}
