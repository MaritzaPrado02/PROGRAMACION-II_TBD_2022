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
    public partial class frmBuscarReservaciones : Form
    {
        public frmBuscarReservaciones()
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
                dtpFechaInicio.Visible = true;
                dtpFechaFin.Visible = true;
                btnBuscar.Location = new Point(621, 38);
                dtpFechaInicio.Location = new Point(335, 49);
                dtpFechaFin.Location = new Point(484, 49);
            }

            if (cmbFiltro.Text == "CLIENTE" || cmbFiltro.Text == "FOLIO" || cmbFiltro.Text == "EMPLEADO")
            {
                txtBuscar.Visible = true;
                lblFechaInicio.Visible = false;
                lblFechaFin.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFin.Visible = false;
                btnBuscar.Location = new Point(746, 38);
                txtBuscar.Location = new Point(335, 49);
            }
        }
    }
}
