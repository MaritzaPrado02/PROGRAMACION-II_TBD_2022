﻿
namespace UI
{
    partial class frmAgregarCategoriaHabitacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new AltoControls.AltoTextBox();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarComplemento = new System.Windows.Forms.PictureBox();
            this.pcbImg = new System.Windows.Forms.PictureBox();
            this.nudCantidadComplemento = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarComplemento = new System.Windows.Forms.Button();
            this.dgvComplementos = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCosto = new AltoControls.AltoTextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.cmbComplementos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarComplemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadComplemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(675, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(408, 368);
            this.dataGridView1.TabIndex = 1;
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
            this.btnEliminar.Location = new System.Drawing.Point(897, 454);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 37);
            this.btnEliminar.TabIndex = 75;
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
            this.btnEditar.Location = new System.Drawing.Point(684, 454);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 37);
            this.btnEditar.TabIndex = 74;
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
            this.btnRegistrar.Location = new System.Drawing.Point(177, 454);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 37);
            this.btnRegistrar.TabIndex = 73;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(359, 454);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(248, 37);
            this.btnGuardarCambios.TabIndex = 76;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.ForeColor = System.Drawing.Color.White;
            this.lblNombreCategoria.Location = new System.Drawing.Point(147, 65);
            this.lblNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(196, 23);
            this.lblNombreCategoria.TabIndex = 77;
            this.lblNombreCategoria.Text = "Nombre categoría:";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreCategoria.Br = System.Drawing.Color.White;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreCategoria.Location = new System.Drawing.Point(359, 59);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(264, 41);
            this.txtNombreCategoria.TabIndex = 78;
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
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1099, 34);
            this.pnlBarraSuperior.TabIndex = 79;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1060, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 81;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::UI.Properties.Resources.minimizar__1_;
            this.btnMinimizar.Location = new System.Drawing.Point(1032, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 80;
            this.btnMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnAgregarComplemento
            // 
            this.btnAgregarComplemento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarComplemento.Image = global::UI.Properties.Resources.boton_agregar;
            this.btnAgregarComplemento.Location = new System.Drawing.Point(627, 170);
            this.btnAgregarComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarComplemento.Name = "btnAgregarComplemento";
            this.btnAgregarComplemento.Size = new System.Drawing.Size(43, 39);
            this.btnAgregarComplemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarComplemento.TabIndex = 116;
            this.btnAgregarComplemento.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAgregarComplemento, "Añadir complemento");
            this.btnAgregarComplemento.Click += new System.EventHandler(this.btnAgregarComplemento_Click);
            // 
            // pcbImg
            // 
            this.pcbImg.Image = global::UI.Properties.Resources.habitacion;
            this.pcbImg.Location = new System.Drawing.Point(17, 54);
            this.pcbImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbImg.Name = "pcbImg";
            this.pcbImg.Size = new System.Drawing.Size(121, 101);
            this.pcbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImg.TabIndex = 0;
            this.pcbImg.TabStop = false;
            // 
            // nudCantidadComplemento
            // 
            this.nudCantidadComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadComplemento.Location = new System.Drawing.Point(316, 231);
            this.nudCantidadComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidadComplemento.Name = "nudCantidadComplemento";
            this.nudCantidadComplemento.Size = new System.Drawing.Size(68, 32);
            this.nudCantidadComplemento.TabIndex = 109;
            // 
            // btnGuardarComplemento
            // 
            this.btnGuardarComplemento.BackColor = System.Drawing.Color.Black;
            this.btnGuardarComplemento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarComplemento.FlatAppearance.BorderSize = 0;
            this.btnGuardarComplemento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGuardarComplemento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarComplemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarComplemento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarComplemento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarComplemento.Location = new System.Drawing.Point(392, 230);
            this.btnGuardarComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarComplemento.Name = "btnGuardarComplemento";
            this.btnGuardarComplemento.Size = new System.Drawing.Size(233, 39);
            this.btnGuardarComplemento.TabIndex = 107;
            this.btnGuardarComplemento.Text = "Agregar complemento";
            this.btnGuardarComplemento.UseVisualStyleBackColor = false;
            // 
            // dgvComplementos
            // 
            this.dgvComplementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmComplemento,
            this.clmCantidad});
            this.dgvComplementos.Location = new System.Drawing.Point(81, 295);
            this.dgvComplementos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComplementos.Name = "dgvComplementos";
            this.dgvComplementos.RowHeadersWidth = 51;
            this.dgvComplementos.Size = new System.Drawing.Size(324, 132);
            this.dgvComplementos.TabIndex = 103;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 111;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(203)))), ((int)(((byte)(82)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(413, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 37);
            this.button2.TabIndex = 110;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.Transparent;
            this.txtCosto.Br = System.Drawing.Color.White;
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCosto.Location = new System.Drawing.Point(359, 112);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(264, 41);
            this.txtCosto.TabIndex = 113;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.White;
            this.lblCosto.Location = new System.Drawing.Point(281, 118);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(73, 23);
            this.lblCosto.TabIndex = 112;
            this.lblCosto.Text = "Costo:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.White;
            this.lblComplemento.Location = new System.Drawing.Point(55, 171);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(286, 23);
            this.lblComplemento.TabIndex = 114;
            this.lblComplemento.Text = "Seleccionar complementos:";
            // 
            // cmbComplementos
            // 
            this.cmbComplementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComplementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComplementos.FormattingEnabled = true;
            this.cmbComplementos.Location = new System.Drawing.Point(364, 171);
            this.cmbComplementos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbComplementos.Name = "cmbComplementos";
            this.cmbComplementos.Size = new System.Drawing.Size(257, 33);
            this.cmbComplementos.TabIndex = 115;
            // 
            // frmAgregarCategoriaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.btnAgregarComplemento);
            this.Controls.Add(this.cmbComplementos);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nudCantidadComplemento);
            this.Controls.Add(this.btnGuardarComplemento);
            this.Controls.Add(this.dgvComplementos);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarCategoriaHabitacion";
            this.Text = "frmAgregarCategoriaHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarComplemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadComplemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblNombreCategoria;
        private AltoControls.AltoTextBox txtNombreCategoria;
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.NumericUpDown nudCantidadComplemento;
        private System.Windows.Forms.Button btnGuardarComplemento;
        private System.Windows.Forms.DataGridView dgvComplementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AltoControls.AltoTextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.ComboBox cmbComplementos;
        private System.Windows.Forms.PictureBox btnAgregarComplemento;
    }
}