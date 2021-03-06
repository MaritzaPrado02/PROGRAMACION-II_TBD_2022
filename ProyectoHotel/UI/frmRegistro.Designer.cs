
namespace UI
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.pnlLogoRegistro = new System.Windows.Forms.Panel();
            this.pcbLogoRegistro = new System.Windows.Forms.PictureBox();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.cmbAreaTrabajo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new AltoControls.AltoTextBox();
            this.txtTelefono = new AltoControls.AltoTextBox();
            this.txtRFC = new AltoControls.AltoTextBox();
            this.txtApellidoMaterno = new AltoControls.AltoTextBox();
            this.txtApellidoPaterno = new AltoControls.AltoTextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblAreaTrabajo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNombre = new AltoControls.AltoTextBox();
            this.grbDireccion = new System.Windows.Forms.GroupBox();
            this.txtCP = new AltoControls.AltoTextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNumero = new AltoControls.AltoTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtColonia = new AltoControls.AltoTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.txtCalle = new AltoControls.AltoTextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.txtConfirmarContrasena = new AltoControls.AltoTextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new AltoControls.AltoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistrarUsuario = new AltoControls.AltoTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLogoRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoRegistro)).BeginInit();
            this.pnlRegistro.SuspendLayout();
            this.grbDatosGenerales.SuspendLayout();
            this.grbDireccion.SuspendLayout();
            this.grbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogoRegistro
            // 
            this.pnlLogoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.pnlLogoRegistro.Controls.Add(this.pcbLogoRegistro);
            this.pnlLogoRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogoRegistro.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogoRegistro.Name = "pnlLogoRegistro";
            this.pnlLogoRegistro.Size = new System.Drawing.Size(254, 680);
            this.pnlLogoRegistro.TabIndex = 0;
            this.pnlLogoRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogoRegistro_MouseDown);
            // 
            // pcbLogoRegistro
            // 
            this.pcbLogoRegistro.Image = global::UI.Properties.Resources.iconoHotel;
            this.pcbLogoRegistro.Location = new System.Drawing.Point(11, 163);
            this.pcbLogoRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogoRegistro.Name = "pcbLogoRegistro";
            this.pcbLogoRegistro.Size = new System.Drawing.Size(210, 228);
            this.pcbLogoRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoRegistro.TabIndex = 0;
            this.pcbLogoRegistro.TabStop = false;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.White;
            this.pnlRegistro.Controls.Add(this.grbDatosGenerales);
            this.pnlRegistro.Controls.Add(this.grbDireccion);
            this.pnlRegistro.Controls.Add(this.btnRegistrarse);
            this.pnlRegistro.Controls.Add(this.grbUsuario);
            this.pnlRegistro.Controls.Add(this.lblRegistro);
            this.pnlRegistro.Controls.Add(this.btnCerrar);
            this.pnlRegistro.Controls.Add(this.btnMinimizar);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistro.Location = new System.Drawing.Point(254, 0);
            this.pnlRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(946, 680);
            this.pnlRegistro.TabIndex = 1;
            this.pnlRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRegistro_MouseDown);
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.cmbPuesto);
            this.grbDatosGenerales.Controls.Add(this.cmbAreaTrabajo);
            this.grbDatosGenerales.Controls.Add(this.txtEmail);
            this.grbDatosGenerales.Controls.Add(this.txtTelefono);
            this.grbDatosGenerales.Controls.Add(this.txtRFC);
            this.grbDatosGenerales.Controls.Add(this.txtApellidoMaterno);
            this.grbDatosGenerales.Controls.Add(this.txtApellidoPaterno);
            this.grbDatosGenerales.Controls.Add(this.lblPuesto);
            this.grbDatosGenerales.Controls.Add(this.lblAreaTrabajo);
            this.grbDatosGenerales.Controls.Add(this.lblEmail);
            this.grbDatosGenerales.Controls.Add(this.lblTelefono);
            this.grbDatosGenerales.Controls.Add(this.lblRFC);
            this.grbDatosGenerales.Controls.Add(this.lblApellidoMaterno);
            this.grbDatosGenerales.Controls.Add(this.lblApellidoPaterno);
            this.grbDatosGenerales.Controls.Add(this.lblNombreEmpleado);
            this.grbDatosGenerales.Controls.Add(this.txtNombre);
            this.grbDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosGenerales.Location = new System.Drawing.Point(53, 86);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(422, 422);
            this.grbDatosGenerales.TabIndex = 131;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Generales";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(170, 351);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(175, 28);
            this.cmbPuesto.TabIndex = 59;
            // 
            // cmbAreaTrabajo
            // 
            this.cmbAreaTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaTrabajo.FormattingEnabled = true;
            this.cmbAreaTrabajo.Location = new System.Drawing.Point(170, 307);
            this.cmbAreaTrabajo.Name = "cmbAreaTrabajo";
            this.cmbAreaTrabajo.Size = new System.Drawing.Size(175, 28);
            this.cmbAreaTrabajo.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Br = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(170, 260);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 27);
            this.txtEmail.TabIndex = 57;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Br = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(170, 223);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 27);
            this.txtTelefono.TabIndex = 56;
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.Color.Transparent;
            this.txtRFC.Br = System.Drawing.Color.White;
            this.txtRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.DimGray;
            this.txtRFC.Location = new System.Drawing.Point(170, 181);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(2);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(230, 27);
            this.txtRFC.TabIndex = 55;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoMaterno.Br = System.Drawing.Color.White;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(170, 136);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(230, 27);
            this.txtApellidoMaterno.TabIndex = 54;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoPaterno.Br = System.Drawing.Color.White;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(170, 91);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(230, 27);
            this.txtApellidoPaterno.TabIndex = 53;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(94, 351);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(58, 19);
            this.lblPuesto.TabIndex = 52;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblAreaTrabajo
            // 
            this.lblAreaTrabajo.AutoSize = true;
            this.lblAreaTrabajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTrabajo.Location = new System.Drawing.Point(47, 310);
            this.lblAreaTrabajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaTrabajo.Name = "lblAreaTrabajo";
            this.lblAreaTrabajo.Size = new System.Drawing.Size(107, 19);
            this.lblAreaTrabajo.TabIndex = 51;
            this.lblAreaTrabajo.Text = "Área trabajo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(94, 266);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 19);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(82, 227);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 19);
            this.lblTelefono.TabIndex = 49;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Location = new System.Drawing.Point(114, 187);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(38, 19);
            this.lblRFC.TabIndex = 48;
            this.lblRFC.Text = "RFC";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(12, 140);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(145, 19);
            this.lblApellidoMaterno.TabIndex = 47;
            this.lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(17, 95);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(140, 19);
            this.lblApellidoPaterno.TabIndex = 46;
            this.lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(78, 48);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(73, 19);
            this.lblNombreEmpleado.TabIndex = 45;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Br = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(170, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 27);
            this.txtNombre.TabIndex = 44;
            // 
            // grbDireccion
            // 
            this.grbDireccion.Controls.Add(this.txtCP);
            this.grbDireccion.Controls.Add(this.lblCP);
            this.grbDireccion.Controls.Add(this.cmbMunicipio);
            this.grbDireccion.Controls.Add(this.lblMunicipio);
            this.grbDireccion.Controls.Add(this.cmbEstado);
            this.grbDireccion.Controls.Add(this.txtNumero);
            this.grbDireccion.Controls.Add(this.lblEstado);
            this.grbDireccion.Controls.Add(this.txtColonia);
            this.grbDireccion.Controls.Add(this.lblNumero);
            this.grbDireccion.Controls.Add(this.lblColonia);
            this.grbDireccion.Controls.Add(this.txtCalle);
            this.grbDireccion.Controls.Add(this.lblCalle);
            this.grbDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDireccion.Location = new System.Drawing.Point(481, 229);
            this.grbDireccion.Name = "grbDireccion";
            this.grbDireccion.Size = new System.Drawing.Size(438, 279);
            this.grbDireccion.TabIndex = 125;
            this.grbDireccion.TabStop = false;
            this.grbDireccion.Text = "Dirección";
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.Transparent;
            this.txtCP.Br = System.Drawing.Color.White;
            this.txtCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.ForeColor = System.Drawing.Color.DimGray;
            this.txtCP.Location = new System.Drawing.Point(188, 98);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(205, 33);
            this.txtCP.TabIndex = 132;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(119, 103);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(32, 21);
            this.lblCP.TabIndex = 131;
            this.lblCP.Text = "CP";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(189, 63);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(205, 29);
            this.cmbMunicipio.TabIndex = 130;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(91, 67);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(85, 21);
            this.lblMunicipio.TabIndex = 129;
            this.lblMunicipio.Text = "Municipio";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(189, 26);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(205, 29);
            this.cmbEstado.TabIndex = 128;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.Transparent;
            this.txtNumero.Br = System.Drawing.Color.White;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumero.Location = new System.Drawing.Point(188, 231);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(205, 33);
            this.txtNumero.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(110, 30);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 21);
            this.lblEstado.TabIndex = 127;
            this.lblEstado.Text = "Estado";
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.Transparent;
            this.txtColonia.Br = System.Drawing.Color.White;
            this.txtColonia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.ForeColor = System.Drawing.Color.DimGray;
            this.txtColonia.Location = new System.Drawing.Point(188, 187);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(205, 33);
            this.txtColonia.TabIndex = 26;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(99, 238);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(72, 21);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Número";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(104, 192);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(70, 21);
            this.lblColonia.TabIndex = 23;
            this.lblColonia.Text = "Colonia";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.Transparent;
            this.txtCalle.Br = System.Drawing.Color.White;
            this.txtCalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.ForeColor = System.Drawing.Color.DimGray;
            this.txtCalle.Location = new System.Drawing.Point(188, 142);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(205, 33);
            this.txtCalle.TabIndex = 20;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(119, 148);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(50, 21);
            this.lblCalle.TabIndex = 13;
            this.lblCalle.Text = "Calle";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistrarse.Location = new System.Drawing.Point(419, 572);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(121, 34);
            this.btnRegistrarse.TabIndex = 44;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.txtConfirmarContrasena);
            this.grbUsuario.Controls.Add(this.lblConfirmarContrasena);
            this.grbUsuario.Controls.Add(this.txtContrasena);
            this.grbUsuario.Controls.Add(this.label1);
            this.grbUsuario.Controls.Add(this.txtRegistrarUsuario);
            this.grbUsuario.Controls.Add(this.lblUsuario);
            this.grbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsuario.Location = new System.Drawing.Point(481, 86);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(438, 127);
            this.grbUsuario.TabIndex = 41;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Usuario";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmarContrasena.Br = System.Drawing.Color.White;
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(186, 95);
            this.txtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(228, 27);
            this.txtConfirmarContrasena.TabIndex = 47;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(5, 100);
            this.lblConfirmarContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(177, 19);
            this.lblConfirmarContrasena.TabIndex = 46;
            this.lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasena.Br = System.Drawing.Color.White;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrasena.Location = new System.Drawing.Point(184, 59);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(229, 27);
            this.txtContrasena.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Contraseña";
            // 
            // txtRegistrarUsuario
            // 
            this.txtRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistrarUsuario.Br = System.Drawing.Color.White;
            this.txtRegistrarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtRegistrarUsuario.Location = new System.Drawing.Point(184, 21);
            this.txtRegistrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistrarUsuario.Name = "txtRegistrarUsuario";
            this.txtRegistrarUsuario.Size = new System.Drawing.Size(230, 27);
            this.txtRegistrarUsuario.TabIndex = 43;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(111, 29);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(397, 22);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(163, 23);
            this.lblRegistro.TabIndex = 24;
            this.lblRegistro.Text = "Registrar Usuario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(913, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::UI.Properties.Resources.minimizar__1_;
            this.btnMinimizar.Location = new System.Drawing.Point(887, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 22;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.pnlLogoRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistro";
            this.Opacity = 0.9D;
            this.Text = "frmRegistro";
            this.pnlLogoRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoRegistro)).EndInit();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            this.grbDireccion.ResumeLayout(false);
            this.grbDireccion.PerformLayout();
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogoRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.PictureBox pcbLogoRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.GroupBox grbUsuario;
        private AltoControls.AltoTextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private AltoControls.AltoTextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoTextBox txtRegistrarUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.ComboBox cmbAreaTrabajo;
        private AltoControls.AltoTextBox txtEmail;
        private AltoControls.AltoTextBox txtTelefono;
        private AltoControls.AltoTextBox txtRFC;
        private AltoControls.AltoTextBox txtApellidoMaterno;
        private AltoControls.AltoTextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblAreaTrabajo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private AltoControls.AltoTextBox txtNombre;
        private System.Windows.Forms.GroupBox grbDireccion;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cmbEstado;
        private AltoControls.AltoTextBox txtNumero;
        private System.Windows.Forms.Label lblEstado;
        private AltoControls.AltoTextBox txtColonia;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblColonia;
        private AltoControls.AltoTextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private AltoControls.AltoTextBox txtCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}