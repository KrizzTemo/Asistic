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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private int numeroImagen = 1;

        private void proximaImagen()
        {

            if (numeroImagen == 4)
            {

                numeroImagen = 1;

            }

            Pic_slide_sisas.ImageLocation = string.Format(@"Imagenes\{0}.jpeg", numeroImagen);

            numeroImagen++;

        }

        private void Secuencia_Tick(object sender, EventArgs e)
        {

            proximaImagen();

        }



    }
}
