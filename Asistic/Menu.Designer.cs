namespace Asistic
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.lbl_Hora2 = new System.Windows.Forms.Label();
            this.lbl_Fecha2 = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.btn_Asistencia = new System.Windows.Forms.Button();
            this.btn_nuevoEvento = new System.Windows.Forms.Button();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_Eventos = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Salir.Location = new System.Drawing.Point(1063, 0);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(42, 32);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Minimizar.Location = new System.Drawing.Point(1018, 0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(42, 32);
            this.btn_Minimizar.TabIndex = 8;
            this.btn_Minimizar.Text = "-";
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.panelTitulo.Controls.Add(this.lblMenu);
            this.panelTitulo.Controls.Add(this.btn_Minimizar);
            this.panelTitulo.Controls.Add(this.btn_Salir);
            this.panelTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1108, 35);
            this.panelTitulo.TabIndex = 10;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(509, 4);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(62, 28);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú";
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelVertical.Controls.Add(this.lbl_Hora2);
            this.panelVertical.Controls.Add(this.lbl_Fecha2);
            this.panelVertical.Controls.Add(this.lbl_Hora);
            this.panelVertical.Controls.Add(this.lbl_Fecha);
            this.panelVertical.Controls.Add(this.btn_Asistencia);
            this.panelVertical.Controls.Add(this.btn_nuevoEvento);
            this.panelVertical.Controls.Add(this.Pic_logo);
            this.panelVertical.Controls.Add(this.btn_Eventos);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 35);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(197, 535);
            this.panelVertical.TabIndex = 11;
            // 
            // lbl_Hora2
            // 
            this.lbl_Hora2.AutoSize = true;
            this.lbl_Hora2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora2.ForeColor = System.Drawing.Color.White;
            this.lbl_Hora2.Location = new System.Drawing.Point(56, 466);
            this.lbl_Hora2.Name = "lbl_Hora2";
            this.lbl_Hora2.Size = new System.Drawing.Size(61, 28);
            this.lbl_Hora2.TabIndex = 11;
            this.lbl_Hora2.Text = "Hora:";
            // 
            // lbl_Fecha2
            // 
            this.lbl_Fecha2.AutoSize = true;
            this.lbl_Fecha2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha2.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha2.Location = new System.Drawing.Point(56, 392);
            this.lbl_Fecha2.Name = "lbl_Fecha2";
            this.lbl_Fecha2.Size = new System.Drawing.Size(69, 28);
            this.lbl_Fecha2.TabIndex = 9;
            this.lbl_Fecha2.Text = "Fecha:";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.White;
            this.lbl_Hora.Location = new System.Drawing.Point(32, 497);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(27, 28);
            this.lbl_Hora.TabIndex = 10;
            this.lbl_Hora.Text = "...";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(34, 420);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(27, 28);
            this.lbl_Fecha.TabIndex = 9;
            this.lbl_Fecha.Text = "...";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Lavender;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(197, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(911, 535);
            this.panelCentral.TabIndex = 12;
            this.panelCentral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCentral_MouseDown);
            // 
            // horaFecha
            // 
            this.horaFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // btn_Asistencia
            // 
            this.btn_Asistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Asistencia.FlatAppearance.BorderSize = 0;
            this.btn_Asistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Asistencia.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Asistencia.ForeColor = System.Drawing.Color.White;
            this.btn_Asistencia.Image = global::Asistic.Properties.Resources.grupo;
            this.btn_Asistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Asistencia.Location = new System.Drawing.Point(8, 311);
            this.btn_Asistencia.Name = "btn_Asistencia";
            this.btn_Asistencia.Size = new System.Drawing.Size(182, 38);
            this.btn_Asistencia.TabIndex = 4;
            this.btn_Asistencia.Text = "Asistencia";
            this.btn_Asistencia.UseVisualStyleBackColor = true;
            this.btn_Asistencia.Click += new System.EventHandler(this.Btn_Asistencia_Click);
            // 
            // btn_nuevoEvento
            // 
            this.btn_nuevoEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevoEvento.FlatAppearance.BorderSize = 0;
            this.btn_nuevoEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_nuevoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoEvento.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoEvento.ForeColor = System.Drawing.Color.White;
            this.btn_nuevoEvento.Image = global::Asistic.Properties.Resources.documento;
            this.btn_nuevoEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoEvento.Location = new System.Drawing.Point(8, 267);
            this.btn_nuevoEvento.Name = "btn_nuevoEvento";
            this.btn_nuevoEvento.Size = new System.Drawing.Size(182, 38);
            this.btn_nuevoEvento.TabIndex = 3;
            this.btn_nuevoEvento.Text = "Nuevo evento";
            this.btn_nuevoEvento.UseVisualStyleBackColor = true;
            this.btn_nuevoEvento.Click += new System.EventHandler(this.Btn_nuevoEvento_Click);
            // 
            // Pic_logo
            // 
            this.Pic_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_logo.Image = global::Asistic.Properties.Resources.ASISTIC_LOGO;
            this.Pic_logo.Location = new System.Drawing.Point(8, 43);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(181, 164);
            this.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_logo.TabIndex = 1;
            this.Pic_logo.TabStop = false;
            this.Pic_logo.Click += new System.EventHandler(this.Pic_logo_Click);
            // 
            // btn_Eventos
            // 
            this.btn_Eventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eventos.FlatAppearance.BorderSize = 0;
            this.btn_Eventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Eventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eventos.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eventos.ForeColor = System.Drawing.Color.White;
            this.btn_Eventos.Image = global::Asistic.Properties.Resources.documento__1_;
            this.btn_Eventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eventos.Location = new System.Drawing.Point(9, 223);
            this.btn_Eventos.Name = "btn_Eventos";
            this.btn_Eventos.Size = new System.Drawing.Size(182, 38);
            this.btn_Eventos.TabIndex = 0;
            this.btn_Eventos.Text = "Eventos";
            this.btn_Eventos.UseVisualStyleBackColor = true;
            this.btn_Eventos.Click += new System.EventHandler(this.Btn_Eventos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1108, 570);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelVertical.ResumeLayout(false);
            this.panelVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Button btn_Eventos;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btn_nuevoEvento;
        private System.Windows.Forms.Button btn_Asistencia;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Hora2;
        private System.Windows.Forms.Label lbl_Fecha2;
    }
}