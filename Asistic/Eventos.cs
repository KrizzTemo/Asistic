using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistic
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }


        private void Eventos_Load_1(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            c.mostrarEventos(dt1);
        }


        private string nombreEvento;

        private string fechaInicio;

        private string fechaFin;



        private void Dt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nombreEvento = dt1.Rows[e.RowIndex].Cells["Nom_Evento"].Value.ToString();

            fechaInicio = dt1.Rows[e.RowIndex].Cells["Fini_Evento"].Value.ToString();

            fechaFin = dt1.Rows[e.RowIndex].Cells["Ffin_Evento"].Value.ToString();


            Panel_eventos.Controls.Clear();

            Asistencia datosRecibidos = new Asistencia(nombreEvento, fechaInicio, fechaFin);

            datosRecibidos.TopLevel = false;

            datosRecibidos.Dock = DockStyle.Fill;

            Panel_eventos.Controls.Add(datosRecibidos);

            datosRecibidos.Show();

        }






    }
}
