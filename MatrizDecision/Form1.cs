using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizDecision
{
    public partial class Form1 : Form
    {
        string[,] tablaProd = new string[10, 12];
        int[,] tablaVal = new int[10, 10];
        double[] pesos = new double[10];
        double[] result = new double[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] columnas = new string[12];

            columnas[0] = "MARCA";
            columnas[1] = "MODELO";
            columnas[2] = "PRECIO";
            columnas[3] = "PULGADAS";
            columnas[4] = "TIPO HD";
            columnas[5] = "RESOLUCIÓN";
            columnas[6] = "VELOCIDAD ACTUALIZACIÓN";
            columnas[7] = "HDMI";
            columnas[8] = "VGA";
            columnas[9] = "TIEMPO DE RESPUESTA";
            columnas[10] = "PESO";
            columnas[11] = "TECNOLOGÍA DE VISUALIZACIÓN";

            dgv_prod.Columns.Add("", columnas[0]);
            dgv_prod.Columns.Add("", columnas[1]);
            dgv_prod.Columns.Add("", columnas[2]);
            dgv_prod.Columns.Add("", columnas[3]);
            dgv_prod.Columns.Add("", columnas[4]);
            dgv_prod.Columns.Add("", columnas[5]);
            dgv_prod.Columns.Add("", columnas[6]);
            dgv_prod.Columns.Add("", columnas[7]);
            dgv_prod.Columns.Add("", columnas[8]);
            dgv_prod.Columns.Add("", columnas[9]);
            dgv_prod.Columns.Add("", columnas[10]);
            dgv_prod.Columns.Add("", columnas[11]);


            tablaProd[0, 0] = "HUAWEI";
            tablaProd[0, 1] = "AD80HW";
            tablaProd[0, 2] = "3309";
            tablaProd[0, 3] = "23.8";
            tablaProd[0, 4] = "FULL HD";
            tablaProd[0, 5] = "1920x1080";
            tablaProd[0, 6] = "60";
            tablaProd[0, 7] = "1";
            tablaProd[0, 8] = "1";
            tablaProd[0, 9] = "5";
            tablaProd[0, 10] = "4.05";
            tablaProd[0, 11] = "LED";

            tablaProd[1, 0] = "GHIA";
            tablaProd[1, 1] = "MG2221";
            tablaProd[1, 2] = "2539";
            tablaProd[1, 3] = "21.5";
            tablaProd[1, 4] = "FULL HD";
            tablaProd[1, 5] = "1920x1080";
            tablaProd[1, 6] = "75";
            tablaProd[1, 7] = "1";
            tablaProd[1, 8] = "1";
            tablaProd[1, 9] = "4";
            tablaProd[1, 10] = "3.8";
            tablaProd[1, 11] = "LED";

            tablaProd[2, 0] = "SAMSUNG";
            tablaProd[2, 1] = "LC24F390FHL";
            tablaProd[2, 2] = "2969";
            tablaProd[2, 3] = "23.5";
            tablaProd[2, 4] = "FULL HD";
            tablaProd[2, 5] = "1920x1080";
            tablaProd[2, 6] = "60";
            tablaProd[2, 7] = "1";
            tablaProd[2, 8] = "1";
            tablaProd[2, 9] = "5";
            tablaProd[2, 10] = "2.8";
            tablaProd[2, 11] = "LED";

            tablaProd[3, 0] = "BENQ";
            tablaProd[3, 1] = "GW2283";
            tablaProd[3, 2] = "2509";
            tablaProd[3, 3] = "21.5";
            tablaProd[3, 4] = "FULL HD";
            tablaProd[3, 5] = "1920x1080";
            tablaProd[3, 6] = "60";
            tablaProd[3, 7] = "2";
            tablaProd[3, 8] = "1";
            tablaProd[3, 9] = "5";
            tablaProd[3, 10] = "2.9";
            tablaProd[3, 11] = "LED";

            tablaProd[4, 0] = "LG";
            tablaProd[4, 1] = "19M38A-B";
            tablaProd[4, 2] = "1769";
            tablaProd[4, 3] = "18.5";
            tablaProd[4, 4] = "HD";
            tablaProd[4, 5] = "1366x768";
            tablaProd[4, 6] = "75";
            tablaProd[4, 7] = "0";
            tablaProd[4, 8] = "1";
            tablaProd[4, 9] = "5";
            tablaProd[4, 10] = "1.9";
            tablaProd[4, 11] = "TN";

            tablaProd[5, 0] = "LG";
            tablaProd[5, 1] = "22MK400H";
            tablaProd[5, 2] = "3089";
            tablaProd[5, 3] = "22";
            tablaProd[5, 4] = "FULL HD";
            tablaProd[5, 5] = "1920x1080";
            tablaProd[5, 6] = "60";
            tablaProd[5, 7] = "1";
            tablaProd[5, 8] = "1";
            tablaProd[5, 9] = "5";
            tablaProd[5, 10] = "2.6";
            tablaProd[5, 11] = "LCD";

            tablaProd[6, 0] = "NACEB";
            tablaProd[6, 1] = "NA-627";
            tablaProd[6, 2] = "1709";
            tablaProd[6, 3] = "19.5";
            tablaProd[6, 4] = "HD+";
            tablaProd[6, 5] = "1600x900";
            tablaProd[6, 6] = "60";
            tablaProd[6, 7] = "1";
            tablaProd[6, 8] = "1";
            tablaProd[6, 9] = "2";
            tablaProd[6, 10] = "2.5";
            tablaProd[6, 11] = "LED";

            tablaProd[7, 0] = "ASUS";
            tablaProd[7, 1] = "VG248QG";
            tablaProd[7, 2] = "4499";
            tablaProd[7, 3] = "24";
            tablaProd[7, 4] = "FULL HD";
            tablaProd[7, 5] = "1920x1080";
            tablaProd[7, 6] = "165";
            tablaProd[7, 7] = "1";
            tablaProd[7, 8] = "1";
            tablaProd[7, 9] = "0.5";
            tablaProd[7, 10] = "5.2";
            tablaProd[7, 11] = "TN";

            tablaProd[8, 0] = "QIAN";
            tablaProd[8, 1] = "QM2151F";
            tablaProd[8, 2] = "2289";
            tablaProd[8, 3] = "21.5";
            tablaProd[8, 4] = "FULL HD";
            tablaProd[8, 5] = "1920x1080";
            tablaProd[8, 6] = "75";
            tablaProd[8, 7] = "0";
            tablaProd[8, 8] = "1";
            tablaProd[8, 9] = "5";
            tablaProd[8, 10] = "3.1";
            tablaProd[8, 11] = "LED";

            tablaProd[9, 0] = "HP";
            tablaProd[9, 1] = "P22v G4";
            tablaProd[9, 2] = "2749";
            tablaProd[9, 3] = "21.5";
            tablaProd[9, 4] = "FULL HD";
            tablaProd[9, 5] = "1920x1080";
            tablaProd[9, 6] = "60";
            tablaProd[9, 7] = "1";
            tablaProd[9, 8] = "1";
            tablaProd[9, 9] = "5";
            tablaProd[9, 10] = "2.85";
            tablaProd[9, 11] = "LED";


            for (int i=0; i < 10; i++)
            {
                dgv_prod.Rows.Add(tablaProd[i,0], tablaProd[i,1], tablaProd[i, 2], tablaProd[i, 3], tablaProd[i, 4], tablaProd[i, 5], tablaProd[i, 6], tablaProd[i, 7], tablaProd[i, 8], tablaProd[i, 9], tablaProd[i, 10], tablaProd[i, 11]);
            }



            tablaVal[0, 0] = 6;
            tablaVal[0, 1] = 7;
            tablaVal[0, 2] = 10;
            tablaVal[0, 3] = 10;
            tablaVal[0, 4] = 6;
            tablaVal[0, 5] = 9;
            tablaVal[0, 6] = 9;
            tablaVal[0, 7] = 8;
            tablaVal[0, 8] = 9;
            tablaVal[0, 9] = 7;

            tablaVal[1, 0] = 7;
            tablaVal[1, 1] = 5;
            tablaVal[1, 2] = 10;
            tablaVal[1, 3] = 10;
            tablaVal[1, 4] = 7;
            tablaVal[1, 5] = 9;
            tablaVal[1, 6] = 9;
            tablaVal[1, 7] = 8;
            tablaVal[1, 8] = 9;
            tablaVal[1, 9] = 7;

            tablaVal[2, 0] = 7;
            tablaVal[2, 1] = 7;
            tablaVal[2, 2] = 10;
            tablaVal[2, 3] = 10;
            tablaVal[2, 4] = 6;
            tablaVal[2, 5] = 9;
            tablaVal[2, 6] = 9;
            tablaVal[2, 7] = 8;
            tablaVal[2, 8] = 9;
            tablaVal[2, 9] = 7;

            tablaVal[3, 0] = 7;
            tablaVal[3, 1] = 5;
            tablaVal[3, 2] = 10;
            tablaVal[3, 3] = 10;
            tablaVal[3, 4] = 6;
            tablaVal[3, 5] = 10;
            tablaVal[3, 6] = 9;
            tablaVal[3, 7] = 8;
            tablaVal[3, 8] = 9;
            tablaVal[3, 9] = 7;

            tablaVal[4, 0] = 9;
            tablaVal[4, 1] = 2;
            tablaVal[4, 2] = 6;
            tablaVal[4, 3] = 8;
            tablaVal[4, 4] = 7;
            tablaVal[4, 5] = 8;
            tablaVal[4, 6] = 9;
            tablaVal[4, 7] = 8;
            tablaVal[4, 8] = 10;
            tablaVal[4, 9] = 8;

            tablaVal[5, 0] = 6;
            tablaVal[5, 1] = 6;
            tablaVal[5, 2] = 10;
            tablaVal[5, 3] = 10;
            tablaVal[5, 4] = 6;
            tablaVal[5, 5] = 9;
            tablaVal[5, 6] = 9;
            tablaVal[5, 7] = 8;
            tablaVal[5, 8] = 9;
            tablaVal[5, 9] = 6;

            tablaVal[6, 0] = 9;
            tablaVal[6, 1] = 3;
            tablaVal[6, 2] = 8;
            tablaVal[6, 3] = 9;
            tablaVal[6, 4] = 6;
            tablaVal[6, 5] = 9;
            tablaVal[6, 6] = 9;
            tablaVal[6, 7] = 10;
            tablaVal[6, 8] = 10;
            tablaVal[6, 9] = 7;

            tablaVal[7, 0] = 4;
            tablaVal[7, 1] = 8;
            tablaVal[7, 2] = 10;
            tablaVal[7, 3] = 10;
            tablaVal[7, 4] = 9;
            tablaVal[7, 5] = 9;
            tablaVal[7, 6] = 9;
            tablaVal[7, 7] = 10;
            tablaVal[7, 8] = 8;
            tablaVal[7, 9] = 8;

            tablaVal[8, 0] = 8;
            tablaVal[8, 1] = 5;
            tablaVal[8, 2] = 10;
            tablaVal[8, 3] = 10;
            tablaVal[8, 4] = 7;
            tablaVal[8, 5] = 8;
            tablaVal[8, 6] = 9;
            tablaVal[8, 7] = 8;
            tablaVal[8, 8] = 9;
            tablaVal[8, 9] = 7;

            tablaVal[9, 0] = 7;
            tablaVal[9, 1] = 5;
            tablaVal[9, 2] = 10;
            tablaVal[9, 3] = 10;
            tablaVal[9, 4] = 6;
            tablaVal[9, 5] = 9;
            tablaVal[9, 6] = 9;
            tablaVal[9, 7] = 8;
            tablaVal[9, 8] = 9;
            tablaVal[9, 9] = 7;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            pesos[0] = Convert.ToDouble(txtPrecio.Text) / 100;
            pesos[1] = Convert.ToDouble(txtPulgadas.Text) / 100;
            pesos[2] = Convert.ToDouble(txtTipoHD.Text) / 100;
            pesos[3] = Convert.ToDouble(txtResolucion.Text) / 100;
            pesos[4] = Convert.ToDouble(txtVelocidad.Text) / 100;
            pesos[5] = Convert.ToDouble(txtHDMI.Text) / 100;
            pesos[6] = Convert.ToDouble(txtVGA.Text) / 100;
            pesos[7] = Convert.ToDouble(txtTiempoResp.Text) / 100;
            pesos[8] = Convert.ToDouble(txtPeso.Text) / 100;
            pesos[9] = Convert.ToDouble(txtTecnologia.Text) / 100;

            //prod
            for (int i = 0; i < 10; i++)
            {
                result[i] = 0;
                //atrib
                for (int j = 0; j < 10; j++)
                {
                    result[i] = result[i] + (Convert.ToDouble(tablaVal[i, j]) * pesos[j]); 
                }
                MessageBox.Show(result[i].ToString());
            }


        }
    }
}
