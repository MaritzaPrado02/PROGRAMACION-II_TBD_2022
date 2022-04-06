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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
            dgvClientes.Size = new Size(884, 384);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvClientes.Size = new Size(480, 384);
            grbCliente.Visible = true;
            btnGuardarCambios.Visible = true;
            btnEditar.Visible = false;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
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

            btnEditar.Visible = true;
            grbCliente.Visible = false;
            btnGuardarCambios.Visible = false;
            dgvClientes.Size = new Size(884, 384);

            limpiarControles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbFiltro.Text == "")
            {
                errorProvider1.SetError(cmbFiltro, "Debe seleccionar lo que desea buscar.");
                cmbFiltro.Focus();
                return;
            }
            errorProvider1.SetError(cmbFiltro, "");

            if (txtBuscar.Text == "")
            {
                errorProvider1.SetError(txtBuscar, "Ingrese lo que desee buscar.");
                txtBuscar.Focus();
                return;
            }
            errorProvider1.SetError(txtBuscar, "");
            #endregion
        }

        public void limpiarControles()
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";       
        }
    }
}
