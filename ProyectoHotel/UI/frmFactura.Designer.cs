
namespace UI
{
    partial class frmFactura
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReservacionFacturar = new System.Windows.Forms.Label();
            this.cmbReservacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReservacion = new System.Windows.Forms.Label();
            this.lblCostoReservacion = new System.Windows.Forms.Label();
            this.lblCostoEstacionamiento = new System.Windows.Forms.Label();
            this.lblCostoSubtotal = new System.Windows.Forms.Label();
            this.lblCostoIVA = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.rdbSiEnvio = new System.Windows.Forms.RadioButton();
            this.rdbNoEnvio = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbIDEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dgvDetallesReservacion = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClaveHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetallesEstacionamiento = new System.Windows.Forms.DataGridView();
            this.clmIDEstacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoEstacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetalleHabitaciones = new System.Windows.Forms.Label();
            this.lblDetalleEstacionamiento = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesEstacionamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(945, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 597);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 597);
            this.panel2.TabIndex = 31;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(962, 36);
            this.pnlTitulo.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FACTURAR";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "TRANSFERENCIA BANCARIA",
            "PAGO EN EFECTIVO ",
            "PAYPAL",
            "TARJETA DE CRÉDITO",
            "TARJETA DÉBITO "});
            this.cmbTipoPago.Location = new System.Drawing.Point(260, 261);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(288, 29);
            this.cmbTipoPago.TabIndex = 44;
            // 
            // dtpFechaFacturacion
            // 
            this.dtpFechaFacturacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFacturacion.Location = new System.Drawing.Point(265, 134);
            this.dtpFechaFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFacturacion.Name = "dtpFechaFacturacion";
            this.dtpFechaFacturacion.Size = new System.Drawing.Size(283, 27);
            this.dtpFechaFacturacion.TabIndex = 43;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(353, 439);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 21);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total: $";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(364, 409);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(56, 21);
            this.lblIva.TabIndex = 41;
            this.lblIva.Text = "IVA: $";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(329, 378);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(94, 21);
            this.lblSubtotal.TabIndex = 40;
            this.lblSubtotal.Text = "Subtotal: $";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(124, 264);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(118, 21);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Tipo de pago:";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvio.Location = new System.Drawing.Point(99, 223);
            this.lblEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(144, 21);
            this.lblEnvio.TabIndex = 38;
            this.lblEnvio.Text = "Envio de factura:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(58, 134);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(184, 21);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "Fecha de facturacion:";
            // 
            // lblReservacionFacturar
            // 
            this.lblReservacionFacturar.AutoSize = true;
            this.lblReservacionFacturar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservacionFacturar.Location = new System.Drawing.Point(54, 176);
            this.lblReservacionFacturar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservacionFacturar.Name = "lblReservacionFacturar";
            this.lblReservacionFacturar.Size = new System.Drawing.Size(192, 21);
            this.lblReservacionFacturar.TabIndex = 46;
            this.lblReservacionFacturar.Text = "Reservacion a facturar:";
            // 
            // cmbReservacion
            // 
            this.cmbReservacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReservacion.FormattingEnabled = true;
            this.cmbReservacion.Location = new System.Drawing.Point(265, 174);
            this.cmbReservacion.Name = "cmbReservacion";
            this.cmbReservacion.Size = new System.Drawing.Size(283, 28);
            this.cmbReservacion.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Estacionamiento: $";
            // 
            // lblReservacion
            // 
            this.lblReservacion.AutoSize = true;
            this.lblReservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservacion.Location = new System.Drawing.Point(302, 309);
            this.lblReservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservacion.Name = "lblReservacion";
            this.lblReservacion.Size = new System.Drawing.Size(122, 21);
            this.lblReservacion.TabIndex = 51;
            this.lblReservacion.Text = "Reservacion: $";
            // 
            // lblCostoReservacion
            // 
            this.lblCostoReservacion.AutoSize = true;
            this.lblCostoReservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoReservacion.Location = new System.Drawing.Point(440, 310);
            this.lblCostoReservacion.Name = "lblCostoReservacion";
            this.lblCostoReservacion.Size = new System.Drawing.Size(34, 21);
            this.lblCostoReservacion.TabIndex = 96;
            this.lblCostoReservacion.Text = "--.--";
            // 
            // lblCostoEstacionamiento
            // 
            this.lblCostoEstacionamiento.AutoSize = true;
            this.lblCostoEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoEstacionamiento.Location = new System.Drawing.Point(440, 342);
            this.lblCostoEstacionamiento.Name = "lblCostoEstacionamiento";
            this.lblCostoEstacionamiento.Size = new System.Drawing.Size(34, 21);
            this.lblCostoEstacionamiento.TabIndex = 97;
            this.lblCostoEstacionamiento.Text = "--.--";
            // 
            // lblCostoSubtotal
            // 
            this.lblCostoSubtotal.AutoSize = true;
            this.lblCostoSubtotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoSubtotal.Location = new System.Drawing.Point(440, 378);
            this.lblCostoSubtotal.Name = "lblCostoSubtotal";
            this.lblCostoSubtotal.Size = new System.Drawing.Size(34, 21);
            this.lblCostoSubtotal.TabIndex = 98;
            this.lblCostoSubtotal.Text = "--.--";
            // 
            // lblCostoIVA
            // 
            this.lblCostoIVA.AutoSize = true;
            this.lblCostoIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoIVA.Location = new System.Drawing.Point(440, 409);
            this.lblCostoIVA.Name = "lblCostoIVA";
            this.lblCostoIVA.Size = new System.Drawing.Size(34, 21);
            this.lblCostoIVA.TabIndex = 99;
            this.lblCostoIVA.Text = "--.--";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(440, 441);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(34, 21);
            this.lblCostoTotal.TabIndex = 100;
            this.lblCostoTotal.Text = "--.--";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(129)))), ((int)(((byte)(209)))));
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(398, 532);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(175, 42);
            this.btnFacturar.TabIndex = 128;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // rdbSiEnvio
            // 
            this.rdbSiEnvio.AutoSize = true;
            this.rdbSiEnvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSiEnvio.Location = new System.Drawing.Point(265, 220);
            this.rdbSiEnvio.Name = "rdbSiEnvio";
            this.rdbSiEnvio.Size = new System.Drawing.Size(41, 25);
            this.rdbSiEnvio.TabIndex = 130;
            this.rdbSiEnvio.TabStop = true;
            this.rdbSiEnvio.Text = "SI";
            this.rdbSiEnvio.UseVisualStyleBackColor = true;
            // 
            // rdbNoEnvio
            // 
            this.rdbNoEnvio.AutoSize = true;
            this.rdbNoEnvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoEnvio.Location = new System.Drawing.Point(343, 220);
            this.rdbNoEnvio.Name = "rdbNoEnvio";
            this.rdbNoEnvio.Size = new System.Drawing.Size(54, 25);
            this.rdbNoEnvio.TabIndex = 131;
            this.rdbNoEnvio.TabStop = true;
            this.rdbNoEnvio.Text = "NO";
            this.rdbNoEnvio.UseVisualStyleBackColor = true;
            // 
            // cmbIDEmpleado
            // 
            this.cmbIDEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDEmpleado.FormattingEnabled = true;
            this.cmbIDEmpleado.Location = new System.Drawing.Point(265, 95);
            this.cmbIDEmpleado.Name = "cmbIDEmpleado";
            this.cmbIDEmpleado.Size = new System.Drawing.Size(283, 28);
            this.cmbIDEmpleado.TabIndex = 135;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(162, 98);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 21);
            this.lblEmpleado.TabIndex = 134;
            this.lblEmpleado.Text = "Facturó:";
            // 
            // dgvDetallesReservacion
            // 
            this.dgvDetallesReservacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesReservacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmClaveHabitacion,
            this.clmCosto});
            this.dgvDetallesReservacion.Location = new System.Drawing.Point(589, 93);
            this.dgvDetallesReservacion.Name = "dgvDetallesReservacion";
            this.dgvDetallesReservacion.Size = new System.Drawing.Size(337, 240);
            this.dgvDetallesReservacion.TabIndex = 136;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Visible = false;
            // 
            // clmClaveHabitacion
            // 
            this.clmClaveHabitacion.HeaderText = "CLAVE HABITACIÓN";
            this.clmClaveHabitacion.Name = "clmClaveHabitacion";
            // 
            // clmCosto
            // 
            this.clmCosto.HeaderText = "COSTO";
            this.clmCosto.Name = "clmCosto";
            // 
            // dgvDetallesEstacionamiento
            // 
            this.dgvDetallesEstacionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesEstacionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesEstacionamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDEstacionamiento,
            this.clmTipoVehiculo,
            this.clmCostoEstacionamiento});
            this.dgvDetallesEstacionamiento.Location = new System.Drawing.Point(589, 363);
            this.dgvDetallesEstacionamiento.Name = "dgvDetallesEstacionamiento";
            this.dgvDetallesEstacionamiento.Size = new System.Drawing.Size(337, 102);
            this.dgvDetallesEstacionamiento.TabIndex = 137;
            // 
            // clmIDEstacionamiento
            // 
            this.clmIDEstacionamiento.HeaderText = "ID";
            this.clmIDEstacionamiento.Name = "clmIDEstacionamiento";
            this.clmIDEstacionamiento.Visible = false;
            // 
            // clmTipoVehiculo
            // 
            this.clmTipoVehiculo.HeaderText = "TIPO VEHICULO";
            this.clmTipoVehiculo.Name = "clmTipoVehiculo";
            // 
            // clmCostoEstacionamiento
            // 
            this.clmCostoEstacionamiento.HeaderText = "COSTO";
            this.clmCostoEstacionamiento.Name = "clmCostoEstacionamiento";
            // 
            // lblDetalleHabitaciones
            // 
            this.lblDetalleHabitaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleHabitaciones.AutoSize = true;
            this.lblDetalleHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleHabitaciones.Location = new System.Drawing.Point(676, 65);
            this.lblDetalleHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalleHabitaciones.Name = "lblDetalleHabitaciones";
            this.lblDetalleHabitaciones.Size = new System.Drawing.Size(169, 19);
            this.lblDetalleHabitaciones.TabIndex = 138;
            this.lblDetalleHabitaciones.Text = "Detalle Habitaciones";
            // 
            // lblDetalleEstacionamiento
            // 
            this.lblDetalleEstacionamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleEstacionamiento.AutoSize = true;
            this.lblDetalleEstacionamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleEstacionamiento.Location = new System.Drawing.Point(668, 339);
            this.lblDetalleEstacionamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalleEstacionamiento.Name = "lblDetalleEstacionamiento";
            this.lblDetalleEstacionamiento.Size = new System.Drawing.Size(195, 19);
            this.lblDetalleEstacionamiento.TabIndex = 139;
            this.lblDetalleEstacionamiento.Text = "Detalle Estacionamiento";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.lblDetalleEstacionamiento);
            this.Controls.Add(this.lblDetalleHabitaciones);
            this.Controls.Add(this.dgvDetallesEstacionamiento);
            this.Controls.Add(this.dgvDetallesReservacion);
            this.Controls.Add(this.cmbIDEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.rdbNoEnvio);
            this.Controls.Add(this.rdbSiEnvio);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.lblCostoIVA);
            this.Controls.Add(this.lblCostoSubtotal);
            this.Controls.Add(this.lblCostoEstacionamiento);
            this.Controls.Add(this.lblCostoReservacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReservacion);
            this.Controls.Add(this.cmbReservacion);
            this.Controls.Add(this.lblReservacionFacturar);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.dtpFechaFacturacion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEnvio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesEstacionamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.DateTimePicker dtpFechaFacturacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblReservacionFacturar;
        private System.Windows.Forms.ComboBox cmbReservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReservacion;
        private System.Windows.Forms.Label lblCostoReservacion;
        private System.Windows.Forms.Label lblCostoEstacionamiento;
        private System.Windows.Forms.Label lblCostoSubtotal;
        private System.Windows.Forms.Label lblCostoIVA;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.RadioButton rdbSiEnvio;
        private System.Windows.Forms.RadioButton rdbNoEnvio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbIDEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dgvDetallesReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClaveHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.DataGridView dgvDetallesEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoEstacionamiento;
        private System.Windows.Forms.Label lblDetalleHabitaciones;
        private System.Windows.Forms.Label lblDetalleEstacionamiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}