
namespace UI
{
    partial class frmCheckOut
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtAreaTrabajo = new AltoControls.AltoTextBox();
            this.lblIDReservación = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHacerCheck_out = new System.Windows.Forms.Button();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(191, 132);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(148, 19);
            this.lblFecha.TabIndex = 106;
            this.lblFecha.Text = "Seleccione fecha:";
            // 
            // txtAreaTrabajo
            // 
            this.txtAreaTrabajo.BackColor = System.Drawing.Color.Transparent;
            this.txtAreaTrabajo.Br = System.Drawing.Color.White;
            this.txtAreaTrabajo.Enabled = false;
            this.txtAreaTrabajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaTrabajo.ForeColor = System.Drawing.Color.DimGray;
            this.txtAreaTrabajo.Location = new System.Drawing.Point(195, 87);
            this.txtAreaTrabajo.Name = "txtAreaTrabajo";
            this.txtAreaTrabajo.Size = new System.Drawing.Size(247, 33);
            this.txtAreaTrabajo.TabIndex = 105;
            // 
            // lblIDReservación
            // 
            this.lblIDReservación.AutoSize = true;
            this.lblIDReservación.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDReservación.ForeColor = System.Drawing.Color.Black;
            this.lblIDReservación.Location = new System.Drawing.Point(247, 52);
            this.lblIDReservación.Name = "lblIDReservación";
            this.lblIDReservación.Size = new System.Drawing.Size(126, 19);
            this.lblIDReservación.TabIndex = 104;
            this.lblIDReservación.Text = "ID Reservación:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // btnHacerCheck_out
            // 
            this.btnHacerCheck_out.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHacerCheck_out.BackColor = System.Drawing.Color.Black;
            this.btnHacerCheck_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHacerCheck_out.FlatAppearance.BorderSize = 0;
            this.btnHacerCheck_out.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnHacerCheck_out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnHacerCheck_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerCheck_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerCheck_out.ForeColor = System.Drawing.Color.White;
            this.btnHacerCheck_out.Location = new System.Drawing.Point(238, 206);
            this.btnHacerCheck_out.Name = "btnHacerCheck_out";
            this.btnHacerCheck_out.Size = new System.Drawing.Size(175, 42);
            this.btnHacerCheck_out.TabIndex = 101;
            this.btnHacerCheck_out.Text = "Check-out";
            this.btnHacerCheck_out.UseVisualStyleBackColor = false;
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.barraSuperior.Controls.Add(this.btnCerrar);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(508, 27);
            this.barraSuperior.TabIndex = 100;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(484, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 82;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // imagen
            // 
            this.imagen.Image = global::UI.Properties.Resources.check_out1;
            this.imagen.Location = new System.Drawing.Point(31, 78);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(149, 170);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 103;
            this.imagen.TabStop = false;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 293);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtAreaTrabajo);
            this.Controls.Add(this.lblIDReservación);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnHacerCheck_out);
            this.Controls.Add(this.barraSuperior);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private AltoControls.AltoTextBox txtAreaTrabajo;
        private System.Windows.Forms.Label lblIDReservación;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnHacerCheck_out;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}