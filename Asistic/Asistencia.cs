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
using System.Data.SqlClient;
using System.Configuration;

namespace Asistic
{
    public partial class Asistencia : Form
    {


        [DllImport("kernel32.dll")]
        static extern void Sleep(int dwMilliseconds);

        [DllImport("MasterRD.dll")]
        static extern int rf_init_com(int port, int baud);

        [DllImport("MasterRD.dll")]
        static extern int rf_ClosePort();

        [DllImport("MasterRD.dll")]
        static extern int rf_antenna_sta(short icdev, byte mode);

        [DllImport("MasterRD.dll")]
        static extern int rf_init_type(short icdev, byte type);

        [DllImport("MasterRD.dll")]
        static extern int rf_request(short icdev, byte mode, ref ushort pTagType);

        [DllImport("MasterRD.dll")]
        static extern int rf_anticoll(short icdev, byte bcnt, IntPtr pSnr, ref byte pRLength);

        [DllImport("MasterRD.dll")]
        static extern int rf_select(short icdev, IntPtr pSnr, byte srcLen, ref sbyte Size);

        



        bool ConexionDispositivo;

        static char[] hexDigits = {
            '0','1','2','3','4','5','6','7',
            '8','9','A','B','C','D','E','F'};

        private SqlConnection conexion;

        public static String byteHEX(Byte ib)
        {
            String _str = String.Empty;
            try
            {
                char[] Digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A',
                'B', 'C', 'D', 'E', 'F' };
                char[] ob = new char[2];
                ob[0] = Digit[(ib >> 4) & 0X0F];
                ob[1] = Digit[ib & 0X0F];
                _str = new String(ob);
            }
            catch (Exception)
            {
                new Exception("Lo siento por el error.");
            }
            return _str;

        }



        public Asistencia(string nombreEvento, string fechaInicio, string fechaFin)
        {

            InitializeComponent();

            txt_nombreEvento.Text = nombreEvento;

            txt_fechaInicio.Text = fechaInicio;

            txt_fechaFin.Text = fechaFin;

        }

        private void Asistencia_Load(object sender, EventArgs e)
        {

            ConexionDispositivo = false;
            CboxPuerto.SelectedIndex = 0;
            CboxRatio.SelectedIndex = 2;
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {

            short icdev = 0x0000;
            int status;
            byte type = (byte)'A';
            byte mode = 0x52;
            ushort TagType = 0;
            byte bcnt = 0x04;
            IntPtr pSnr;
            byte len = 255;
            sbyte size = 0;

            


                if (!ConexionDispositivo)
            {
                MessageBox.Show("Dispositivo no conectado!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pSnr = Marshal.AllocHGlobal(1024);

            for (int i = 0; i < 2; i++)
            {
                status = rf_antenna_sta(icdev, 0);
                if (status != 0)
                    continue;

                Sleep(20);
                status = rf_init_type(icdev, type);
                if (status != 0)
                    continue;

                Sleep(20);
                status = rf_antenna_sta(icdev, 1);
                if (status != 0)
                    continue;

                Sleep(50);
                status = rf_request(icdev, mode, ref TagType);
                if (status != 0)
                    continue;

                status = rf_anticoll(icdev, bcnt, pSnr, ref len);
                if (status != 0)
                    continue;

                status = rf_select(icdev, pSnr, len, ref size);
                if (status != 0)
                    continue;

                byte[] szBytes = new byte[len];

                for (int j = 0; j < len; j++)
                {
                    szBytes[j] = Marshal.ReadByte(pSnr, j);
                }

                String CodigoRFID = String.Empty;

                for (int q = 0; q < len; q++)
                {
                    CodigoRFID += byteHEX(szBytes[q]);
                }


                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=AsisTIC;Integrated Security=True");

                string cadSql = "Select * from Asistente where ID_Asis='" + CodigoRFID + "' ";

                SqlCommand cmd = new SqlCommand(cadSql, cn);

                cn.Open();

                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read() == true)
                {

                    txt_nombre.Text = leer["Nom_Asis"].ToString();

                    txt_cedula.Text = leer["Ced_Asis"].ToString();

                    txt_programa.Text = leer["Prog_Asis"].ToString();

                }
          
                break;
            }


            Marshal.FreeHGlobal(pSnr);


        }

       
        private void TsbtnConnect_Click(object sender, EventArgs e)
        {

            {/*toolbar button[connect] clicked*/
                if (!ConexionDispositivo)
                {
                    int port = 0;
                    int baud = 0;
                    int status;
                    
                    port = Convert.ToInt32(CboxPuerto.Text);
                    baud = Convert.ToInt32(CboxRatio.Text);


                    status = rf_init_com(port, baud);
                    if (0 == status)
                    {
                        BtnConectar.Text = "Desconectar";
                        ConexionDispositivo = true;
                        MessageBox.Show("Conexion con el dispositivo completa!");
                    }
                    else
                    {
                        string strError;
                        strError = "Conexion con el dispositivo fallida";
                        ConexionDispositivo = false;
                        MessageBox.Show(strError, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rf_ClosePort();
                    ConexionDispositivo = false;
                    BtnConectar.Text = "Conectar";
                    
                    txt_nombre.Text = "";
                    
                }

            }

        }

        private void TscbxPort_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchPurse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsMifare1K_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }






        private void Btn_registrar_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=AsisTIC;Integrated Security=True");

            cn.Open();

            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Registro values ('" + txt_nombre.Text + "', '" + txt_cedula.Text + "', '" + txt_programa.Text + "', '" + txt_nombreEvento.Text + "', '" + txt_fechaInicio.Text + "', '" + txt_fechaFin.Text + "' )";

            cmd.ExecuteNonQuery();

            cn.Close();

            txt_nombre.Text = "";

            txt_cedula.Text = "";

            txt_programa.Text = "";

        }






    }
}

