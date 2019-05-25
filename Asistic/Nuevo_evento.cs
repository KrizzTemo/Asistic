using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asistic
{
    public partial class Nuevo_evento : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=AsisTIC;Integrated Security=True");
        
        public Nuevo_evento()
        {
            InitializeComponent();
        }

        private void Txt_nuevoEvento_Enter(object sender, EventArgs e)
        {

            if (txt_nuevoEvento.Text == "Nombre")
            {

                txt_nuevoEvento.Text = "";

                txt_nuevoEvento.ForeColor = Color.Aquamarine;



            }

        }

        private void Txt_nuevoEvento_Leave(object sender, EventArgs e)
        {

            if (txt_nuevoEvento.Text == "")
            {

                txt_nuevoEvento.Text = "Nombre";

                txt_nuevoEvento.ForeColor = Color.White;

            }

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            cn.Open();

            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Evento values ('" + txt_nuevoEvento.Text + "', '" + dtp_ini.Value.ToString("dd-MM-yyyy") +"', '"+dtp_fin.Value.ToString("dd-MM-yyyy") +"' )";

            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Evento creado exitosamente");

            txt_nuevoEvento.Text = "Nombre";

            txt_nuevoEvento.ForeColor = Color.White;

        }
    }
}
