
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
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.btnBloquearNC = new System.Windows.Forms.PictureBox();
            this.btnDesbloquearNC = new System.Windows.Forms.PictureBox();
            this.btnBloquerCC = new System.Windows.Forms.PictureBox();
            this.btnDesbloquearCC = new System.Windows.Forms.PictureBox();
            this.barraLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.pnlLogoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBloquearNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesbloquearNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBloquerCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesbloquearCC)).BeginInit();
            this.SuspendLayout();
            // 
            // barraLogin
            // 
            this.barraLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.barraLogin.Controls.Add(this.btnCerrar);
            this.barraLogin.Controls.Add(this.lblCambiarContrasena);
            this.barraLogin.Controls.Add(this.btnMinimizar);
            this.barraLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraLogin.Location = new System.Drawing.Point(250, 0);
            this.barraLogin.Name = "barraLogin";
            this.barraLogin.Size = new System.Drawing.Size(530, 30);
            this.barraLogin.TabIndex = 21;
            this.barraLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraLogin_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.boton_de_quitar_cuadrado;
            this.btnCerrar.Location = new System.Drawing.Point(506, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
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
            this.lblCambiarContrasena.Location = new System.Drawing.Point(176, 7);
            this.lblCambiarContrasena.Name = "lblCambiarContrasena";
            this.lblCambiarContrasena.Size = new System.Drawing.Size(170, 19);
            this.lblCambiarContrasena.TabIndex = 13;
            this.lblCambiarContrasena.Text = "Cambiar contraseña";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::UI.Properties.Resources.minimizar1;
            this.btnMinimizar.Location = new System.Drawing.Point(484, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
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
            this.pnlLogoLogin.Name = "pnlLogoLogin";
            this.pnlLogoLogin.Size = new System.Drawing.Size(250, 330);
            this.pnlLogoLogin.TabIndex = 20;
            this.pnlLogoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogoLogin_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.iconoHotel;
            this.pictureBox3.Location = new System.Drawing.Point(3, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 213);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblConfirmeContrasena
            // 
            this.lblConfirmeContrasena.AutoSize = true;
            this.lblConfirmeContrasena.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblConfirmeContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmeContrasena.Location = new System.Drawing.Point(310, 151);
            this.lblConfirmeContrasena.Name = "lblConfirmeContrasena";
            this.lblConfirmeContrasena.Size = new System.Drawing.Size(175, 21);
            this.lblConfirmeContrasena.TabIndex = 27;
            this.lblConfirmeContrasena.Text = "Confirme contraseña";
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNuevaContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(310, 83);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(157, 21);
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
            this.btnCancelar.Location = new System.Drawing.Point(314, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 42);
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
            this.btnGuardar.Location = new System.Drawing.Point(526, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(192, 42);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(315, 175);
            this.txtConfirmarContrasena.MaxLength = 16;
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(408, 27);
            this.txtConfirmarContrasena.TabIndex = 23;
            this.txtConfirmarContrasena.Text = "Confirme contraseña";
            this.txtConfirmarContrasena.Enter += new System.EventHandler(this.txtConfirmarContrasena_Enter);
            this.txtConfirmarContrasena.Leave += new System.EventHandler(this.txtConfirmarContrasena_Leave);
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.BackColor = System.Drawing.Color.White;
            this.txtNuevaContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtNuevaContrasena.Location = new System.Drawing.Point(314, 107);
            this.txtNuevaContrasena.MaxLength = 16;
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(408, 27);
            this.txtNuevaContrasena.TabIndex = 22;
            this.txtNuevaContrasena.Text = "Ingrese nueva contraseña";
            this.txtNuevaContrasena.Enter += new System.EventHandler(this.txtNuevaContrasena_Enter);
            this.txtNuevaContrasena.Leave += new System.EventHandler(this.txtNuevaContrasena_Leave);
            // 
            // btnBloquearNC
            // 
            this.btnBloquearNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquearNC.Image = global::UI.Properties.Resources.bloquear;
            this.btnBloquearNC.Location = new System.Drawing.Point(728, 102);
            this.btnBloquearNC.Name = "btnBloquearNC";
            this.btnBloquearNC.Size = new System.Drawing.Size(35, 35);
            this.btnBloquearNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBloquearNC.TabIndex = 29;
            this.btnBloquearNC.TabStop = false;
            this.btnBloquearNC.Click += new System.EventHandler(this.btnBloquearNC_Click);
            // 
            // btnDesbloquearNC
            // 
            this.btnDesbloquearNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesbloquearNC.Image = global::UI.Properties.Resources.desbloquear;
            this.btnDesbloquearNC.Location = new System.Drawing.Point(728, 102);
            this.btnDesbloquearNC.Name = "btnDesbloquearNC";
            this.btnDesbloquearNC.Size = new System.Drawing.Size(35, 35);
            this.btnDesbloquearNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDesbloquearNC.TabIndex = 28;
            this.btnDesbloquearNC.TabStop = false;
            this.btnDesbloquearNC.Visible = false;
            this.btnDesbloquearNC.Click += new System.EventHandler(this.btnDesbloquearNC_Click);
            // 
            // btnBloquerCC
            // 
            this.btnBloquerCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquerCC.Image = global::UI.Properties.Resources.bloquear;
            this.btnBloquerCC.Location = new System.Drawing.Point(728, 172);
            this.btnBloquerCC.Name = "btnBloquerCC";
            this.btnBloquerCC.Size = new System.Drawing.Size(35, 35);
            this.btnBloquerCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBloquerCC.TabIndex = 31;
            this.btnBloquerCC.TabStop = false;
            this.btnBloquerCC.Click += new System.EventHandler(this.btnBloquerCC_Click);
            // 
            // btnDesbloquearCC
            // 
            this.btnDesbloquearCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesbloquearCC.Image = global::UI.Properties.Resources.desbloquear;
            this.btnDesbloquearCC.Location = new System.Drawing.Point(728, 172);
            this.btnDesbloquearCC.Name = "btnDesbloquearCC";
            this.btnDesbloquearCC.Size = new System.Drawing.Size(35, 35);
            this.btnDesbloquearCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDesbloquearCC.TabIndex = 30;
            this.btnDesbloquearCC.TabStop = false;
            this.btnDesbloquearCC.Visible = false;
            this.btnDesbloquearCC.Click += new System.EventHandler(this.btnDesbloquearCC_Click);
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnBloquerCC);
            this.Controls.Add(this.btnDesbloquearCC);
            this.Controls.Add(this.btnBloquearNC);
            this.Controls.Add(this.btnDesbloquearNC);
            this.Controls.Add(this.lblConfirmeContrasena);
            this.Controls.Add(this.lblNuevaContrasena);
            this.Controls.Add(this.barraLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlLogoLogin);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarContrasena";
            this.Opacity = 0.95D;
            this.Text = "frmCambiarContrasena";
            this.barraLogin.ResumeLayout(false);
            this.barraLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.pnlLogoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBloquearNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesbloquearNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBloquerCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesbloquearCC)).EndInit();
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
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.PictureBox btnBloquearNC;
        private System.Windows.Forms.PictureBox btnDesbloquearNC;
        private System.Windows.Forms.PictureBox btnBloquerCC;
        private System.Windows.Forms.PictureBox btnDesbloquearCC;
    }
}