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
    public partial class frmRegistrarHabitacion : Form
    {
        public frmRegistrarHabitacion()
        {
            InitializeComponent();
        }

        private void btnAgregarCatHabitacion_Click(object sender, EventArgs e)
        {
            frmAgregarCategoriaHabitacion agregarCategoria = new frmAgregarCategoriaHabitacion();
            agregarCategoria.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*ESTATUS
            CLAVE
            CUPO
            CATEGORÍA*/

            #region Validaciones

            #endregion
        }
    }
}
