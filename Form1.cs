using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceRotas_AG
{
    public partial class Rotas : Form
    {

        public Rotas()
        {
            InitializeComponent();
        }
        private static int x = 38;
        private static int y = 38;
        Graphics desenhador;
        static private Bitmap img;
        static Rectangle rect = new Rectangle(x, y, 120, 120);
        static Rectangle rect1 = new Rectangle(x, rect.Y + rect.Height + y, 120, 120);
        static Rectangle rect2 = new Rectangle(x, rect1.Y + rect.Height + y, 120, 120);
        static Rectangle rect3 = new Rectangle(x, rect2.Y + rect.Height + y, 120, 120);
        static Rectangle rect4 = new Rectangle(rect.X + rect.Width + x, y, 120, 120);
        static Rectangle rect5 = new Rectangle(rect4.X + rect.Width + x, y, 120, 120);
        static Rectangle rect6 = new Rectangle(rect5.X + rect.Width + x, y, 120, 120);
        static Rectangle rect7 = new Rectangle(rect6.X + rect.Width + x, y, 120, 120);
        Rectangle rect8 = new Rectangle(rect4.X, rect1.Y, 120, 120);
        Rectangle rect9 = new Rectangle(rect5.X, rect1.Y, 120, 120);
        Rectangle rect10 = new Rectangle(rect6.X, rect1.Y, 120, 120);
        Rectangle rect11 = new Rectangle(rect7.X, rect1.Y, 120, 120);
        Rectangle rect12 = new Rectangle(rect4.X, rect2.Y, 120, 120);
        Rectangle rect13 = new Rectangle(rect5.X, rect2.Y, 120, 120);
        Rectangle rect14 = new Rectangle(rect6.X, rect2.Y, 120, 120);
        Rectangle rect15 = new Rectangle(rect7.X, rect2.Y, 120, 120);
        Rectangle rect16 = new Rectangle(rect4.X, rect3.Y, 120, 120);
        Rectangle rect17 = new Rectangle(rect5.X, rect3.Y, 120, 120);
        Rectangle rect18 = new Rectangle(rect6.X, rect3.Y, 120, 120);
        Rectangle rect19 = new Rectangle(rect7.X, rect3.Y, 120, 120);
        Rectangle cruzamento_2 = new Rectangle(rect4.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_1 = new Rectangle(rect.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_3 = new Rectangle(rect5.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_4 = new Rectangle(rect6.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_5 = new Rectangle(rect7.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_6 = new Rectangle(rect7.X + rect7.Height, rect.Y - y, x, y);
        Rectangle cruzamento_7 = new Rectangle(rect.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_8 = new Rectangle(rect4.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_9 = new Rectangle(rect5.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_10 = new Rectangle(rect6.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_11 = new Rectangle(rect7.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_12 = new Rectangle(rect7.X + rect7.Height, rect1.Y - y, x, y);
        Rectangle cruzamento_13 = new Rectangle(rect.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_14 = new Rectangle(rect4.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_19 = new Rectangle(rect.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_25 = new Rectangle(rect.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_20 = new Rectangle(rect4.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_26 = new Rectangle(rect4.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_15 = new Rectangle(rect5.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_16 = new Rectangle(rect6.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_21 = new Rectangle(rect5.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_27 = new Rectangle(rect5.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_22 = new Rectangle(rect6.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_17 = new Rectangle(rect7.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_18 = new Rectangle(rect7.X + rect7.Height, rect2.Y - y, x, y);
        Rectangle cruzamento_23 = new Rectangle(rect7.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_24 = new Rectangle(rect7.X + rect7.Height, rect3.Y - y, x, y);
        Rectangle cruzamento_29 = new Rectangle(rect7.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_30 = new Rectangle(rect7.X + rect7.Height, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_28 = new Rectangle(rect6.X - x, rect3.Y + rect3.Height, x, y);
        Brush pincelQuarterao = new SolidBrush(Color.ForestGreen);
        Brush pincel_cruzamento = new SolidBrush(Color.AntiqueWhite);
        Rectangle[] Cruzamentos = new Rectangle[30];
        private int i = 0;

        private void DesenhaQuarteroes()
        {
            desenhador.FillRectangle(pincelQuarterao, rect);
            desenhador.FillRectangle(pincelQuarterao, rect1);
            desenhador.FillRectangle(pincelQuarterao, rect2);
            desenhador.FillRectangle(pincelQuarterao, rect3);
            desenhador.FillRectangle(pincelQuarterao, rect4);
            desenhador.FillRectangle(pincelQuarterao, rect5);
            desenhador.FillRectangle(pincelQuarterao, rect6);
            desenhador.FillRectangle(pincelQuarterao, rect7);
            desenhador.FillRectangle(pincelQuarterao, rect8);
            desenhador.FillRectangle(pincelQuarterao, rect9);
            desenhador.FillRectangle(pincelQuarterao, rect10);
            desenhador.FillRectangle(pincelQuarterao, rect11);
            desenhador.FillRectangle(pincelQuarterao, rect12);
            desenhador.FillRectangle(pincelQuarterao, rect13);
            desenhador.FillRectangle(pincelQuarterao, rect14);
            desenhador.FillRectangle(pincelQuarterao, rect15);
            desenhador.FillRectangle(pincelQuarterao, rect16);
            desenhador.FillRectangle(pincelQuarterao, rect17);
            desenhador.FillRectangle(pincelQuarterao, rect18);
            desenhador.FillRectangle(pincelQuarterao, rect19);
        }

        private void DesenhaAvenidas()
        {
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_8);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_9);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_10);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_11);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_14);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_20);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_15);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_21);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_16);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_22);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_17);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_23);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_7);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_13);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_19);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_1);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_2);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_3);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_4);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_5);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_25);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_26);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_27);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_28);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_29);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_6);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_12);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_18);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_24);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_30);

        }

        private void AtualizaMapa()
        {
            pictureBox2.Invalidate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            img = new Bitmap(pictureBox2.Width, pictureBox2.Height); //criar a folha em branco  
            pictureBox2.BackgroundImage = img;
            desenhador = Graphics.FromImage(img);
            desenhador.Clear(Color.LightSlateGray); //limpa e atribuir a cor cinza do mapa

            /*Desenha Mapa incial*/
            DesenhaQuarteroes();
            DesenhaAvenidas();
            AtualizaMapa();

            AtribuiCruzamentos();

            /*Para Auto Teste*/
            AutoTesteMapa();

            /*Para Leitura No arquivo*/
            //if(LeituraRotas.RealizarLeituraRota()) DesenhaMelhorRota();

            AtualizaMapa();

        }
        private void AutoTesteMapa()
        {
            timer1.Enabled = true;

        }

        private void AtribuiCruzamentos()
        {
            Cruzamentos[0] = cruzamento_1;
            Cruzamentos[1] = cruzamento_2;
            Cruzamentos[2] = cruzamento_3;
            Cruzamentos[3] = cruzamento_4;
            Cruzamentos[4] = cruzamento_5;
            Cruzamentos[5] = cruzamento_6;
            Cruzamentos[6] = cruzamento_7;
            Cruzamentos[7] = cruzamento_8;
            Cruzamentos[8] = cruzamento_9;
            Cruzamentos[9] = cruzamento_10;
            Cruzamentos[10] = cruzamento_11;
            Cruzamentos[11] = cruzamento_12;
            Cruzamentos[12] = cruzamento_13;
            Cruzamentos[13] = cruzamento_14;
            Cruzamentos[14] = cruzamento_15;
            Cruzamentos[15] = cruzamento_16;
            Cruzamentos[16] = cruzamento_17;
            Cruzamentos[17] = cruzamento_18;
            Cruzamentos[18] = cruzamento_19;
            Cruzamentos[19] = cruzamento_20;
            Cruzamentos[20] = cruzamento_21;
            Cruzamentos[21] = cruzamento_22;
            Cruzamentos[22] = cruzamento_23;
            Cruzamentos[23] = cruzamento_24;
            Cruzamentos[24] = cruzamento_25;
            Cruzamentos[25] = cruzamento_26;
            Cruzamentos[26] = cruzamento_27;
            Cruzamentos[27] = cruzamento_28;
            Cruzamentos[28] = cruzamento_29;
            Cruzamentos[29] = cruzamento_30;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void DesenhaMelhorRota()
        {
            this.SuspendLayout();
            for (int i = 0; i < LeituraRotas.Rota.Length; i++)
            {
                for (int j = 0; j < Cruzamentos.Length; j++)
                {
                    if (LeituraRotas.Rota[i] - 1 == j)
                    {
                        desenhador.FillRectangle(Brushes.Red, Cruzamentos[j]);
                    }
                }
            }
            this.ResumeLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (i < 30) desenhador.FillRectangle(Brushes.Red, Cruzamentos[i++]);
            else 
            {
                DesenhaAvenidas();
                i = 0;
            }
            this.ResumeLayout();
            AtualizaMapa();
        }
    }
}
