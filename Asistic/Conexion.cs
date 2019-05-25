using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asistic
{
    class Conexion
    {
        SqlConnection cn;

        SqlCommand cmd;

        SqlDataReader dr;

        SqlDataAdapter da;

        DataTable dt;

        //Conexión a la base de datos AsisTic
        public Conexion()
        {

            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=AsisTIC;Integrated Security=True");

                cn.Open();

            }
            catch (Exception ex)
            {

                MessageBox.Show($" No se pudo conectar a la base de datos {ex.ToString()} ");

            }

        }

        public void mostrarEventos(DataGridView dgv)
        {


            try
            {

                da = new SqlDataAdapter("Select Nom_Evento, Fini_Evento, Ffin_Evento from Evento", cn);

                dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar los eventos" + ex.ToString());

            }



        }

        public void mostrarEstudiantes(DataGridView dgv)
        {


            try
            {

                da = new SqlDataAdapter("Select Nom_Asis, Ced_Asis, Prog_Asis, Nom_Evento, Fini_Evento, Ffin_Evento from Registro", cn);

                dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar los estudiantes" + ex.ToString());

            }



        }


    }
}
