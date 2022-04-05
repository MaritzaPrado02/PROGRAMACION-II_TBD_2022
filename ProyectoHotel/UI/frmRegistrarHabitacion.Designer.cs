
namespace UI
{
    partial class frmRegistrarHabitacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.clmClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComplementos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarCatHabitacion = new System.Windows.Forms.PictureBox();
            this.grbDetallesHabitacion = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtClave = new AltoControls.AltoTextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.cmbCategoriaHabitacion = new System.Windows.Forms.ComboBox();
            this.lblTipoHabitacion = new System.Windows.Forms.Label();
            this.txtCosto = new AltoControls.AltoTextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvComplementos = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComplementos = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCatHabitacion)).BeginInit();
            this.grbDetallesHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplementos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR HABITACIÓN";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(962, 36);
            this.pnlTitulo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cmbFiltro);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 123);
            this.panel1.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::UI.Properties.Resources.lupa1;
            this.btnBuscar.Location = new System.Drawing.Point(746, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 45);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar habitacion");
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "FECHA",
            "ESTATUS",
            "CLAVE",
            "CUPO",
            "CATEGORÍA"});
            this.cmbFiltro.Location = new System.Drawing.Point(207, 48);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 28);
            this.cmbFiltro.TabIndex = 6;
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(311, 579);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(175, 42);
            this.btnGuardarCambios.TabIndex = 71;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(756, 579);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 42);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(203)))), ((int)(((byte)(82)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(510, 579);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 42);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnRegistrar.Location = new System.Drawing.Point(121, 579);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 42);
            this.btnRegistrar.TabIndex = 68;
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
            this.clmClave,
            this.clmCategoria,
            this.clmCosto,
            this.clmEstatus,
            this.clmComplementos});
            this.dgvPromocion.Location = new System.Drawing.Point(416, 179);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowHeadersWidth = 51;
            this.dgvPromocion.Size = new System.Drawing.Size(529, 381);
            this.dgvPromocion.TabIndex = 72;
            // 
            // clmClave
            // 
            this.clmClave.HeaderText = "CLAVE";
            this.clmClave.MinimumWidth = 6;
            this.clmClave.Name = "clmClave";
            this.clmClave.Width = 125;
            // 
            // clmCategoria
            // 
            this.clmCategoria.HeaderText = "CATEGORÍA";
            this.clmCategoria.MinimumWidth = 6;
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.Width = 125;
            // 
            // clmCosto
            // 
            this.clmCosto.HeaderText = "COSTO";
            this.clmCosto.MinimumWidth = 6;
            this.clmCosto.Name = "clmCosto";
            this.clmCosto.Width = 125;
            // 
            // clmEstatus
            // 
            this.clmEstatus.HeaderText = "ESTATUS";
            this.clmEstatus.MinimumWidth = 6;
            this.clmEstatus.Name = "clmEstatus";
            this.clmEstatus.Width = 125;
            // 
            // clmComplementos
            // 
            this.clmComplementos.HeaderText = "COMPLEMENTOS";
            this.clmComplementos.MinimumWidth = 6;
            this.clmComplementos.Name = "clmComplementos";
            this.clmComplementos.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 474);
            this.panel2.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(945, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 474);
            this.panel3.TabIndex = 74;
            // 
            // btnAgregarCatHabitacion
            // 
            this.btnAgregarCatHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCatHabitacion.Image = global::UI.Properties.Resources.boton_agregar;
            this.btnAgregarCatHabitacion.Location = new System.Drawing.Point(321, 89);
            this.btnAgregarCatHabitacion.Name = "btnAgregarCatHabitacion";
            this.btnAgregarCatHabitacion.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarCatHabitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarCatHabitacion.TabIndex = 95;
            this.btnAgregarCatHabitacion.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAgregarCatHabitacion, "Añadir una nueva categoría de habitación");
            this.btnAgregarCatHabitacion.Click += new System.EventHandler(this.btnAgregarCatHabitacion_Click);
            // 
            // grbDetallesHabitacion
            // 
            this.grbDetallesHabitacion.Controls.Add(this.btnAgregarCatHabitacion);
            this.grbDetallesHabitacion.Controls.Add(this.comboBox1);
            this.grbDetallesHabitacion.Controls.Add(this.txtClave);
            this.grbDetallesHabitacion.Controls.Add(this.lblClave);
            this.grbDetallesHabitacion.Controls.Add(this.cmbCategoriaHabitacion);
            this.grbDetallesHabitacion.Controls.Add(this.lblTipoHabitacion);
            this.grbDetallesHabitacion.Controls.Add(this.txtCosto);
            this.grbDetallesHabitacion.Controls.Add(this.lblCosto);
            this.grbDetallesHabitacion.Controls.Add(this.label3);
            this.grbDetallesHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetallesHabitacion.Location = new System.Drawing.Point(24, 167);
            this.grbDetallesHabitacion.Name = "grbDetallesHabitacion";
            this.grbDetallesHabitacion.Size = new System.Drawing.Size(386, 222);
            this.grbDetallesHabitacion.TabIndex = 75;
            this.grbDetallesHabitacion.TabStop = false;
            this.grbDetallesHabitacion.Text = "Detalles Habitación";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 172);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 29);
            this.comboBox1.TabIndex = 94;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.Transparent;
            this.txtClave.Br = System.Drawing.Color.White;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.DimGray;
            this.txtClave.Location = new System.Drawing.Point(102, 52);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(241, 27);
            this.txtClave.TabIndex = 93;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(25, 54);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(61, 21);
            this.lblClave.TabIndex = 92;
            this.lblClave.Text = "Clave:";
            // 
            // cmbCategoriaHabitacion
            // 
            this.cmbCategoriaHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaHabitacion.FormattingEnabled = true;
            this.cmbCategoriaHabitacion.Location = new System.Drawing.Point(170, 92);
            this.cmbCategoriaHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoriaHabitacion.Name = "cmbCategoriaHabitacion";
            this.cmbCategoriaHabitacion.Size = new System.Drawing.Size(146, 29);
            this.cmbCategoriaHabitacion.TabIndex = 91;
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHabitacion.Location = new System.Drawing.Point(27, 94);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(136, 21);
            this.lblTipoHabitacion.TabIndex = 90;
            this.lblTipoHabitacion.Text = "Tipo habitación:";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.Transparent;
            this.txtCosto.Br = System.Drawing.Color.White;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCosto.Location = new System.Drawing.Point(97, 132);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(246, 27);
            this.txtCosto.TabIndex = 89;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(28, 133);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(60, 21);
            this.lblCosto.TabIndex = 88;
            this.lblCosto.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 87;
            this.label3.Text = "Estatus:";
            // 
            // dgvComplementos
            // 
            this.dgvComplementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvComplementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmComplemento,
            this.clmCantidad});
            this.dgvComplementos.Location = new System.Drawing.Point(24, 433);
            this.dgvComplementos.Name = "dgvComplementos";
            this.dgvComplementos.RowHeadersWidth = 51;
            this.dgvComplementos.Size = new System.Drawing.Size(383, 127);
            this.dgvComplementos.TabIndex = 104;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.Visible = false;
            this.clmID.Width = 125;
            // 
            // clmComplemento
            // 
            this.clmComplemento.HeaderText = "COMPLEMENTO";
            this.clmComplemento.MinimumWidth = 6;
            this.clmComplemento.Name = "clmComplemento";
            this.clmComplemento.Width = 125;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "CANTIDAD";
            this.clmCantidad.MinimumWidth = 6;
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.Width = 125;
            // 
            // lblComplementos
            // 
            this.lblComplementos.AutoSize = true;
            this.lblComplementos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplementos.Location = new System.Drawing.Point(148, 400);
            this.lblComplementos.Name = "lblComplementos";
            this.lblComplementos.Size = new System.Drawing.Size(143, 21);
            this.lblComplementos.TabIndex = 96;
            this.lblComplementos.Text = "COMPLEMENTOS";
            // 
            // frmRegistrarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.lblComplementos);
            this.Controls.Add(this.dgvComplementos);
            this.Controls.Add(this.grbDetallesHabitacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmRegistrarHabitacion";
            this.Text = "frmRegistrarHabitacion";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCatHabitacion)).EndInit();
            this.grbDetallesHabitacion.ResumeLayout(false);
            this.grbDetallesHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvPromocion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComplementos;
        private System.Windows.Forms.GroupBox grbDetallesHabitacion;
        private System.Windows.Forms.PictureBox btnAgregarCatHabitacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private AltoControls.AltoTextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ComboBox cmbCategoriaHabitacion;
        private System.Windows.Forms.Label lblTipoHabitacion;
        private AltoControls.AltoTextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvComplementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.Label lblComplementos;
    }
}