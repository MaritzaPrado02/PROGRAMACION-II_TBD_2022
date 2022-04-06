
namespace UI
{
    partial class frmAgregarComplemento
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
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.txtNombreComplemento = new AltoControls.AltoTextBox();
            this.lblNombreComplemento = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvComplementos = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcbImg = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.DarkGray;
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(687, 34);
            this.pnlBarraSuperior.TabIndex = 88;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(653, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 81;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::UI.Properties.Resources.minimizar__1_;
            this.btnMinimizar.Location = new System.Drawing.Point(625, 10);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 80;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtNombreComplemento
            // 
            this.txtNombreComplemento.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreComplemento.Br = System.Drawing.Color.White;
            this.txtNombreComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComplemento.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreComplemento.Location = new System.Drawing.Point(176, 94);
            this.txtNombreComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreComplemento.Name = "txtNombreComplemento";
            this.txtNombreComplemento.Size = new System.Drawing.Size(329, 41);
            this.txtNombreComplemento.TabIndex = 87;
            // 
            // lblNombreComplemento
            // 
            this.lblNombreComplemento.AutoSize = true;
            this.lblNombreComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComplemento.ForeColor = System.Drawing.Color.White;
            this.lblNombreComplemento.Location = new System.Drawing.Point(224, 60);
            this.lblNombreComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreComplemento.Name = "lblNombreComplemento";
            this.lblNombreComplemento.Size = new System.Drawing.Size(240, 23);
            this.lblNombreComplemento.TabIndex = 86;
            this.lblNombreComplemento.Text = "Nombre complemento:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(256, 191);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(173, 60);
            this.btnGuardarCambios.TabIndex = 85;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(392, 462);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 37);
            this.btnEliminar.TabIndex = 84;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(203)))), ((int)(((byte)(82)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(148, 462);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 37);
            this.btnEditar.TabIndex = 83;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnRegistrar.Location = new System.Drawing.Point(256, 146);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 37);
            this.btnRegistrar.TabIndex = 82;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvComplementos
            // 
            this.dgvComplementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmComplemento});
            this.dgvComplementos.Location = new System.Drawing.Point(17, 258);
            this.dgvComplementos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComplementos.Name = "dgvComplementos";
            this.dgvComplementos.RowHeadersWidth = 51;
            this.dgvComplementos.Size = new System.Drawing.Size(649, 196);
            this.dgvComplementos.TabIndex = 81;
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
            // pcbImg
            // 
            this.pcbImg.Image = global::UI.Properties.Resources.muebles;
            this.pcbImg.Location = new System.Drawing.Point(17, 60);
            this.pcbImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbImg.Name = "pcbImg";
            this.pcbImg.Size = new System.Drawing.Size(121, 101);
            this.pcbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImg.TabIndex = 80;
            this.pcbImg.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAgregarComplemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(687, 514);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.txtNombreComplemento);
            this.Controls.Add(this.lblNombreComplemento);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvComplementos);
            this.Controls.Add(this.pcbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarComplemento";
            this.Text = "frmAgregarComplemento";
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private AltoControls.AltoTextBox txtNombreComplemento;
        private System.Windows.Forms.Label lblNombreComplemento;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvComplementos;
        private System.Windows.Forms.PictureBox pcbImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComplemento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}