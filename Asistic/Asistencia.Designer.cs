namespace Asistic
{
    partial class Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.label1 = new System.Windows.Forms.Label();
            this.tsMifare1K = new System.Windows.Forms.ToolStrip();
            this.BtnConectar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CboxPuerto = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.CboxRatio = new System.Windows.Forms.ToolStripComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.BtnRecibido = new System.Windows.Forms.Button();
            this.txt_nombreEvento = new System.Windows.Forms.TextBox();
            this.txt_fechaInicio = new System.Windows.Forms.TextBox();
            this.txt_fechaFin = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_programa = new System.Windows.Forms.TextBox();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.tsMifare1K.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(663, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombres";
            // 
            // tsMifare1K
            // 
            this.tsMifare1K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tsMifare1K.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMifare1K.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMifare1K.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConectar,
            this.toolStripLabel1,
            this.CboxPuerto,
            this.toolStripLabel2,
            this.CboxRatio});
            this.tsMifare1K.Location = new System.Drawing.Point(0, 0);
            this.tsMifare1K.Name = "tsMifare1K";
            this.tsMifare1K.Size = new System.Drawing.Size(911, 31);
            this.tsMifare1K.TabIndex = 11;
            this.tsMifare1K.Text = "toolStrip1";
            // 
            // BtnConectar
            // 
            this.BtnConectar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnConectar.Font = new System.Drawing.Font("Monotype Corsiva", 15F);
            this.BtnConectar.ForeColor = System.Drawing.Color.White;
            this.BtnConectar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConectar.Image")));
            this.BtnConectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 28);
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.Click += new System.EventHandler(this.TsbtnConnect_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 15F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 28);
            this.toolStripLabel1.Text = "Puerto";
            // 
            // CboxPuerto
            // 
            this.CboxPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CboxPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxPuerto.DropDownWidth = 160;
            this.CboxPuerto.Font = new System.Drawing.Font("Monotype Corsiva", 12F);
            this.CboxPuerto.ForeColor = System.Drawing.Color.White;
            this.CboxPuerto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CboxPuerto.Name = "CboxPuerto";
            this.CboxPuerto.Size = new System.Drawing.Size(92, 31);
            this.CboxPuerto.Click += new System.EventHandler(this.TscbxPort_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Monotype Corsiva", 15F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 28);
            this.toolStripLabel2.Text = "Ratio";
            // 
            // CboxRatio
            // 
            this.CboxRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CboxRatio.Font = new System.Drawing.Font("Monotype Corsiva", 12F);
            this.CboxRatio.ForeColor = System.Drawing.Color.White;
            this.CboxRatio.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.CboxRatio.Name = "CboxRatio";
            this.CboxRatio.Size = new System.Drawing.Size(92, 31);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.White;
            this.txt_nombre.Location = new System.Drawing.Point(625, 96);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(170, 30);
            this.txt_nombre.TabIndex = 10;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txtSearchPurse_TextChanged);
            // 
            // BtnRecibido
            // 
            this.BtnRecibido.Location = new System.Drawing.Point(654, 428);
            this.BtnRecibido.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRecibido.Name = "BtnRecibido";
            this.BtnRecibido.Size = new System.Drawing.Size(109, 42);
            this.BtnRecibido.TabIndex = 9;
            this.BtnRecibido.Text = "Recibir";
            this.BtnRecibido.UseVisualStyleBackColor = true;
            this.BtnRecibido.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // txt_nombreEvento
            // 
            this.txt_nombreEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_nombreEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreEvento.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreEvento.ForeColor = System.Drawing.Color.White;
            this.txt_nombreEvento.Location = new System.Drawing.Point(41, 97);
            this.txt_nombreEvento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreEvento.Name = "txt_nombreEvento";
            this.txt_nombreEvento.ReadOnly = true;
            this.txt_nombreEvento.Size = new System.Drawing.Size(170, 33);
            this.txt_nombreEvento.TabIndex = 14;
            // 
            // txt_fechaInicio
            // 
            this.txt_fechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_fechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fechaInicio.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaInicio.ForeColor = System.Drawing.Color.White;
            this.txt_fechaInicio.Location = new System.Drawing.Point(67, 190);
            this.txt_fechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fechaInicio.Name = "txt_fechaInicio";
            this.txt_fechaInicio.ReadOnly = true;
            this.txt_fechaInicio.Size = new System.Drawing.Size(128, 33);
            this.txt_fechaInicio.TabIndex = 15;
            // 
            // txt_fechaFin
            // 
            this.txt_fechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_fechaFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fechaFin.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaFin.ForeColor = System.Drawing.Color.White;
            this.txt_fechaFin.Location = new System.Drawing.Point(66, 286);
            this.txt_fechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fechaFin.Name = "txt_fechaFin";
            this.txt_fechaFin.ReadOnly = true;
            this.txt_fechaFin.Size = new System.Drawing.Size(129, 33);
            this.txt_fechaFin.TabIndex = 16;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 41;
            this.lineShape1.X2 = 210;
            this.lineShape1.Y1 = 133;
            this.lineShape1.Y2 = 133;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(911, 535);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 67;
            this.lineShape4.X2 = 195;
            this.lineShape4.Y1 = 320;
            this.lineShape4.Y2 = 320;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 626;
            this.lineShape3.X2 = 795;
            this.lineShape3.Y1 = 127;
            this.lineShape3.Y2 = 127;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 66;
            this.lineShape2.X2 = 194;
            this.lineShape2.Y1 = 224;
            this.lineShape2.Y2 = 224;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de finalización";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre de evento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(673, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cédula";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cedula.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.ForeColor = System.Drawing.Color.White;
            this.txt_cedula.Location = new System.Drawing.Point(625, 195);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.ReadOnly = true;
            this.txt_cedula.Size = new System.Drawing.Size(170, 30);
            this.txt_cedula.TabIndex = 22;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 625;
            this.lineShape5.X2 = 794;
            this.lineShape5.Y1 = 226;
            this.lineShape5.Y2 = 226;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(656, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "Programa";
            // 
            // txt_programa
            // 
            this.txt_programa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_programa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_programa.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_programa.ForeColor = System.Drawing.Color.White;
            this.txt_programa.Location = new System.Drawing.Point(625, 300);
            this.txt_programa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_programa.Name = "txt_programa";
            this.txt_programa.ReadOnly = true;
            this.txt_programa.Size = new System.Drawing.Size(170, 30);
            this.txt_programa.TabIndex = 24;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape6.Enabled = false;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 625;
            this.lineShape6.X2 = 794;
            this.lineShape6.Y1 = 331;
            this.lineShape6.Y2 = 331;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(648, 350);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(120, 55);
            this.btn_registrar.TabIndex = 25;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(911, 535);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_programa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fechaFin);
            this.Controls.Add(this.txt_fechaInicio);
            this.Controls.Add(this.txt_nombreEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMifare1K);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.BtnRecibido);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Asistencia";
            this.Opacity = 0.85D;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.tsMifare1K.ResumeLayout(false);
            this.tsMifare1K.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsMifare1K;
        private System.Windows.Forms.ToolStripButton BtnConectar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox CboxPuerto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox CboxRatio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button BtnRecibido;
        private System.Windows.Forms.TextBox txt_nombreEvento;
        private System.Windows.Forms.TextBox txt_fechaInicio;
        private System.Windows.Forms.TextBox txt_fechaFin;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_programa;
        private System.Windows.Forms.Button btn_registrar;
    }
}