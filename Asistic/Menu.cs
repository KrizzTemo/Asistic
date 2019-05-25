using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Asistic
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Esta seguro que desea salir?", "Saliendo del Menú", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
            else if(result == DialogResult.No)
            {

                return;

            }


        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            this.horaFecha.Enabled = true;

            panelCentral.Controls.Clear();

            Inicio fh = new Inicio();

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            panelCentral.Controls.Add(fh);

            fh.Show();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Eventos_Click(object sender, EventArgs e)
        {

            panelCentral.Controls.Clear();

            Eventos fh = new Eventos();

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            panelCentral.Controls.Add(fh);

            fh.Show();

        }

        private void Btn_nuevoEvento_Click(object sender, EventArgs e)
        {

            panelCentral.Controls.Clear();

            Nuevo_evento fh = new Nuevo_evento();

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            panelCentral.Controls.Add(fh);

            fh.Show();

        }

        private void Btn_Asistencia_Click(object sender, EventArgs e)
        {

            panelCentral.Controls.Clear();

            Ingresados fh = new Ingresados();

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            panelCentral.Controls.Add(fh);

            fh.Show();

        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {

            panelCentral.Controls.Clear();

            Inicio fh = new Inicio();

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            panelCentral.Controls.Add(fh);

            fh.Show();

        }




    }

}
