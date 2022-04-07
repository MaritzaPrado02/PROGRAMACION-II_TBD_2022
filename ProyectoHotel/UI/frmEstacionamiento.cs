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
    public partial class frmEstacionamiento : Form
    {
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void btnAgregarTipoVehiculo_Click(object sender, EventArgs e)
        {
            frmAgregarTipoVehiculo tipoVehiculo = new frmAgregarTipoVehiculo();
            tipoVehiculo.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbFiltroEstatus.Text == "")
            {
                errorProvider1.SetError(cmbFiltroEstatus, "Seleccione el estatus de estacionamiento.");
                cmbFiltroEstatus.Focus();
                return;
            }
            errorProvider1.SetError(cmbFiltroEstatus, "");

            if (cmbFiltroTipoVehiculo.Text == "")
            {
                errorProvider1.SetError(cmbFiltroTipoVehiculo, "Selecione el tipo de vehiculo que desea buscar.");
                cmbFiltroTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(cmbFiltroTipoVehiculo, "");

            #endregion
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbEstatus.Text == "")
            {
                errorProvider1.SetError(cmbEstatus, "Seleccione el estatus de estacionamiento.");
                cmbEstatus.Focus();
                return;
            }
            errorProvider1.SetError(cmbEstatus, "");

            if (cmbTipoVehiculo.Text == "")
            {
                errorProvider1.SetError(cmbTipoVehiculo, "Selecione el tipo de vehiculo.");
                cmbTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoVehiculo, "");
            #endregion
            limpiarControles();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (cmbEstatus.Text == "")
            {
                errorProvider1.SetError(cmbEstatus, "Seleccione el estatus de estacionamiento.");
                cmbEstatus.Focus();
                return;
            }
            errorProvider1.SetError(cmbEstatus, "");

            if (cmbTipoVehiculo.Text == "")
            {
                errorProvider1.SetError(cmbTipoVehiculo, "Selecione el tipo de vehiculo.");
                cmbTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoVehiculo, "");
            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            cmbTipoVehiculo.SelectedIndex = -1;
            cmbEstatus.SelectedIndex = -1;
        }
    }
}
