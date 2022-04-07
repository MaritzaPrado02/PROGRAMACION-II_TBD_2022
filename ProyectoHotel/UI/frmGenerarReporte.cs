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
    public partial class frmGenerarReporte : Form
    {
        public frmGenerarReporte()
        {
            InitializeComponent();
        }

        private void cmbEstatusReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEspecificar.Visible = true;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "Ingrese nombre del reporte.");
               txtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(txtDescripcion, "");

            if (cmbEmpleado.Text == "")
            {
                errorProvider1.SetError(cmbEmpleado, "Seleccione el empleado que realiza el reporte.");
                cmbEmpleado.Focus();
                return;
            }
            errorProvider1.SetError(cmbEmpleado, "");

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                errorProvider1.SetError(dtpFechaHasta, "La fecha resulta incongruente.");
                dtpFechaHasta.Focus();
                return;
            }
            errorProvider1.SetError(dtpFechaHasta, "");

            if (cmbEstatusReporte.Text == "")
            {
                errorProvider1.SetError(cmbEstatusReporte, "Seleccione el filtro de contenido que contendrá el reporte.");
                cmbEstatusReporte.Focus();
                return;
            }
            errorProvider1.SetError(cmbEstatusReporte, "");

            if (cmbEspecificar.Text == "")
            {
                errorProvider1.SetError(cmbEspecificar, "Especifique.");
                cmbEspecificar.Focus();
                return;
            }
            errorProvider1.SetError(cmbEspecificar, "");
            #endregion
            limpiarControles();
        }

        public void limpiarControles()
        {
            txtDescripcion.Text = "";
            cmbEmpleado.Text = "";
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            cmbEstatusReporte.SelectedIndex = -1;
            cmbEspecificar.SelectedIndex = -1;
        }
    }
}
