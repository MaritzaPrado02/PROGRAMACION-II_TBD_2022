
namespace UI
{
    partial class frmReservaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFechas = new System.Windows.Forms.Panel();
            this.lblFechaReservacion = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pcbBusqueda = new System.Windows.Forms.PictureBox();
            this.txtNombre = new AltoControls.AltoTextBox();
            this.txtApellidoPaterno = new AltoControls.AltoTextBox();
            this.txtApellidoMaterno = new AltoControls.AltoTextBox();
            this.txtTelefono = new AltoControls.AltoTextBox();
            this.txtEmail = new AltoControls.AltoTextBox();
            this.btnSeleccionarHabitaciones = new System.Windows.Forms.Button();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnReservar = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            this.pnlFechas.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1263, 44);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESERVACIONES";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.Location = new System.Drawing.Point(0, 52);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(17, 818);
            this.pnlLeft.TabIndex = 11;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1246, 44);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(17, 819);
            this.pnlRight.TabIndex = 12;
            // 
            // pnlFechas
            // 
            this.pnlFechas.Controls.Add(this.dateTimePicker3);
            this.pnlFechas.Controls.Add(this.dateTimePicker2);
            this.pnlFechas.Controls.Add(this.dateTimePicker1);
            this.pnlFechas.Controls.Add(this.lblFechaSalida);
            this.pnlFechas.Controls.Add(this.lblFechaIngreso);
            this.pnlFechas.Controls.Add(this.lblFechaReservacion);
            this.pnlFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFechas.Location = new System.Drawing.Point(0, 0);
            this.pnlFechas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFechas.Name = "pnlFechas";
            this.pnlFechas.Size = new System.Drawing.Size(1246, 254);
            this.pnlFechas.TabIndex = 38;
            // 
            // lblFechaReservacion
            // 
            this.lblFechaReservacion.AutoSize = true;
            this.lblFechaReservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReservacion.Location = new System.Drawing.Point(371, 38);
            this.lblFechaReservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReservacion.Name = "lblFechaReservacion";
            this.lblFechaReservacion.Size = new System.Drawing.Size(191, 23);
            this.lblFechaReservacion.TabIndex = 34;
            this.lblFechaReservacion.Text = "Fecha reservación";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(413, 110);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(148, 23);
            this.lblFechaIngreso.TabIndex = 35;
            this.lblFechaIngreso.Text = "Fecha ingreso";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(423, 194);
            this.lblFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(135, 23);
            this.lblFechaSalida.TabIndex = 36;
            this.lblFechaSalida.Text = "Fecha salida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(589, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 32);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(589, 106);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 32);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(589, 188);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(265, 32);
            this.dateTimePicker3.TabIndex = 39;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnReservar);
            this.pnlDatos.Controls.Add(this.dgvHabitaciones);
            this.pnlDatos.Controls.Add(this.btnSeleccionarHabitaciones);
            this.pnlDatos.Controls.Add(this.grbCliente);
            this.pnlDatos.Location = new System.Drawing.Point(0, 256);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1228, 564);
            this.pnlDatos.TabIndex = 39;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtEmail);
            this.grbCliente.Controls.Add(this.txtTelefono);
            this.grbCliente.Controls.Add(this.txtApellidoMaterno);
            this.grbCliente.Controls.Add(this.txtApellidoPaterno);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.pcbBusqueda);
            this.grbCliente.Controls.Add(this.label5);
            this.grbCliente.Controls.Add(this.lblTelefono);
            this.grbCliente.Controls.Add(this.lblApellidoMaterno);
            this.grbCliente.Controls.Add(this.lblNombre);
            this.grbCliente.Controls.Add(this.lblApellido);
            this.grbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(13, 21);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grbCliente.Size = new System.Drawing.Size(1201, 231);
            this.grbCliente.TabIndex = 38;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(56, 111);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(177, 23);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(148, 53);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 23);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(51, 166);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(182, 23);
            this.lblApellidoMaterno.TabIndex = 13;
            this.lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(676, 53);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(93, 23);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo electrónico";
            // 
            // pcbBusqueda
            // 
            this.pcbBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBusqueda.Image = global::UI.Properties.Resources.lupa;
            this.pcbBusqueda.Location = new System.Drawing.Point(1143, 20);
            this.pcbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBusqueda.Name = "pcbBusqueda";
            this.pcbBusqueda.Size = new System.Drawing.Size(51, 47);
            this.pcbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBusqueda.TabIndex = 17;
            this.pcbBusqueda.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Br = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(253, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(283, 41);
            this.txtNombre.TabIndex = 18;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoPaterno.Br = System.Drawing.Color.White;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(253, 102);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(283, 41);
            this.txtApellidoPaterno.TabIndex = 19;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoMaterno.Br = System.Drawing.Color.White;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(253, 154);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(283, 41);
            this.txtApellidoMaterno.TabIndex = 20;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Br = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(789, 47);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(283, 41);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Br = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(789, 96);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 41);
            this.txtEmail.TabIndex = 22;
            // 
            // btnSeleccionarHabitaciones
            // 
            this.btnSeleccionarHabitaciones.BackColor = System.Drawing.Color.Black;
            this.btnSeleccionarHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSeleccionarHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarHabitaciones.Location = new System.Drawing.Point(476, 274);
            this.btnSeleccionarHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarHabitaciones.Name = "btnSeleccionarHabitaciones";
            this.btnSeleccionarHabitaciones.Size = new System.Drawing.Size(301, 52);
            this.btnSeleccionarHabitaciones.TabIndex = 39;
            this.btnSeleccionarHabitaciones.Text = "Seleccionar habitaciones";
            this.btnSeleccionarHabitaciones.UseVisualStyleBackColor = false;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(13, 338);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersWidth = 51;
            this.dgvHabitaciones.Size = new System.Drawing.Size(1193, 146);
            this.dgvHabitaciones.TabIndex = 40;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(501, 492);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(233, 52);
            this.btnReservar.TabIndex = 41;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlDatos);
            this.pnlContenido.Controls.Add(this.pnlFechas);
            this.pnlContenido.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 44);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1246, 819);
            this.pnlContenido.TabIndex = 13;
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 863);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTitulo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlFechas.ResumeLayout(false);
            this.pnlFechas.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFechas;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblFechaReservacion;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnSeleccionarHabitaciones;
        private System.Windows.Forms.GroupBox grbCliente;
        private AltoControls.AltoTextBox txtEmail;
        private AltoControls.AltoTextBox txtTelefono;
        private AltoControls.AltoTextBox txtApellidoMaterno;
        private AltoControls.AltoTextBox txtApellidoPaterno;
        private AltoControls.AltoTextBox txtNombre;
        private System.Windows.Forms.PictureBox pcbBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlContenido;
    }
}