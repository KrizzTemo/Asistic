namespace Asistic
{
    partial class Nuevo_evento
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
            this.dtp_ini = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txt_nuevoEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_ini
            // 
            this.dtp_ini.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ini.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtp_ini.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtp_ini.CalendarTitleForeColor = System.Drawing.Color.DarkOrange;
            this.dtp_ini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ini.CustomFormat = "dd-MM-yyyy";
            this.dtp_ini.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ini.Location = new System.Drawing.Point(354, 242);
            this.dtp_ini.Name = "dtp_ini";
            this.dtp_ini.Size = new System.Drawing.Size(125, 30);
            this.dtp_ini.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(353, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha evento:";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 284;
            this.lineShape1.X2 = 579;
            this.lineShape1.Y1 = 174;
            this.lineShape1.Y2 = 174;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(911, 535);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // txt_nuevoEvento
            // 
            this.txt_nuevoEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_nuevoEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nuevoEvento.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevoEvento.ForeColor = System.Drawing.Color.White;
            this.txt_nuevoEvento.Location = new System.Drawing.Point(286, 146);
            this.txt_nuevoEvento.Name = "txt_nuevoEvento";
            this.txt_nuevoEvento.Size = new System.Drawing.Size(294, 27);
            this.txt_nuevoEvento.TabIndex = 5;
            this.txt_nuevoEvento.Text = "Nombre";
            this.txt_nuevoEvento.Enter += new System.EventHandler(this.Txt_nuevoEvento_Enter);
            this.txt_nuevoEvento.Leave += new System.EventHandler(this.Txt_nuevoEvento_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de finalización:";
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtp_fin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_fin.CustomFormat = "dd-MM-yyyy";
            this.dtp_fin.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fin.Location = new System.Drawing.Point(354, 358);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(125, 30);
            this.dtp_fin.TabIndex = 7;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(354, 421);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(140, 45);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Crear";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Nuevo_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(911, 535);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nuevoEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ini);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nuevo_evento";
            this.Text = "Nuevo_evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ini;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txt_nuevoEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Button btn_login;
    }
}