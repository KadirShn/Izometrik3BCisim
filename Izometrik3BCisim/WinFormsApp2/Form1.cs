using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int k, i, j;
        System.Drawing.Graphics GrafikYap;
        Pen Kalem = new Pen(Color.Purple, 3);
        Double[,] Eksen3BX = new Double[2, 4] { { 0, 0, 0, 1 }, { 3, 0, 0, 1 } };
        Double[,] Eksen3BY = new Double[2, 4] { { 0, 0, 0, 1 }, { 0, 3, 0, 1 } };

        Double[,] X_Cisim_Noktalar = new Double[8, 4]{ {0,0,0,1},
                                                  {1,0,0,1},
                                                  {1,0,1,1},
                                                  {0,0,1,1},
                                                  {0,1,0,1},
                                                  {1,1,0,1},
                                                  {1,1,1,1},
                                                  {0,1,1,1} };
        Double[,] Cisim_X_Yeni = new Double[8, 4];

        Double[,] Cisim_Olceklemek = new Double[4, 4]{ { 1, 0, 0, 0 },
                                               { 0, 1, 0, 0 },
                                               { 0, 0, 1, 0 },
                                               { 0, 0, 0, 1 } };

        Double[,] T_Izometrik_Dgr = new Double[4, 4]{ {0.707 , -0.408, 0, 0},
                                                 {0     ,  0.816, 0, 0},
                                                 {-0.707, -0.408, 0, 0},
                                                 {0     , 0     , 0, 0} };

        Double[,] Cisim_Otelemek = new Double[4, 4]{ {1, 0, 0, 0},
                                             {0, 1, 0, 0},
                                             {0, 0, 1, 0},
                                             {0, 0, 0, 1} };
        public Form1()
        {
            InitializeComponent();
        }
        private void GrafikCizme()
        {
            GrafikYap = this.CreateGraphics();
            Kalem.Color = Color.Yellow;
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[6, 0]), KoordinatHesaplaY(Cisim_X_Yeni[6, 1]), KoordinatHesaplaX(Cisim_X_Yeni[7, 0]), KoordinatHesaplaY(Cisim_X_Yeni[7, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[7, 0]), KoordinatHesaplaY(Cisim_X_Yeni[7, 1]), KoordinatHesaplaX(Cisim_X_Yeni[4, 0]), KoordinatHesaplaY(Cisim_X_Yeni[4, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[1, 0]), KoordinatHesaplaY(Cisim_X_Yeni[1, 1]), KoordinatHesaplaX(Cisim_X_Yeni[2, 0]), KoordinatHesaplaY(Cisim_X_Yeni[2, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[2, 0]), KoordinatHesaplaY(Cisim_X_Yeni[2, 1]), KoordinatHesaplaX(Cisim_X_Yeni[3, 0]), KoordinatHesaplaY(Cisim_X_Yeni[3, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[0, 0]), KoordinatHesaplaY(Cisim_X_Yeni[0, 1]), KoordinatHesaplaX(Cisim_X_Yeni[4, 0]), KoordinatHesaplaY(Cisim_X_Yeni[4, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[1, 0]), KoordinatHesaplaY(Cisim_X_Yeni[1, 1]), KoordinatHesaplaX(Cisim_X_Yeni[5, 0]), KoordinatHesaplaY(Cisim_X_Yeni[5, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[0, 0]), KoordinatHesaplaY(Cisim_X_Yeni[0, 1]), KoordinatHesaplaX(Cisim_X_Yeni[1, 0]), KoordinatHesaplaY(Cisim_X_Yeni[1, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[3, 0]), KoordinatHesaplaY(Cisim_X_Yeni[3, 1]), KoordinatHesaplaX(Cisim_X_Yeni[0, 0]), KoordinatHesaplaY(Cisim_X_Yeni[0, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[2, 0]), KoordinatHesaplaY(Cisim_X_Yeni[2, 1]), KoordinatHesaplaX(Cisim_X_Yeni[6, 0]), KoordinatHesaplaY(Cisim_X_Yeni[6, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[3, 0]), KoordinatHesaplaY(Cisim_X_Yeni[3, 1]), KoordinatHesaplaX(Cisim_X_Yeni[7, 0]), KoordinatHesaplaY(Cisim_X_Yeni[7, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[4, 0]), KoordinatHesaplaY(Cisim_X_Yeni[4, 1]), KoordinatHesaplaX(Cisim_X_Yeni[5, 0]), KoordinatHesaplaY(Cisim_X_Yeni[5, 1]));
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Cisim_X_Yeni[5, 0]), KoordinatHesaplaY(Cisim_X_Yeni[5, 1]), KoordinatHesaplaX(Cisim_X_Yeni[6, 0]), KoordinatHesaplaY(Cisim_X_Yeni[6, 1]));
            GrafikYap.Dispose();
        }
        private int KoordinatHesaplaX(Double TutucuX)
        {
            return Convert.ToInt32(500 +100+250 + (100 * TutucuX));
        }
        private int KoordinatHesaplaY(Double TutucuY)
        {
            return Convert.ToInt32(150 + 70+130 + (-100 * TutucuY));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double[,] Tutucu3BX = new Double[2, 4];
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Tutucu3BX[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Tutucu3BX[i, j] += Eksen3BX[i, k] * T_Izometrik_Dgr[k, j];
                    }
                }
            }
            GrafikYap = this.CreateGraphics();
            Kalem.Color = Color.HotPink;
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Tutucu3BX[0, 0]), KoordinatHesaplaY(Tutucu3BX[0, 1]), KoordinatHesaplaX(Tutucu3BX[1, 0]), KoordinatHesaplaY(Tutucu3BX[1, 1])); //X
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Eksen3BY[0, 0]), KoordinatHesaplaY(Eksen3BY[0, 1]), KoordinatHesaplaX(Eksen3BY[1, 0]), KoordinatHesaplaY(Eksen3BY[1, 1]));//Y
            GrafikYap.DrawLine(Kalem, KoordinatHesaplaX(Tutucu3BX[0, 0]), KoordinatHesaplaY(Tutucu3BX[0, 1]), KoordinatHesaplaX(Tutucu3BX[1, 0] * -1), KoordinatHesaplaY(Tutucu3BX[1, 1])); //Z
            GrafikYap.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Double[,] Tutucu = new Double[8, 4];

            if (OLX.Text != "")
                Cisim_Olceklemek[0, 0] = Convert.ToDouble(OLX.Text);
            if (OLY.Text != "")
                Cisim_Olceklemek[1, 1] = Convert.ToDouble(OLY.Text);
            if (OLZ.Text != "")
                Cisim_Olceklemek[2, 2] = Convert.ToDouble(OLZ.Text);

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Tutucu[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Tutucu[i, j] += X_Cisim_Noktalar[i, k] * Cisim_Olceklemek[k, j];
                    }
                }
            }
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Cisim_X_Yeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Cisim_X_Yeni[i, j] += Tutucu[i, k] * T_Izometrik_Dgr[k, j];
                    }
                }
            }
            Kalem.Color = Color.FromArgb(233, 147, 64);
            GrafikCizme();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Cisim_X_Yeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Cisim_X_Yeni[i, j] += T_Izometrik_Dgr[k, j] * X_Cisim_Noktalar[i, k];
                    }
                }
            }
            Kalem.Color = Color.Purple;
            GrafikCizme();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void OLZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void OLY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OTX.Text != "")
                Cisim_Otelemek[3, 0] = Convert.ToDouble(OTX.Text);
            if (OTY.Text != "")
                Cisim_Otelemek[3, 1] = Convert.ToDouble(OTY.Text);
            if (OTZ.Text != "")
                Cisim_Otelemek[3, 2] = Convert.ToDouble(OTZ.Text);
            Double[,] Tutucu = new Double[8, 4];
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Tutucu[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Tutucu[i, j] +=Cisim_Otelemek[k, j] * X_Cisim_Noktalar[i, k];
                    }
                }
            }
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Cisim_X_Yeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Cisim_X_Yeni[i, j] += Tutucu[i, k] * T_Izometrik_Dgr[k, j];
                    }
                }
            }
            Kalem.Color = Color.GreenYellow;
            GrafikCizme();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
