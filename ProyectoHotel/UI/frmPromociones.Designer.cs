
namespace UI
{
    partial class frmPromociones
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
            this.grbRegistroNuevaPromocion = new System.Windows.Forms.GroupBox();
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.lblCostoHabitacion = new System.Windows.Forms.Label();
            this.nudNumeroHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroHabitaciones = new System.Windows.Forms.Label();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.lblTipoHabitaciones = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new AltoControls.AltoTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.lblFechaFinBusqueda = new System.Windows.Forms.Label();
            this.dtpFechaFinBusqueda = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicioBusqueda = new System.Windows.Forms.Label();
            this.dtpFechaInicioBusqueda = new System.Windows.Forms.DateTimePicker();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.grbRegistroNuevaPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistroNuevaPromocion
            // 
            this.grbRegistroNuevaPromocion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRegistroNuevaPromocion.Controls.Add(this.altoTextBox1);
            this.grbRegistroNuevaPromocion.Controls.Add(this.lblCostoHabitacion);
            this.grbRegistroNuevaPromocion.Controls.Add(this.nudNumeroHabitaciones);
            this.grbRegistroNuevaPromocion.Controls.Add(this.lblNumeroHabitaciones);
            this.grbRegistroNuevaPromocion.Controls.Add(this.cmbTipoHabitacion);
            this.grbRegistroNuevaPromocion.Controls.Add(this.lblTipoHabitaciones);
            this.grbRegistroNuevaPromocion.Controls.Add(this.lblFechaFin);
            this.grbRegistroNuevaPromocion.Controls.Add(this.dtpFechaFin);
            this.grbRegistroNuevaPromocion.Controls.Add(this.txtDescripcion);
            this.grbRegistroNuevaPromocion.Controls.Add(this.lblDescripcion);
            this.grbRegistroNuevaPromocion.Controls.Add(this.lblFechaInicio);
            this.grbRegistroNuevaPromocion.Controls.Add(this.dtpFechaInicio);
            this.grbRegistroNuevaPromocion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroNuevaPromocion.Location = new System.Drawing.Point(27, 168);
            this.grbRegistroNuevaPromocion.Name = "grbRegistroNuevaPromocion";
            this.grbRegistroNuevaPromocion.Size = new System.Drawing.Size(370, 390);
            this.grbRegistroNuevaPromocion.TabIndex = 26;
            this.grbRegistroNuevaPromocion.TabStop = false;
            this.grbRegistroNuevaPromocion.Text = "Detalles promoción";
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(162, 331);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(188, 33);
            this.altoTextBox1.TabIndex = 46;
            // 
            // lblCostoHabitacion
            // 
            this.lblCostoHabitacion.AutoSize = true;
            this.lblCostoHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoHabitacion.Location = new System.Drawing.Point(7, 338);
            this.lblCostoHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoHabitacion.Name = "lblCostoHabitacion";
            this.lblCostoHabitacion.Size = new System.Drawing.Size(148, 21);
            this.lblCostoHabitacion.TabIndex = 45;
            this.lblCostoHabitacion.Text = "Costo promoción:";
            // 
            // nudNumeroHabitaciones
            // 
            this.nudNumeroHabitaciones.Location = new System.Drawing.Point(197, 285);
            this.nudNumeroHabitaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroHabitaciones.Name = "nudNumeroHabitaciones";
            this.nudNumeroHabitaciones.Size = new System.Drawing.Size(153, 27);
            this.nudNumeroHabitaciones.TabIndex = 44;
            this.nudNumeroHabitaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumeroHabitaciones
            // 
            this.lblNumeroHabitaciones.AutoSize = true;
            this.lblNumeroHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHabitaciones.Location = new System.Drawing.Point(7, 290);
            this.lblNumeroHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroHabitaciones.Name = "lblNumeroHabitaciones";
            this.lblNumeroHabitaciones.Size = new System.Drawing.Size(182, 21);
            this.lblNumeroHabitaciones.TabIndex = 43;
            this.lblNumeroHabitaciones.Text = "Número habitaciones:";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(166, 237);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(184, 29);
            this.cmbTipoHabitacion.TabIndex = 42;
            // 
            // lblTipoHabitaciones
            // 
            this.lblTipoHabitaciones.AutoSize = true;
            this.lblTipoHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHabitaciones.Location = new System.Drawing.Point(7, 240);
            this.lblTipoHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoHabitaciones.Name = "lblTipoHabitaciones";
            this.lblTipoHabitaciones.Size = new System.Drawing.Size(152, 21);
            this.lblTipoHabitaciones.TabIndex = 41;
            this.lblTipoHabitaciones.Text = "Tipo habitaciones:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(7, 187);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(88, 21);
            this.lblFechaFin.TabIndex = 39;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(123, 185);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(227, 27);
            this.dtpFechaFin.TabIndex = 40;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.Br = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(11, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(339, 33);
            this.txtDescripcion.TabIndex = 38;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(7, 41);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 21);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(7, 138);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(108, 21);
            this.lblFechaInicio.TabIndex = 28;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(123, 136);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(227, 27);
            this.dtpFechaInicio.TabIndex = 34;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(27, 579);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 42);
            this.btnRegistrar.TabIndex = 60;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmCosto,
            this.clmFechaInicio,
            this.clmFechaFin,
            this.clmEstatus});
            this.dgvPromocion.Location = new System.Drawing.Point(418, 180);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowHeadersWidth = 51;
            this.dgvPromocion.Size = new System.Drawing.Size(520, 378);
            this.dgvPromocion.TabIndex = 61;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "NOMBRE PROMOCIÓN";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // clmCosto
            // 
            this.clmCosto.HeaderText = "COSTO";
            this.clmCosto.MinimumWidth = 6;
            this.clmCosto.Name = "clmCosto";
            this.clmCosto.Width = 125;
            // 
            // clmFechaInicio
            // 
            this.clmFechaInicio.HeaderText = "FECHA INICIO";
            this.clmFechaInicio.MinimumWidth = 6;
            this.clmFechaInicio.Name = "clmFechaInicio";
            this.clmFechaInicio.Width = 125;
            // 
            // clmFechaFin
            // 
            this.clmFechaFin.HeaderText = "FECHA FIN";
            this.clmFechaFin.MinimumWidth = 6;
            this.clmFechaFin.Name = "clmFechaFin";
            this.clmFechaFin.Width = 125;
            // 
            // clmEstatus
            // 
            this.clmEstatus.HeaderText = "ESTATUS";
            this.clmEstatus.MinimumWidth = 6;
            this.clmEstatus.Name = "clmEstatus";
            this.clmEstatus.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(203)))), ((int)(((byte)(82)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(493, 579);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 42);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(737, 579);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 42);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::UI.Properties.Resources.lupa1;
            this.btnBuscar.Location = new System.Drawing.Point(745, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 45);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar promoción");
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(222, 579);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(175, 42);
            this.btnGuardarCambios.TabIndex = 67;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 474);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(945, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 474);
            this.panel3.TabIndex = 25;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(962, 36);
            this.pnlTitulo.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PROMOCIONES";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(135, 50);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(64, 19);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(335, 49);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(403, 26);
            this.txtBuscar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.cmbEstatus);
            this.panel1.Controls.Add(this.lblFechaFinBusqueda);
            this.panel1.Controls.Add(this.dtpFechaFinBusqueda);
            this.panel1.Controls.Add(this.lblFechaInicioBusqueda);
            this.panel1.Controls.Add(this.dtpFechaInicioBusqueda);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cmbFiltro);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 123);
            this.panel1.TabIndex = 23;
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "VIGENTE",
            "NO VIGENTE"});
            this.cmbEstatus.Location = new System.Drawing.Point(632, 89);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(176, 28);
            this.cmbEstatus.TabIndex = 16;
            this.cmbEstatus.Visible = false;
            // 
            // lblFechaFinBusqueda
            // 
            this.lblFechaFinBusqueda.AutoSize = true;
            this.lblFechaFinBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblFechaFinBusqueda.Location = new System.Drawing.Point(498, 23);
            this.lblFechaFinBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinBusqueda.Name = "lblFechaFinBusqueda";
            this.lblFechaFinBusqueda.Size = new System.Drawing.Size(84, 19);
            this.lblFechaFinBusqueda.TabIndex = 15;
            this.lblFechaFinBusqueda.Text = "Fecha fin:";
            this.lblFechaFinBusqueda.Visible = false;
            // 
            // dtpFechaFinBusqueda
            // 
            this.dtpFechaFinBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinBusqueda.Location = new System.Drawing.Point(497, 81);
            this.dtpFechaFinBusqueda.Name = "dtpFechaFinBusqueda";
            this.dtpFechaFinBusqueda.Size = new System.Drawing.Size(118, 27);
            this.dtpFechaFinBusqueda.TabIndex = 14;
            this.dtpFechaFinBusqueda.Visible = false;
            // 
            // lblFechaInicioBusqueda
            // 
            this.lblFechaInicioBusqueda.AutoSize = true;
            this.lblFechaInicioBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicioBusqueda.Location = new System.Drawing.Point(349, 23);
            this.lblFechaInicioBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicioBusqueda.Name = "lblFechaInicioBusqueda";
            this.lblFechaInicioBusqueda.Size = new System.Drawing.Size(108, 19);
            this.lblFechaInicioBusqueda.TabIndex = 13;
            this.lblFechaInicioBusqueda.Text = "Fecha inicio:";
            this.lblFechaInicioBusqueda.Visible = false;
            // 
            // dtpFechaInicioBusqueda
            // 
            this.dtpFechaInicioBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioBusqueda.Location = new System.Drawing.Point(348, 81);
            this.dtpFechaInicioBusqueda.Name = "dtpFechaInicioBusqueda";
            this.dtpFechaInicioBusqueda.Size = new System.Drawing.Size(118, 27);
            this.dtpFechaInicioBusqueda.TabIndex = 12;
            this.dtpFechaInicioBusqueda.Visible = false;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "FECHA",
            "ESTATUS",
            "NOMBRE"});
            this.cmbFiltro.Location = new System.Drawing.Point(207, 48);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 28);
            this.cmbFiltro.TabIndex = 6;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // frmPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbRegistroNuevaPromocion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmPromociones";
            this.Text = "frmPromociones";
            this.grbRegistroNuevaPromocion.ResumeLayout(false);
            this.grbRegistroNuevaPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbRegistroNuevaPromocion;
        private AltoControls.AltoTextBox altoTextBox1;
        private System.Windows.Forms.Label lblCostoHabitacion;
        private System.Windows.Forms.NumericUpDown nudNumeroHabitaciones;
        private System.Windows.Forms.Label lblNumeroHabitaciones;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.Label lblTipoHabitaciones;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private AltoControls.AltoTextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvPromocion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstatus;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFechaFinBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaFinBusqueda;
        private System.Windows.Forms.Label lblFechaInicioBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioBusqueda;
        private System.Windows.Forms.ComboBox cmbEstatus;
    }
}