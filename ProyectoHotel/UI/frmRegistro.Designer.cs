
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.pnlLogoRegistro = new System.Windows.Forms.Panel();
            this.pcbLogoRegistro = new System.Windows.Forms.PictureBox();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.txtEmail = new AltoControls.AltoTextBox();
            this.txtTelefono = new AltoControls.AltoTextBox();
            this.txtRFC = new AltoControls.AltoTextBox();
            this.txtApellidoMaterno = new AltoControls.AltoTextBox();
            this.txtApellidoParterno = new AltoControls.AltoTextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblAreaTrabajo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNombre = new AltoControls.AltoTextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.txtRegistrarUsuario = new AltoControls.AltoTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContrasena = new AltoControls.AltoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altoTextBox9 = new AltoControls.AltoTextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.cmbAreaTrabajo = new System.Windows.Forms.ComboBox();
            this.txtPuesto = new System.Windows.Forms.ComboBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.pnlLogoRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoRegistro)).BeginInit();
            this.pnlRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.grbUsuario.SuspendLayout();
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
            this.pnlLogoRegistro.Size = new System.Drawing.Size(279, 590);
            this.pnlLogoRegistro.TabIndex = 0;
            this.pnlLogoRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogoRegistro_MouseDown);
            // 
            // pcbLogoRegistro
            // 
            this.pcbLogoRegistro.Image = global::UI.Properties.Resources.iconoHotel;
            this.pcbLogoRegistro.Location = new System.Drawing.Point(32, 163);
            this.pcbLogoRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogoRegistro.Name = "pcbLogoRegistro";
            this.pcbLogoRegistro.Size = new System.Drawing.Size(210, 228);
            this.pcbLogoRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoRegistro.TabIndex = 0;
            this.pcbLogoRegistro.TabStop = false;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.btnRegistrarse);
            this.pnlRegistro.Controls.Add(this.txtPuesto);
            this.pnlRegistro.Controls.Add(this.cmbAreaTrabajo);
            this.pnlRegistro.Controls.Add(this.grbUsuario);
            this.pnlRegistro.Controls.Add(this.txtEmail);
            this.pnlRegistro.Controls.Add(this.txtTelefono);
            this.pnlRegistro.Controls.Add(this.txtRFC);
            this.pnlRegistro.Controls.Add(this.txtApellidoMaterno);
            this.pnlRegistro.Controls.Add(this.txtApellidoParterno);
            this.pnlRegistro.Controls.Add(this.lblPuesto);
            this.pnlRegistro.Controls.Add(this.lblAreaTrabajo);
            this.pnlRegistro.Controls.Add(this.lblEmail);
            this.pnlRegistro.Controls.Add(this.lblTelefono);
            this.pnlRegistro.Controls.Add(this.lblRFC);
            this.pnlRegistro.Controls.Add(this.lblApellidoMaterno);
            this.pnlRegistro.Controls.Add(this.lblApellidoPaterno);
            this.pnlRegistro.Controls.Add(this.lblNombreEmpleado);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.lblRegistro);
            this.pnlRegistro.Controls.Add(this.btnCerrar);
            this.pnlRegistro.Controls.Add(this.btnMinimizar);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Location = new System.Drawing.Point(279, 0);
            this.pnlRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(499, 590);
            this.pnlRegistro.TabIndex = 1;
            this.pnlRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRegistro_MouseDown);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Br = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(212, 280);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 27);
            this.txtEmail.TabIndex = 38;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Br = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(212, 243);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 27);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.Color.Transparent;
            this.txtRFC.Br = System.Drawing.Color.White;
            this.txtRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.DimGray;
            this.txtRFC.Location = new System.Drawing.Point(211, 201);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(2);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(230, 27);
            this.txtRFC.TabIndex = 36;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoMaterno.Br = System.Drawing.Color.White;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(211, 156);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(230, 27);
            this.txtApellidoMaterno.TabIndex = 35;
            // 
            // txtApellidoParterno
            // 
            this.txtApellidoParterno.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoParterno.Br = System.Drawing.Color.White;
            this.txtApellidoParterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoParterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoParterno.Location = new System.Drawing.Point(211, 111);
            this.txtApellidoParterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoParterno.Name = "txtApellidoParterno";
            this.txtApellidoParterno.Size = new System.Drawing.Size(230, 27);
            this.txtApellidoParterno.TabIndex = 34;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(136, 371);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(58, 19);
            this.lblPuesto.TabIndex = 33;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblAreaTrabajo
            // 
            this.lblAreaTrabajo.AutoSize = true;
            this.lblAreaTrabajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTrabajo.Location = new System.Drawing.Point(89, 330);
            this.lblAreaTrabajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaTrabajo.Name = "lblAreaTrabajo";
            this.lblAreaTrabajo.Size = new System.Drawing.Size(107, 19);
            this.lblAreaTrabajo.TabIndex = 32;
            this.lblAreaTrabajo.Text = "Área trabajo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(136, 286);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 19);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(124, 247);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 19);
            this.lblTelefono.TabIndex = 30;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Location = new System.Drawing.Point(156, 207);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(38, 19);
            this.lblRFC.TabIndex = 29;
            this.lblRFC.Text = "RFC";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(54, 160);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(145, 19);
            this.lblApellidoMaterno.TabIndex = 28;
            this.lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(59, 115);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(140, 19);
            this.lblApellidoPaterno.TabIndex = 27;
            this.lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(120, 68);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(73, 19);
            this.lblNombreEmpleado.TabIndex = 26;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Br = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(211, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 27);
            this.txtNombre.TabIndex = 25;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(177, 24);
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
            this.btnCerrar.Location = new System.Drawing.Point(473, 11);
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
            this.btnMinimizar.Location = new System.Drawing.Point(452, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 22;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.altoTextBox9);
            this.grbUsuario.Controls.Add(this.lblConfirmarContrasena);
            this.grbUsuario.Controls.Add(this.txtContrasena);
            this.grbUsuario.Controls.Add(this.label1);
            this.grbUsuario.Controls.Add(this.txtRegistrarUsuario);
            this.grbUsuario.Controls.Add(this.lblUsuario);
            this.grbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsuario.Location = new System.Drawing.Point(28, 398);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(446, 127);
            this.grbUsuario.TabIndex = 41;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Usuario";
            // 
            // txtRegistrarUsuario
            // 
            this.txtRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistrarUsuario.Br = System.Drawing.Color.White;
            this.txtRegistrarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtRegistrarUsuario.Location = new System.Drawing.Point(142, 21);
            this.txtRegistrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistrarUsuario.Name = "txtRegistrarUsuario";
            this.txtRegistrarUsuario.Size = new System.Drawing.Size(237, 27);
            this.txtRegistrarUsuario.TabIndex = 43;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(73, 26);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasena.Br = System.Drawing.Color.White;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrasena.Location = new System.Drawing.Point(146, 59);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(115, 27);
            this.txtContrasena.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Contraseña";
            // 
            // altoTextBox9
            // 
            this.altoTextBox9.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox9.Br = System.Drawing.Color.White;
            this.altoTextBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoTextBox9.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox9.Location = new System.Drawing.Point(221, 95);
            this.altoTextBox9.Margin = new System.Windows.Forms.Padding(2);
            this.altoTextBox9.Name = "altoTextBox9";
            this.altoTextBox9.Size = new System.Drawing.Size(115, 27);
            this.altoTextBox9.TabIndex = 47;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(40, 103);
            this.lblConfirmarContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(177, 19);
            this.lblConfirmarContrasena.TabIndex = 46;
            this.lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // cmbAreaTrabajo
            // 
            this.cmbAreaTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaTrabajo.FormattingEnabled = true;
            this.cmbAreaTrabajo.Location = new System.Drawing.Point(212, 327);
            this.cmbAreaTrabajo.Name = "cmbAreaTrabajo";
            this.cmbAreaTrabajo.Size = new System.Drawing.Size(175, 28);
            this.cmbAreaTrabajo.TabIndex = 42;
            // 
            // txtPuesto
            // 
            this.txtPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.FormattingEnabled = true;
            this.txtPuesto.Location = new System.Drawing.Point(211, 371);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(175, 28);
            this.txtPuesto.TabIndex = 43;
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
            this.btnRegistrarse.Location = new System.Drawing.Point(353, 544);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(121, 34);
            this.btnRegistrarse.TabIndex = 44;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 590);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogoRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.PictureBox pcbLogoRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private AltoControls.AltoTextBox txtNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblAreaTrabajo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private AltoControls.AltoTextBox txtEmail;
        private AltoControls.AltoTextBox txtTelefono;
        private AltoControls.AltoTextBox txtRFC;
        private AltoControls.AltoTextBox txtApellidoMaterno;
        private AltoControls.AltoTextBox txtApellidoParterno;
        private System.Windows.Forms.GroupBox grbUsuario;
        private AltoControls.AltoTextBox altoTextBox9;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private AltoControls.AltoTextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoTextBox txtRegistrarUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox txtPuesto;
        private System.Windows.Forms.ComboBox cmbAreaTrabajo;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}