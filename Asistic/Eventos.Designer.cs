namespace Asistic
{
    partial class Eventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_eventos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.Panel_eventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt1
            // 
            this.dt1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt1.ColumnHeadersHeight = 30;
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt1.EnableHeadersVisualStyles = false;
            this.dt1.GridColor = System.Drawing.Color.Aqua;
            this.dt1.Location = new System.Drawing.Point(293, 105);
            this.dt1.Name = "dt1";
            this.dt1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt1.RowHeadersVisible = false;
            this.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt1.Size = new System.Drawing.Size(325, 256);
            this.dt1.TabIndex = 4;
            this.dt1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dt1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el evento";
            // 
            // Panel_eventos
            // 
            this.Panel_eventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Panel_eventos.Controls.Add(this.label1);
            this.Panel_eventos.Controls.Add(this.dt1);
            this.Panel_eventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_eventos.Location = new System.Drawing.Point(0, 0);
            this.Panel_eventos.Name = "Panel_eventos";
            this.Panel_eventos.Size = new System.Drawing.Size(911, 535);
            this.Panel_eventos.TabIndex = 6;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(911, 535);
            this.Controls.Add(this.Panel_eventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.Panel_eventos.ResumeLayout(false);
            this.Panel_eventos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_eventos;
    }
}