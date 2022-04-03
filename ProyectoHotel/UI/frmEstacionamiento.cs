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
    }
}
