using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Asistic
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //Al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {

            this.horafecha.Enabled = true;


        }

        //Convertir los label en time y date
        private void Horafecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
        }


        //Cerrar la aplicacion
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea salir?", "Saliendo del formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        //Resaltar la fuente del textbox al escribir
        private void Txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Usuario")
            {

                txt_user.Text = "";

                txt_user.ForeColor = Color.Aquamarine;

            }
        }

        //Resaltar la fuente del textbox al escribir

        private void Txt_contra_Enter(object sender, EventArgs e)
        {
            if (txt_contra.Text == "Contraseña")
            {

                txt_contra.Text = "";

                txt_contra.ForeColor = Color.Aquamarine;

                txt_contra.UseSystemPasswordChar = true;

            }
        }

        //Retornar el textbox a usuario
        private void Txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {

                txt_user.Text = "Usuario";

                txt_user.ForeColor = Color.White;

            }
        }

        //Retornar el textbox a usuario
        private void Txt_contra_Leave(object sender, EventArgs e)
        {
            if (txt_contra.Text == "")
            {

                txt_contra.Text = "Contraseña";

                txt_contra.ForeColor = Color.White;

                txt_contra.UseSystemPasswordChar = false;

            }
        }

        //Minimizar la aplicacion
        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Llamar el metodo login y retornar los estilos de los textbox
        private void Btn_login_Click(object sender, EventArgs e)
        {
            Logins();

            txt_user.Text = "Usr";

            txt_user.ForeColor = Color.White;

            txt_contra.Text = "Pass";

            txt_contra.ForeColor = Color.White;

            txt_contra.UseSystemPasswordChar = false;

        }

        //Metodo para conectar con la base de datos
        public void Logins()
        {

            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("select Usr, Pass from Login where Usr = '" + txt_user.Text + "' and Pass = '" + txt_contra.Text + "'", conexion))
                    {

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {

                            MessageBox.Show("Login exitoso");

                            this.Hide();

                            Menu ingreso = new Menu();

                            ingreso.Show();

                        }
                        else
                        {
                            MessageBox.Show("No se encontro el usuario");
                        }

                        conexion.Close();
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            
            }

            

        }

        //Codigo para mover form sin borde
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Evento del formulario para moverlo
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txt_contra.Focus();

            }

        }

        private void Txt_contra_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Logins();

                txt_user.Text = "Usuario";

                txt_user.ForeColor = Color.White;

                txt_contra.Text = "Contraseña";

                txt_contra.ForeColor = Color.White;

                txt_contra.UseSystemPasswordChar = false;

            }

        }





    }
}
