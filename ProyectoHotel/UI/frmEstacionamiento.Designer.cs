
namespace UI
{
    partial class frmEstacionamiento
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.idEstacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grbRegistroEstacionamiento = new System.Windows.Forms.GroupBox();
            this.btnAgregarTipoVehiculo = new System.Windows.Forms.PictureBox();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbFiltroEstatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoVehiculoBusqueda = new System.Windows.Forms.Label();
            this.lblEstatusBusqueda = new System.Windows.Forms.Label();
            this.cmbFiltroTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.grbRegistroEstacionamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 474);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(945, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 474);
            this.panel3.TabIndex = 29;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(115, 459);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(175, 42);
            this.btnGuardarCambios.TabIndex = 73;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(734, 577);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 42);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(490, 577);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 42);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstacionamiento,
            this.clmTipoVehiculo,
            this.clmCosto,
            this.clmEstatus});
            this.dgvPromocion.Location = new System.Drawing.Point(415, 178);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowHeadersWidth = 51;
            this.dgvPromocion.Size = new System.Drawing.Size(520, 378);
            this.dgvPromocion.TabIndex = 70;
            // 
            // idEstacionamiento
            // 
            this.idEstacionamiento.HeaderText = "ID";
            this.idEstacionamiento.MinimumWidth = 6;
            this.idEstacionamiento.Name = "idEstacionamiento";
            this.idEstacionamiento.Width = 125;
            // 
            // clmTipoVehiculo
            // 
            this.clmTipoVehiculo.HeaderText = "TIPO VEHICULO";
            this.clmTipoVehiculo.MinimumWidth = 6;
            this.clmTipoVehiculo.Name = "clmTipoVehiculo";
            this.clmTipoVehiculo.Width = 125;
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(115, 398);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 42);
            this.btnRegistrar.TabIndex = 69;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grbRegistroEstacionamiento
            // 
            this.grbRegistroEstacionamiento.Controls.Add(this.btnAgregarTipoVehiculo);
            this.grbRegistroEstacionamiento.Controls.Add(this.cmbEstatus);
            this.grbRegistroEstacionamiento.Controls.Add(this.lblEstatus);
            this.grbRegistroEstacionamiento.Controls.Add(this.cmbTipoVehiculo);
            this.grbRegistroEstacionamiento.Controls.Add(this.lblTipoVehiculo);
            this.grbRegistroEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroEstacionamiento.Location = new System.Drawing.Point(24, 212);
            this.grbRegistroEstacionamiento.Name = "grbRegistroEstacionamiento";
            this.grbRegistroEstacionamiento.Size = new System.Drawing.Size(370, 171);
            this.grbRegistroEstacionamiento.TabIndex = 68;
            this.grbRegistroEstacionamiento.TabStop = false;
            this.grbRegistroEstacionamiento.Text = "Detalles estacionamiento";
            // 
            // btnAgregarTipoVehiculo
            // 
            this.btnAgregarTipoVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTipoVehiculo.Image = global::UI.Properties.Resources.boton_agregar;
            this.btnAgregarTipoVehiculo.Location = new System.Drawing.Point(330, 51);
            this.btnAgregarTipoVehiculo.Name = "btnAgregarTipoVehiculo";
            this.btnAgregarTipoVehiculo.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarTipoVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarTipoVehiculo.TabIndex = 49;
            this.btnAgregarTipoVehiculo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAgregarTipoVehiculo, "Añadir un nuevo tipo vehiculo");
            this.btnAgregarTipoVehiculo.Click += new System.EventHandler(this.btnAgregarTipoVehiculo_Click);
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(133, 100);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(220, 29);
            this.cmbEstatus.TabIndex = 48;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(10, 103);
            this.lblEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 21);
            this.lblEstatus.TabIndex = 47;
            this.lblEstatus.Text = "Estatus:";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(133, 53);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(191, 29);
            this.cmbTipoVehiculo.TabIndex = 42;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(10, 56);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(116, 21);
            this.lblTipoVehiculo.TabIndex = 41;
            this.lblTipoVehiculo.Text = "Tipo vehiculo:";
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
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar lugar de estacionamiento");
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // cmbFiltroEstatus
            // 
            this.cmbFiltroEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEstatus.FormattingEnabled = true;
            this.cmbFiltroEstatus.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE",
            "OCUPADO"});
            this.cmbFiltroEstatus.Location = new System.Drawing.Point(316, 47);
            this.cmbFiltroEstatus.Name = "cmbFiltroEstatus";
            this.cmbFiltroEstatus.Size = new System.Drawing.Size(121, 28);
            this.cmbFiltroEstatus.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.lblTipoVehiculoBusqueda);
            this.panel1.Controls.Add(this.lblEstatusBusqueda);
            this.panel1.Controls.Add(this.cmbFiltroTipoVehiculo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cmbFiltroEstatus);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 123);
            this.panel1.TabIndex = 27;
            // 
            // lblTipoVehiculoBusqueda
            // 
            this.lblTipoVehiculoBusqueda.AutoSize = true;
            this.lblTipoVehiculoBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoBusqueda.ForeColor = System.Drawing.Color.LightGray;
            this.lblTipoVehiculoBusqueda.Location = new System.Drawing.Point(449, 51);
            this.lblTipoVehiculoBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculoBusqueda.Name = "lblTipoVehiculoBusqueda";
            this.lblTipoVehiculoBusqueda.Size = new System.Drawing.Size(122, 19);
            this.lblTipoVehiculoBusqueda.TabIndex = 10;
            this.lblTipoVehiculoBusqueda.Text = "TIPO VEHICULO";
            // 
            // lblEstatusBusqueda
            // 
            this.lblEstatusBusqueda.AutoSize = true;
            this.lblEstatusBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusBusqueda.ForeColor = System.Drawing.Color.LightGray;
            this.lblEstatusBusqueda.Location = new System.Drawing.Point(247, 50);
            this.lblEstatusBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstatusBusqueda.Name = "lblEstatusBusqueda";
            this.lblEstatusBusqueda.Size = new System.Drawing.Size(69, 19);
            this.lblEstatusBusqueda.TabIndex = 9;
            this.lblEstatusBusqueda.Text = "ESTATUS";
            // 
            // cmbFiltroTipoVehiculo
            // 
            this.cmbFiltroTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroTipoVehiculo.FormattingEnabled = true;
            this.cmbFiltroTipoVehiculo.Location = new System.Drawing.Point(574, 47);
            this.cmbFiltroTipoVehiculo.Name = "cmbFiltroTipoVehiculo";
            this.cmbFiltroTipoVehiculo.Size = new System.Drawing.Size(121, 28);
            this.cmbFiltroTipoVehiculo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ESTACIONAMIENTO";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(962, 36);
            this.pnlTitulo.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEstacionamiento
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
            this.Controls.Add(this.grbRegistroEstacionamiento);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmEstacionamiento";
            this.Text = "frmEstacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.grbRegistroEstacionamiento.ResumeLayout(false);
            this.grbRegistroEstacionamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarTipoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvPromocion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstatus;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grbRegistroEstacionamiento;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.PictureBox btnAgregarTipoVehiculo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbFiltroEstatus;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstatusBusqueda;
        private System.Windows.Forms.ComboBox cmbFiltroTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculoBusqueda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}