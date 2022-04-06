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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
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

            if (cmbFiltro.Text == "NOMBRE")
            {
                Regex soloLetras = new Regex(@"[a-zA-Z -']+$", RegexOptions.Compiled);

                if (!soloLetras.IsMatch(txtBuscar.Text))
                {
                    errorProvider1.SetError(txtBuscar, "Debe ingresar un nombre válido.");
                    txtBuscar.Focus();
                    return;
                }
                errorProvider1.SetError(txtBuscar, "");
            }
           else if (cmbFiltro.Text == "ID")
            {
                Regex soloNumeros = new Regex(@"^[0-9]+$", RegexOptions.Compiled);

                if (!soloNumeros.IsMatch(txtBuscar.Text))
                {
                    errorProvider1.SetError(txtBuscar, "Solo puede ingresar un valor númerico.");
                    txtBuscar.Focus();
                    return;
                }
                errorProvider1.SetError(txtBuscar, "");
            }
            #endregion
        }
    }
}
