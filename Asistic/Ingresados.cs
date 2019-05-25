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
    public partial class Ingresados : Form
    {
        public Ingresados()
        {
            InitializeComponent();
        }

        private void Ingresados_Load(object sender, EventArgs e)
        {

            Conexion c = new Conexion();

            c.mostrarEstudiantes(dgv_estudiantes);

        }
    }
}
