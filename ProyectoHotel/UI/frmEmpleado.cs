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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregarAreaTrabajo_Click(object sender, EventArgs e)
        {
            frmAgregarAreaTrabajo areaTrabajo = new frmAgregarAreaTrabajo();
            areaTrabajo.Show();
        }

        private void btnPuestoTrabajo_Click(object sender, EventArgs e)
        {
            frmAgregarPuestoTrabajo puestoTrabajo = new frmAgregarPuestoTrabajo();
            puestoTrabajo.Show();
        }
    }
}
