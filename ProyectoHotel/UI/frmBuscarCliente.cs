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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
            dgvClientes.Size = new Size(884, 384);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvClientes.Size = new Size(480, 384);
            grbCliente.Visible = true;
            btnGuardarCambios.Visible = true;
            btnEditar.Visible = false;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = true;
            grbCliente.Visible = false;
            btnGuardarCambios.Visible = false;
            dgvClientes.Size = new Size(884, 384);
        }
    }
}
