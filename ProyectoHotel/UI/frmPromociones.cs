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
    }
}
