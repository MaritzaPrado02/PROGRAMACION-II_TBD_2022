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
    public partial class frmPromociones : Form
    {
        public frmPromociones()
        {
            InitializeComponent();
        }


        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "FECHA")
            {
                txtBuscar.Visible = false;
                lblFechaInicioBusqueda.Visible = true;
                lblFechaFinBusqueda.Visible = true;
                dtpFechaInicioBusqueda.Visible = true;
                dtpFechaFinBusqueda.Visible = true;
                cmbEstatus.Visible = false;
                btnBuscar.Location = new Point(621, 38);
                dtpFechaInicioBusqueda.Location = new Point(335, 49);
                dtpFechaFinBusqueda.Location = new Point(484, 49);
            }

            if (cmbFiltro.Text == "NOMBRE")
            {
                txtBuscar.Visible = true;
                lblFechaInicioBusqueda.Visible = false;
                lblFechaFinBusqueda.Visible = false;
                dtpFechaInicioBusqueda.Visible = false;
                dtpFechaFinBusqueda.Visible = false;
                cmbEstatus.Visible = false;
                btnBuscar.Location = new Point(746, 38);
                txtBuscar.Location = new Point(335, 49);
            }

            if (cmbFiltro.Text == "ESTATUS")
            {
                cmbEstatus.Visible = true;
                cmbEstatus.Location = new Point(335, 49);
                txtBuscar.Visible = false;
                lblFechaInicioBusqueda.Visible = false;
                lblFechaFinBusqueda.Visible = false;
                dtpFechaInicioBusqueda.Visible = false;
                dtpFechaFinBusqueda.Visible = false;
                btnBuscar.Location = new Point(524, 38);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            #region Validaciones
            Regex reNombre = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
            if (cmbFiltro.Text == "")
            {
                errorProvider1.SetError(cmbFiltro, "Debe seleccionar una especificación de búsqueda.");
                cmbFiltro.Focus();
                return;
            }
            errorProvider1.SetError(cmbFiltro, "");


            if (cmbFiltro.Text == "NOMBRE")
            {
                if (!reNombre.IsMatch(txtBuscar.Text))
                {
                    errorProvider1.SetError(txtBuscar, "Debe colocar un nombre de factura válido.");
                    txtBuscar.Focus();
                    return;
                }
                errorProvider1.SetError(txtBuscar, "");
            }

            if (cmbFiltro.Text == "FECHA")
            {
                if (dtpFechaFin.Value < dtpFechaInicio.Value)
                {
                    errorProvider1.SetError(dtpFechaFin, "Seleccione un lapso válido, ya que la fecha fin es menor que la fecha de inicio.");
                    dtpFechaFin.Focus();
                    return;
                }
                errorProvider1.SetError(dtpFechaFin, "");
            }

            if (cmbFiltro.Text == "ESTATUS")
            {
                if (cmbEstatus.Text == "")
                {
                    errorProvider1.SetError(cmbEstatus, "Seleccione el estatus de factura.");
                    cmbEstatus.Focus();
                    return;
                }
                errorProvider1.SetError(cmbEstatus, "");
            }
            #endregion

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar el nombre de la factura.");
                txtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(txtDescripcion, "");

            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                errorProvider1.SetError(dtpFechaFin, "Seleccione un lapso válido, ya que la fecha fin es menor que la fecha de inicio.");
                dtpFechaFin.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaFin, "");

            if (cmbTipoHabitacion.Text == "")
            {
                errorProvider1.SetError(cmbTipoHabitacion, "Seleccione el tipo de habitación.");
                cmbTipoHabitacion.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoHabitacion, "");

            if (nudNumeroHabitaciones.Text == "")
            {
                errorProvider1.SetError(nudNumeroHabitaciones, "Ingrese la cantidad de habitaciones.");
                nudNumeroHabitaciones.Focus();
                return;
            }
            errorProvider1.SetError(nudNumeroHabitaciones, "");

            if (txtCostoPromocion.Text == "")
            {
                errorProvider1.SetError(txtCostoPromocion, "Ingrese el costo de la promoción.");
                txtCostoPromocion.Focus();
                return;
            }
            errorProvider1.SetError(txtCostoPromocion, "");

            double costoPromocion;
            if (!double.TryParse(txtCostoPromocion.Text, out costoPromocion))
            {
                errorProvider1.SetError(txtCostoPromocion, "Debe ingresar solo números en el campo de costo de promoción.");
                txtCostoPromocion.Focus();
                return;
            }
            errorProvider1.SetError(txtCostoPromocion, "");
            #endregion
            limpiarControles();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar el nombre de la factura.");
                txtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(txtDescripcion, "");

            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                errorProvider1.SetError(dtpFechaFin, "Seleccione un lapso válido, ya que la fecha fin es menor que la fecha de inicio.");
                dtpFechaFin.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaFin, "");

            if (cmbTipoHabitacion.Text == "")
            {
                errorProvider1.SetError(cmbTipoHabitacion, "Seleccione el tipo de habitación.");
                cmbTipoHabitacion.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoHabitacion, "");

            if (nudNumeroHabitaciones.Text == "")
            {
                errorProvider1.SetError(nudNumeroHabitaciones, "Ingrese la cantidad de habitaciones.");
                nudNumeroHabitaciones.Focus();
                return;
            }
            errorProvider1.SetError(nudNumeroHabitaciones, "");

            if (txtCostoPromocion.Text == "")
            {
                errorProvider1.SetError(txtCostoPromocion, "Ingrese el costo de la promoción.");
                txtCostoPromocion.Focus();
                return;
            }
            errorProvider1.SetError(txtCostoPromocion, "");

            double costoPromocion;
            if (!double.TryParse(txtCostoPromocion.Text, out costoPromocion))
            {
                errorProvider1.SetError(txtCostoPromocion, "Debe ingresar solo números en el campo de costo de promoción.");
                txtCostoPromocion.Focus();
                return;
            }
            errorProvider1.SetError(txtCostoPromocion, "");
            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            txtDescripcion.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            cmbTipoHabitacion.SelectedIndex = -1;
            nudNumeroHabitaciones.Value = 1;
            txtCostoPromocion.Text = "";
        }
    }
       
}
