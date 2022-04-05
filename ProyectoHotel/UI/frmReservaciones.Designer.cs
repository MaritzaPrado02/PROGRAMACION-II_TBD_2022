
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
            this.components = new System.ComponentModel.Container();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.clmClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtEmail = new AltoControls.AltoTextBox();
            this.txtTelefono = new AltoControls.AltoTextBox();
            this.btnBusqueda = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new AltoControls.AltoTextBox();
            this.txtApellidoPaterno = new AltoControls.AltoTextBox();
            this.txtNombre = new AltoControls.AltoTextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaReservacion = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblAplicaPromocion = new System.Windows.Forms.Label();
            this.ckbSiAplica = new System.Windows.Forms.CheckBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdbNoEstacionamiento = new System.Windows.Forms.RadioButton();
            this.rdbSiEstacionamiento = new System.Windows.Forms.RadioButton();
            this.lblAplicaEstacionamiento = new System.Windows.Forms.Label();
            this.btnAgregarEstacionamiento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblEspacioEstacionamiento = new System.Windows.Forms.Label();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(962, 36);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESERVACIONES";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(292, 580);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(175, 42);
            this.btnReservar.TabIndex = 59;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClave,
            this.clmTipo,
            this.clmCosto});
            this.dgvHabitaciones.Location = new System.Drawing.Point(521, 126);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersWidth = 51;
            this.dgvHabitaciones.Size = new System.Drawing.Size(385, 138);
            this.dgvHabitaciones.TabIndex = 58;
            // 
            // clmClave
            // 
            this.clmClave.HeaderText = "CLAVE HABITACIÓN";
            this.clmClave.MinimumWidth = 6;
            this.clmClave.Name = "clmClave";
            this.clmClave.Width = 125;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "TIPO";
            this.clmTipo.MinimumWidth = 6;
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.Width = 125;
            // 
            // clmCosto
            // 
            this.clmCosto.HeaderText = "COSTO";
            this.clmCosto.MinimumWidth = 6;
            this.clmCosto.Name = "clmCosto";
            this.clmCosto.Width = 125;
            // 
            // grbCliente
            // 
            this.grbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCliente.Controls.Add(this.txtEmail);
            this.grbCliente.Controls.Add(this.txtTelefono);
            this.grbCliente.Controls.Add(this.btnBusqueda);
            this.grbCliente.Controls.Add(this.label5);
            this.grbCliente.Controls.Add(this.lblTelefono);
            this.grbCliente.Controls.Add(this.txtApellidoMaterno);
            this.grbCliente.Controls.Add(this.txtApellidoPaterno);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.lblApellidoMaterno);
            this.grbCliente.Controls.Add(this.lblNombre);
            this.grbCliente.Controls.Add(this.lblApellido);
            this.grbCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(47, 288);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(415, 285);
            this.grbCliente.TabIndex = 56;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Br = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(190, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 33);
            this.txtEmail.TabIndex = 27;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Br = System.Drawing.Color.White;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(190, 165);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(212, 33);
            this.txtTelefono.TabIndex = 26;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqueda.Image = global::UI.Properties.Resources.lupa;
            this.btnBusqueda.Location = new System.Drawing.Point(38, 33);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(38, 38);
            this.btnBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBusqueda.TabIndex = 25;
            this.btnBusqueda.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBusqueda, "Buscar cliente");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Correo electrónico";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(105, 170);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoMaterno.Br = System.Drawing.Color.White;
            this.txtApellidoMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(190, 122);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(212, 33);
            this.txtApellidoMaterno.TabIndex = 20;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoPaterno.Br = System.Drawing.Color.White;
            this.txtApellidoPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(190, 78);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(212, 33);
            this.txtApellidoPaterno.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Br = System.Drawing.Color.White;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(190, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 33);
            this.txtNombre.TabIndex = 18;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(38, 132);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(146, 21);
            this.lblApellidoMaterno.TabIndex = 13;
            this.lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(111, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(42, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(142, 21);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido paterno";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(243, 174);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(211, 27);
            this.dateTimePicker3.TabIndex = 55;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(211, 27);
            this.dateTimePicker2.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 27);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(118, 179);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(109, 19);
            this.lblFechaSalida.TabIndex = 52;
            this.lblFechaSalida.Text = "Fecha salida";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(111, 132);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(118, 19);
            this.lblFechaIngreso.TabIndex = 51;
            this.lblFechaIngreso.Text = "Fecha ingreso";
            // 
            // lblFechaReservacion
            // 
            this.lblFechaReservacion.AutoSize = true;
            this.lblFechaReservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReservacion.Location = new System.Drawing.Point(79, 94);
            this.lblFechaReservacion.Name = "lblFechaReservacion";
            this.lblFechaReservacion.Size = new System.Drawing.Size(152, 19);
            this.lblFechaReservacion.TabIndex = 50;
            this.lblFechaReservacion.Text = "Fecha reservación";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 36);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(17, 597);
            this.pnlLeft.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(945, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 597);
            this.panel1.TabIndex = 61;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(494, 580);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(184, 42);
            this.btnGuardarCambios.TabIndex = 67;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // lblAplicaPromocion
            // 
            this.lblAplicaPromocion.AutoSize = true;
            this.lblAplicaPromocion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicaPromocion.Location = new System.Drawing.Point(75, 223);
            this.lblAplicaPromocion.Name = "lblAplicaPromocion";
            this.lblAplicaPromocion.Size = new System.Drawing.Size(151, 19);
            this.lblAplicaPromocion.TabIndex = 69;
            this.lblAplicaPromocion.Text = "Aplica promoción";
            // 
            // ckbSiAplica
            // 
            this.ckbSiAplica.AutoSize = true;
            this.ckbSiAplica.Location = new System.Drawing.Point(243, 226);
            this.ckbSiAplica.Name = "ckbSiAplica";
            this.ckbSiAplica.Size = new System.Drawing.Size(68, 17);
            this.ckbSiAplica.TabIndex = 70;
            this.ckbSiAplica.Text = "Sí aplica";
            this.ckbSiAplica.UseVisualStyleBackColor = true;
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(128, 262);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(93, 19);
            this.lblPromocion.TabIndex = 71;
            this.lblPromocion.Text = "Promoción";
            this.lblPromocion.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 29);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.Visible = false;
            // 
            // rdbNoEstacionamiento
            // 
            this.rdbNoEstacionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbNoEstacionamiento.AutoSize = true;
            this.rdbNoEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoEstacionamiento.Location = new System.Drawing.Point(820, 294);
            this.rdbNoEstacionamiento.Name = "rdbNoEstacionamiento";
            this.rdbNoEstacionamiento.Size = new System.Drawing.Size(54, 25);
            this.rdbNoEstacionamiento.TabIndex = 141;
            this.rdbNoEstacionamiento.TabStop = true;
            this.rdbNoEstacionamiento.Text = "NO";
            this.rdbNoEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // rdbSiEstacionamiento
            // 
            this.rdbSiEstacionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbSiEstacionamiento.AutoSize = true;
            this.rdbSiEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSiEstacionamiento.Location = new System.Drawing.Point(742, 294);
            this.rdbSiEstacionamiento.Name = "rdbSiEstacionamiento";
            this.rdbSiEstacionamiento.Size = new System.Drawing.Size(41, 25);
            this.rdbSiEstacionamiento.TabIndex = 140;
            this.rdbSiEstacionamiento.TabStop = true;
            this.rdbSiEstacionamiento.Text = "SI";
            this.rdbSiEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // lblAplicaEstacionamiento
            // 
            this.lblAplicaEstacionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAplicaEstacionamiento.AutoSize = true;
            this.lblAplicaEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicaEstacionamiento.Location = new System.Drawing.Point(517, 296);
            this.lblAplicaEstacionamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAplicaEstacionamiento.Name = "lblAplicaEstacionamiento";
            this.lblAplicaEstacionamiento.Size = new System.Drawing.Size(202, 21);
            this.lblAplicaEstacionamiento.TabIndex = 139;
            this.lblAplicaEstacionamiento.Text = "Aplica estacionamiento:";
            // 
            // btnAgregarEstacionamiento
            // 
            this.btnAgregarEstacionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEstacionamiento.BackColor = System.Drawing.Color.Black;
            this.btnAgregarEstacionamiento.FlatAppearance.BorderSize = 0;
            this.btnAgregarEstacionamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAgregarEstacionamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAgregarEstacionamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEstacionamiento.Location = new System.Drawing.Point(744, 381);
            this.btnAgregarEstacionamiento.Name = "btnAgregarEstacionamiento";
            this.btnAgregarEstacionamiento.Size = new System.Drawing.Size(130, 33);
            this.btnAgregarEstacionamiento.TabIndex = 138;
            this.btnAgregarEstacionamiento.Text = "Agregar";
            this.btnAgregarEstacionamiento.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmTipoVehiculo});
            this.dataGridView1.Location = new System.Drawing.Point(521, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(352, 138);
            this.dataGridView1.TabIndex = 137;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.Width = 125;
            // 
            // clmTipoVehiculo
            // 
            this.clmTipoVehiculo.HeaderText = "TIPO VEHICULO";
            this.clmTipoVehiculo.MinimumWidth = 6;
            this.clmTipoVehiculo.Name = "clmTipoVehiculo";
            this.clmTipoVehiculo.Width = 125;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "TRANSFERENCIA BANCARIA",
            "PAGO EN EFECTIVO ",
            "PAYPAL",
            "TARJETA DE CREDITO",
            "TARJETA DEBITO "});
            this.comboBox4.Location = new System.Drawing.Point(741, 336);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(133, 29);
            this.comboBox4.TabIndex = 136;
            // 
            // lblEspacioEstacionamiento
            // 
            this.lblEspacioEstacionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspacioEstacionamiento.AutoSize = true;
            this.lblEspacioEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacioEstacionamiento.Location = new System.Drawing.Point(572, 339);
            this.lblEspacioEstacionamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspacioEstacionamiento.Name = "lblEspacioEstacionamiento";
            this.lblEspacioEstacionamiento.Size = new System.Drawing.Size(146, 21);
            this.lblEspacioEstacionamiento.TabIndex = 135;
            this.lblEspacioEstacionamiento.Text = "Estacionamiento:";
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(622, 67);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(171, 29);
            this.cmbHabitacion.TabIndex = 143;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(518, 70);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(95, 19);
            this.lblHabitacion.TabIndex = 142;
            this.lblHabitacion.Text = "Habitación";
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarHabitacion.BackColor = System.Drawing.Color.Black;
            this.btnAgregarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarHabitacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAgregarHabitacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAgregarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabitacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(820, 63);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(86, 33);
            this.btnAgregarHabitacion.TabIndex = 144;
            this.btnAgregarHabitacion.Text = "Agregar";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = false;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(237, 50);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(213, 29);
            this.cmbEmpleado.TabIndex = 146;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(133, 53);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 19);
            this.lblEmpleado.TabIndex = 145;
            this.lblEmpleado.Text = "Empleado";
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Controls.Add(this.cmbHabitacion);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.rdbNoEstacionamiento);
            this.Controls.Add(this.rdbSiEstacionamiento);
            this.Controls.Add(this.lblAplicaEstacionamiento);
            this.Controls.Add(this.btnAgregarEstacionamiento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.lblEspacioEstacionamiento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.ckbSiAplica);
            this.Controls.Add(this.lblAplicaPromocion);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblFechaReservacion);
            this.Controls.Add(this.pnlTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.GroupBox grbCliente;
        private AltoControls.AltoTextBox txtEmail;
        private AltoControls.AltoTextBox txtTelefono;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono;
        private AltoControls.AltoTextBox txtApellidoMaterno;
        private AltoControls.AltoTextBox txtApellidoPaterno;
        private AltoControls.AltoTextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblFechaReservacion;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.PictureBox btnBusqueda;
        private System.Windows.Forms.Label lblAplicaPromocion;
        private System.Windows.Forms.CheckBox ckbSiAplica;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdbNoEstacionamiento;
        private System.Windows.Forms.RadioButton rdbSiEstacionamiento;
        private System.Windows.Forms.Label lblAplicaEstacionamiento;
        private System.Windows.Forms.Button btnAgregarEstacionamiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblEspacioEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
    }
}