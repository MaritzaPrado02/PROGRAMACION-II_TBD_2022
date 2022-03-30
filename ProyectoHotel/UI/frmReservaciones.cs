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
    public partial class frmReservaciones : Form
    {
        public frmReservaciones()
        {
            InitializeComponent();
        }
       
        private void pcbBusqueda_Click(object sender, EventArgs e)
        {
            frmBuscarCliente buscarCliente = new frmBuscarCliente();
            buscarCliente.Show();
        }
    }
}
