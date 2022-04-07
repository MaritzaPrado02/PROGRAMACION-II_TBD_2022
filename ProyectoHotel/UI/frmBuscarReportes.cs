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
    public partial class frmBuscarReportes : Form
    {
        public frmBuscarReportes()
        {
            InitializeComponent();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "FECHA")
            {
                txtBuscar.Visible = false;
                lblFechaInicio.Visible = true;
                lblFechaFin.Visible = true;
                cmbTipo.Visible = false;
                dtpFechaInicio.Visible = true;
                dtpFechaFin.Visible = true;
                btnBuscar.Location = new Point(621, 38);
                dtpFechaInicio.Location = new Point(335, 49);
                dtpFechaFin.Location = new Point(484, 49);
            }

            if (cmbFiltro.Text == "NOMBRE")
            {
                txtBuscar.Visible = true;
                lblFechaInicio.Visible = false;
                lblFechaFin.Visible = false;
                cmbTipo.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFin.Visible = false;
                btnBuscar.Location = new Point(746, 38);
                txtBuscar.Location = new Point(335, 49);
            }

            if (cmbFiltro.Text == "TIPO")
            {
                cmbTipo.Visible = true;
                cmbTipo.Location = new Point(335, 49);
                txtBuscar.Visible = false;
                lblFechaInicio.Visible = false;
                lblFechaFin.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFin.Visible = false;
                btnBuscar.Location = new Point(524, 38);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (cmbFiltro.Text == "")
            {
                errorProvider1.SetError(cmbFiltro, "Debe seleccionar la especificación de búsqueda.");
                cmbFiltro.Focus();
                return;
            }
            errorProvider1.SetError(cmbFiltro, "");

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

            if (cmbFiltro.Text == "TIPO")
            {
                if (cmbTipo.Text == "")
                {
                    errorProvider1.SetError(cmbTipo, "Debe seleccionar el tipo de reporte.");
                    cmbTipo.Focus();
                    return;
                }
                errorProvider1.SetError(cmbTipo, "");
            }

            if (cmbFiltro.Text == "NOMBRE")
            {
                Regex reNombre = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);
                if (!reNombre.IsMatch(txtBuscar.Text))
                {
                    errorProvider1.SetError(txtBuscar, "Debe colocar un nombre de empleado válido.");
                    txtBuscar.Focus();
                    return;
                }
                errorProvider1.SetError(txtBuscar, "");
            }
            #endregion
        }
    }
}
