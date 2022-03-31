
namespace UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogoLogin = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.barraLogin = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.pcbDesbloquear = new System.Windows.Forms.PictureBox();
            this.pcbBloquear = new System.Windows.Forms.PictureBox();
            this.pnlLogoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.barraLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDesbloquear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBloquear)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogoLogin
            // 
            this.pnlLogoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.pnlLogoLogin.Controls.Add(this.pictureBox3);
            this.pnlLogoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogoLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogoLogin.Name = "pnlLogoLogin";
            this.pnlLogoLogin.Size = new System.Drawing.Size(333, 406);
            this.pnlLogoLogin.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.iconoHotel;
            this.pictureBox3.Location = new System.Drawing.Point(4, 59);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(325, 262);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(417, 80);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(116, 30);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(417, 181);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(175, 30);
            this.lblContrasena.TabIndex = 12;
            this.lblContrasena.Text = "CONTRASEÑA";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(495, 274);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(404, 46);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(421, 123);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(544, 32);
            this.txtUser.TabIndex = 17;
            this.txtUser.Text = "Ingrese nombre de usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(421, 224);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(544, 32);
            this.txtPass.TabIndex = 18;
            this.txtPass.Text = "Ingrese contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // barraLogin
            // 
            this.barraLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.barraLogin.Controls.Add(this.btnCerrar);
            this.barraLogin.Controls.Add(this.lblBienvenido);
            this.barraLogin.Controls.Add(this.btnMinimizar);
            this.barraLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraLogin.Location = new System.Drawing.Point(333, 0);
            this.barraLogin.Margin = new System.Windows.Forms.Padding(4);
            this.barraLogin.Name = "barraLogin";
            this.barraLogin.Size = new System.Drawing.Size(707, 37);
            this.barraLogin.TabIndex = 19;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.boton_de_quitar_cuadrado;
            this.btnCerrar.Location = new System.Drawing.Point(675, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(284, 9);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(119, 23);
            this.lblBienvenido.TabIndex = 13;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::UI.Properties.Resources.minimizar1;
            this.btnMinimizar.Location = new System.Drawing.Point(645, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.LinkColor = System.Drawing.Color.Black;
            this.linkPass.Location = new System.Drawing.Point(576, 334);
            this.linkPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(255, 21);
            this.linkPass.TabIndex = 20;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "¿Ha olvidado la contraseña?";
            this.linkPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPass_LinkClicked);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistrarse.Location = new System.Drawing.Point(633, 364);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(133, 32);
            this.btnRegistrarse.TabIndex = 21;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // pcbDesbloquear
            // 
            this.pcbDesbloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDesbloquear.Image = global::UI.Properties.Resources.desbloquear;
            this.pcbDesbloquear.Location = new System.Drawing.Point(976, 219);
            this.pcbDesbloquear.Margin = new System.Windows.Forms.Padding(4);
            this.pcbDesbloquear.Name = "pcbDesbloquear";
            this.pcbDesbloquear.Size = new System.Drawing.Size(47, 43);
            this.pcbDesbloquear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDesbloquear.TabIndex = 23;
            this.pcbDesbloquear.TabStop = false;
            this.pcbDesbloquear.Visible = false;
            this.pcbDesbloquear.Click += new System.EventHandler(this.pcbDesbloquear_Click);
            // 
            // pcbBloquear
            // 
            this.pcbBloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBloquear.Image = global::UI.Properties.Resources.bloquear;
            this.pcbBloquear.Location = new System.Drawing.Point(976, 219);
            this.pcbBloquear.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBloquear.Name = "pcbBloquear";
            this.pcbBloquear.Size = new System.Drawing.Size(47, 43);
            this.pcbBloquear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBloquear.TabIndex = 24;
            this.pcbBloquear.TabStop = false;
            this.pcbBloquear.Click += new System.EventHandler(this.pcbBloquer_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(151)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 406);
            this.Controls.Add(this.pcbBloquear);
            this.Controls.Add(this.pcbDesbloquear);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.linkPass);
            this.Controls.Add(this.barraLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.Text = "frmLogin";
            this.pnlLogoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.barraLogin.ResumeLayout(false);
            this.barraLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDesbloquear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBloquear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogoLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel barraLogin;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.PictureBox pcbDesbloquear;
        private System.Windows.Forms.PictureBox pcbBloquear;
    }
}