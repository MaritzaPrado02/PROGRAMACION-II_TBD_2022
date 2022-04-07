using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            #region Validaciones
          
            if (cmbIDEmpleado.Text == "")
            {
                errorProvider1.SetError(cmbIDEmpleado, "Seleccione el ID del empleado que facturó");
                cmbIDEmpleado.Focus();
                return;
            }
            errorProvider1.SetError(cmbIDEmpleado, "");

            if (cmbReservacion.Text == "")
            {
                errorProvider1.SetError(cmbReservacion, "Selecione la reservación a pagar.");
                cmbReservacion.Focus();
                return;
            }
            errorProvider1.SetError(cmbReservacion, "");

            if (rdbSiEnvio.Checked == false && rdbNoEnvio.Checked == false)
            {
                errorProvider1.SetError(lblEnvio, "Seleccione la opción de envio.");
                lblEnvio.Focus();
                return;
            }
            errorProvider1.SetError(lblEnvio, "");

            if (cmbTipoPago.Text == "")
            {
                errorProvider1.SetError(cmbTipoPago, "Selecione el tipo de pago.");
                cmbTipoPago.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoPago, "");
            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            cmbIDEmpleado.SelectedIndex = -1;
            cmbReservacion.SelectedIndex = -1;
            rdbSiEnvio.Checked = false;
            rdbNoEnvio.Checked = false;
            cmbTipoPago.SelectedIndex = -1;
        }
    }
}
