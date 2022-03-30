using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace UI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            ocultarSubmenu();
        }
        frmLogin Login = new frmLogin();

        #region Método para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Cerrar, Minimizar, Maximizar y Restaurar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Cerrar sesión, calculadora
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Login.Show();
            }
        }
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }
        #endregion

        #region Evento para mostrar fecha y hora en tiempo real
        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        #endregion

        #region Método para abrir formularios hijos y submenús
        private Form activarForm = null;

        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            contenedorPantallasHijas.Controls.Add(formularioHijo);
            contenedorPantallasHijas.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ocultarSubmenu()
        {
            subMenuHabitaciones.Visible = false;
            subMenuReservaciones.Visible = false;
            subMenuPromociones.Visible = false;
            subMenuFacturas.Visible = false;
            subMenuClientes.Visible = false;
            subMenuEmpleados.Visible = false;
            subMenuEstacionamiento.Visible = false;
        }
        #endregion

        #region Mostrar submenús

        #endregion

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuHabitaciones);
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuReservaciones);
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuPromociones);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuClientes);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuFacturas);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuEmpleados);
        }

        private void btnEstacionamiento_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuEstacionamiento);
        }
    }
}
