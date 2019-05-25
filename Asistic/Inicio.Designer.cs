namespace Asistic
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Panel_sisas = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pic_logo_sisas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pic_slide_sisas = new System.Windows.Forms.PictureBox();
            this.Secuencia = new System.Windows.Forms.Timer(this.components);
            this.Panel_sisas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo_sisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_slide_sisas)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_sisas
            // 
            this.Panel_sisas.Controls.Add(this.Pic_slide_sisas);
            this.Panel_sisas.Location = new System.Drawing.Point(13, 13);
            this.Panel_sisas.Name = "Panel_sisas";
            this.Panel_sisas.Size = new System.Drawing.Size(607, 304);
            this.Panel_sisas.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 200);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Pic_logo_sisas
            // 
            this.Pic_logo_sisas.Image = global::Asistic.Properties.Resources.Sisas2;
            this.Pic_logo_sisas.Location = new System.Drawing.Point(626, 12);
            this.Pic_logo_sisas.Name = "Pic_logo_sisas";
            this.Pic_logo_sisas.Size = new System.Drawing.Size(273, 257);
            this.Pic_logo_sisas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_logo_sisas.TabIndex = 3;
            this.Pic_logo_sisas.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asistic.Properties.Resources.logoIUSH;
            this.pictureBox1.Location = new System.Drawing.Point(626, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Pic_slide_sisas
            // 
            this.Pic_slide_sisas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_slide_sisas.Location = new System.Drawing.Point(0, 0);
            this.Pic_slide_sisas.Name = "Pic_slide_sisas";
            this.Pic_slide_sisas.Size = new System.Drawing.Size(607, 304);
            this.Pic_slide_sisas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_slide_sisas.TabIndex = 0;
            this.Pic_slide_sisas.TabStop = false;
            // 
            // Secuencia
            // 
            this.Secuencia.Enabled = true;
            this.Secuencia.Interval = 5000;
            this.Secuencia.Tick += new System.EventHandler(this.Secuencia_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(911, 535);
            this.Controls.Add(this.Pic_logo_sisas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Panel_sisas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Panel_sisas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo_sisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_slide_sisas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_sisas;
        private System.Windows.Forms.PictureBox Pic_slide_sisas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pic_logo_sisas;
        private System.Windows.Forms.Timer Secuencia;
    }
}