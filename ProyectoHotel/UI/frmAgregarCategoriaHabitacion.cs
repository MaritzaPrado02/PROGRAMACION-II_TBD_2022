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
    public partial class frmAgregarCategoriaHabitacion : Form
    {
        public frmAgregarCategoriaHabitacion()
        {
            InitializeComponent();
        }

        #region Método para mover el formulario

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

        #region Botones: Minimizar, cerrar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void btnAgregarComplemento_Click(object sender, EventArgs e)
        {
            frmAgregarComplemento agregarComplemento = new frmAgregarComplemento();
            agregarComplemento.Show();
        }

        private void btnGuardarComplemento_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbComplementos.Text == "")
            {
                errorProvider1.SetError(cmbComplementos, "Debe seleccionar el complemento que desea añadir.");
                cmbComplementos.Focus();
                return;
            }
            errorProvider1.SetError(cmbComplementos, "");

            if (nudCantidadComplemento.Text == "")
            {
                errorProvider1.SetError(nudCantidadComplemento, "Debe especificar la cantidad de complementos.");
                nudCantidadComplemento.Focus();
                return;
            }
            errorProvider1.SetError(nudCantidadComplemento, "");


            #endregion
            cmbComplementos.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtNombreCategoria.Text == "")
            {
                errorProvider1.SetError(txtNombreCategoria, "Ingrese el nombre de la categoría.");
                txtNombreCategoria.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreCategoria, "");

            Regex reNombre = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreCategoria.Text))
            {
                errorProvider1.SetError(txtNombreCategoria, "Debe colocar un nombre de categoría válido.");
                txtNombreCategoria.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreCategoria, "");

            if (txtCosto.Text == "")
            {
                errorProvider1.SetError(txtCosto, "Debe ingresar el costo de las habitaciones de esa categoría.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            double costo;
            if (!double.TryParse(txtCosto.Text, out costo))
            {
                errorProvider1.SetError(txtCosto, "Debe ingresar solo números en el campo de costo.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            if (costo < 0)
            {
                errorProvider1.SetError(txtCosto, "Solo puede ingresar números positivos");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");
            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            txtNombreCategoria.Text = "";
            txtCosto.Text = "";
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtNombreCategoria.Text == "")
            {
                errorProvider1.SetError(txtNombreCategoria, "Ingrese el nombre de la categoría.");
                txtNombreCategoria.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreCategoria, "");

            if (txtCosto.Text == "")
            {
                errorProvider1.SetError(txtCosto, "Debe ingresar el costo de las habitaciones de esa categoría.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            double costo;
            if (!double.TryParse(txtCosto.Text, out costo))
            {
                errorProvider1.SetError(txtCosto, "Debe ingresar solo números en el campo de costo.");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");

            if (costo < 0)
            {
                errorProvider1.SetError(txtCosto, "Solo puede ingresar números positivos");
                txtCosto.Focus();
                return;
            }
            errorProvider1.SetError(txtCosto, "");
            #endregion
            limpiarControles();
        }
    }
}
