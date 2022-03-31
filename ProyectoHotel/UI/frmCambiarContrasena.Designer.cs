
namespace UI
{
    partial class frmCambiarContrasena
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
            this.barraLogin = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblCambiarContrasena = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlLogoLogin = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblConfirmeContrasena = new System.Windows.Forms.Label();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtConfirmacionContrasena = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.pcbBloquearNC = new System.Windows.Forms.PictureBox();
            this.pcbDesbloquearNC = new System.Windows.Forms.PictureBox();
            this.pcbBloquerCC = new System.Windows.Forms.PictureBox();
            this.pcbDesbloquearCC = new System.Windows.Forms.PictureBox();
            this.barraLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.pnlLogoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBloquearNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDesbloquearNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBloquerCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDesbloquearCC)).BeginInit();
            this.SuspendLayout();
            // 
            // barraLogin
            // 
            this.barraLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.barraLogin.Controls.Add(this.btnCerrar);
            this.barraLogin.Controls.Add(this.lblCambiarContrasena);
            this.barraLogin.Controls.Add(this.btnMinimizar);
            this.barraLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraLogin.Location = new System.Drawing.Point(333, 0);
            this.barraLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barraLogin.Name = "barraLogin";
            this.barraLogin.Size = new System.Drawing.Size(707, 37);
            this.barraLogin.TabIndex = 21;
            this.barraLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraLogin_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.boton_de_quitar_cuadrado;
            this.btnCerrar.Location = new System.Drawing.Point(675, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCambiarContrasena
            // 
            this.lblCambiarContrasena.AutoSize = true;
            this.lblCambiarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContrasena.ForeColor = System.Drawing.Color.White;
            this.lblCambiarContrasena.Location = new System.Drawing.Point(235, 9);
            this.lblCambiarContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambiarContrasena.Name = "lblCambiarContrasena";
            this.lblCambiarContrasena.Size = new System.Drawing.Size(211, 23);
            this.lblCambiarContrasena.TabIndex = 13;
            this.lblCambiarContrasena.Text = "Cambiar contraseña";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::UI.Properties.Resources.minimizar1;
            this.btnMinimizar.Location = new System.Drawing.Point(645, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pnlLogoLogin
            // 
            this.pnlLogoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.pnlLogoLogin.Controls.Add(this.pictureBox3);
            this.pnlLogoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogoLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogoLogin.Name = "pnlLogoLogin";
            this.pnlLogoLogin.Size = new System.Drawing.Size(333, 406);
            this.pnlLogoLogin.TabIndex = 20;
            this.pnlLogoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogoLogin_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.iconoHotel;
            this.pictureBox3.Location = new System.Drawing.Point(4, 59);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(325, 262);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblConfirmeContrasena
            // 
            this.lblConfirmeContrasena.AutoSize = true;
            this.lblConfirmeContrasena.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblConfirmeContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmeContrasena.Location = new System.Drawing.Point(413, 186);
            this.lblConfirmeContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmeContrasena.Name = "lblConfirmeContrasena";
            this.lblConfirmeContrasena.Size = new System.Drawing.Size(216, 23);
            this.lblConfirmeContrasena.TabIndex = 27;
            this.lblConfirmeContrasena.Text = "Confirme contraseña";
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNuevaContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(413, 102);
            this.lblNuevaContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(195, 23);
            this.lblNuevaContrasena.TabIndex = 26;
            this.lblNuevaContrasena.Text = "Nueva contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(419, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(256, 52);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(701, 287);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 52);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtConfirmacionContrasena
            // 
            this.txtConfirmacionContrasena.BackColor = System.Drawing.Color.White;
            this.txtConfirmacionContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacionContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmacionContrasena.Location = new System.Drawing.Point(420, 215);
            this.txtConfirmacionContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmacionContrasena.MaxLength = 16;
            this.txtConfirmacionContrasena.Name = "txtConfirmacionContrasena";
            this.txtConfirmacionContrasena.Size = new System.Drawing.Size(543, 32);
            this.txtConfirmacionContrasena.TabIndex = 23;
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.BackColor = System.Drawing.Color.White;
            this.txtNuevaContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtNuevaContrasena.Location = new System.Drawing.Point(419, 132);
            this.txtNuevaContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevaContrasena.MaxLength = 16;
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(543, 32);
            this.txtNuevaContrasena.TabIndex = 22;
            // 
            // pcbBloquearNC
            // 
            this.pcbBloquearNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBloquearNC.Image = global::UI.Properties.Resources.bloquear;
            this.pcbBloquearNC.Location = new System.Drawing.Point(970, 125);
            this.pcbBloquearNC.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBloquearNC.Name = "pcbBloquearNC";
            this.pcbBloquearNC.Size = new System.Drawing.Size(47, 43);
            this.pcbBloquearNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBloquearNC.TabIndex = 29;
            this.pcbBloquearNC.TabStop = false;
            // 
            // pcbDesbloquearNC
            // 
            this.pcbDesbloquearNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDesbloquearNC.Image = global::UI.Properties.Resources.desbloquear;
            this.pcbDesbloquearNC.Location = new System.Drawing.Point(970, 125);
            this.pcbDesbloquearNC.Margin = new System.Windows.Forms.Padding(4);
            this.pcbDesbloquearNC.Name = "pcbDesbloquearNC";
            this.pcbDesbloquearNC.Size = new System.Drawing.Size(47, 43);
            this.pcbDesbloquearNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDesbloquearNC.TabIndex = 28;
            this.pcbDesbloquearNC.TabStop = false;
            this.pcbDesbloquearNC.Visible = false;
            // 
            // pcbBloquerCC
            // 
            this.pcbBloquerCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBloquerCC.Image = global::UI.Properties.Resources.bloquear;
            this.pcbBloquerCC.Location = new System.Drawing.Point(970, 212);
            this.pcbBloquerCC.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBloquerCC.Name = "pcbBloquerCC";
            this.pcbBloquerCC.Size = new System.Drawing.Size(47, 43);
            this.pcbBloquerCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBloquerCC.TabIndex = 31;
            this.pcbBloquerCC.TabStop = false;
            // 
            // pcbDesbloquearCC
            // 
            this.pcbDesbloquearCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDesbloquearCC.Image = global::UI.Properties.Resources.desbloquear;
            this.pcbDesbloquearCC.Location = new System.Drawing.Point(970, 212);
            this.pcbDesbloquearCC.Margin = new System.Windows.Forms.Padding(4);
            this.pcbDesbloquearCC.Name = "pcbDesbloquearCC";
            this.pcbDesbloquearCC.Size = new System.Drawing.Size(47, 43);
            this.pcbDesbloquearCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDesbloquearCC.TabIndex = 30;
            this.pcbDesbloquearCC.TabStop = false;
            this.pcbDesbloquearCC.Visible = false;
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 406);
            this.Controls.Add(this.pcbBloquerCC);
            this.Controls.Add(this.pcbDesbloquearCC);
            this.Controls.Add(this.pcbBloquearNC);
            this.Controls.Add(this.pcbDesbloquearNC);
            this.Controls.Add(this.lblConfirmeContrasena);
            this.Controls.Add(this.lblNuevaContrasena);
            this.Controls.Add(this.barraLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlLogoLogin);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.txtConfirmacionContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCambiarContrasena";
            this.Opacity = 0.95D;
            this.Text = "frmCambiarContrasena";
            this.barraLogin.ResumeLayout(false);
            this.barraLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.pnlLogoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBloquearNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDesbloquearNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBloquerCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDesbloquearCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraLogin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblCambiarContrasena;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlLogoLogin;
        private System.Windows.Forms.Label lblConfirmeContrasena;
        private System.Windows.Forms.Label lblNuevaContrasena;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtConfirmacionContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.PictureBox pcbBloquearNC;
        private System.Windows.Forms.PictureBox pcbDesbloquearNC;
        private System.Windows.Forms.PictureBox pcbBloquerCC;
        private System.Windows.Forms.PictureBox pcbDesbloquearCC;
    }
}