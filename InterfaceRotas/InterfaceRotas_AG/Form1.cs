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

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar a folha em branco
            Bitmap img = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics desenhador = Graphics.FromImage(img);
            
            //limpa e atribuir uma nova cor de fundo a imagem
            desenhador.Clear(Color.LightSlateGray);

            //desenhar um retângulo na imagem
            int x = 38, y = 38;
            Rectangle rect = new Rectangle(x, y, 120, 120);
            Rectangle rect1 = new Rectangle(x, rect.Y + rect.Height + y, 120, 120);
            Rectangle rect2 = new Rectangle(x, rect1.Y + rect.Height + y, 120, 120);
            Rectangle rect3 = new Rectangle(x, rect2.Y + rect.Height + y, 120, 120);

            Rectangle rect4 = new Rectangle(rect.X + rect.Width + x, y, 120, 120);
            Rectangle rect5 = new Rectangle(rect4.X + rect.Width + x, y, 120, 120);
            Rectangle rect6 = new Rectangle(rect5.X + rect.Width + x, y, 120, 120);
            Rectangle rect7 = new Rectangle(rect6.X + rect.Width + x, y, 120, 120);

            Rectangle rect8 = new Rectangle(rect4.X, rect1.Y , 120, 120);
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

            //cruzamentos 
            Rectangle cruzamento_1 = new Rectangle(rect4.X - x, rect.Y - y, x, y);
            Rectangle cruzamento_2 = new Rectangle(rect.X - x, rect.Y - y, x, y);
            Rectangle cruzamento_3 = new Rectangle(rect5.X - x, rect.Y - y, x, y);
            Rectangle cruzamento_4 = new Rectangle(rect6.X - x, rect.Y - y, x, y);
            Rectangle cruzamento_5 = new Rectangle(rect7.X - x, rect.Y - y, x, y);
            Rectangle cruzamento_6 = new Rectangle(rect7.X + rect7.Height, rect.Y - y, x, y);
            Rectangle cruzamento_7 = new Rectangle(rect.X - x, rect1.Y - y, x, y);
            Rectangle cruzamento_8 = new Rectangle(rect4.X - x , rect1.Y - y, x, y);
            Rectangle cruzamento_9 = new Rectangle(rect5.X - x, rect1.Y - y, x, y);
            Rectangle cruzamento_10 = new Rectangle(rect6.X - x, rect1.Y - y, x, y);
            Rectangle cruzamento_11 = new Rectangle(rect7.X - x, rect1.Y - y, x, y);
            Rectangle cruzamento_12 = new Rectangle(rect7.X + rect7.Height, rect1.Y - y, x, y);
            Rectangle cruzamento_13 = new Rectangle(rect.X - x, rect2.Y - y, x, y);
            Rectangle cruzamento_14 = new Rectangle(rect4.X - x, rect2.Y - y, x, y);
            Rectangle cruzamento_19 = new Rectangle(rect.X - x, rect3.Y - y, x, y);
            Rectangle cruzamento_25 = new Rectangle(rect.X - x,  rect3.Y + rect3.Height, x, y);
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



            //Pen lapis = new Pen(Color.Black, 2);
            //desenhador.DrawRectangle(lapis, rect);
            Brush pincel = new SolidBrush(Color.ForestGreen);
            Brush pincel_cruzamento = new SolidBrush(Color.AntiqueWhite);
            desenhador.FillRectangle(pincel, rect);
            desenhador.FillRectangle(pincel, rect1);
            desenhador.FillRectangle(pincel, rect2);
            desenhador.FillRectangle(pincel, rect3);
            desenhador.FillRectangle(pincel, rect4);
            desenhador.FillRectangle(pincel, rect5);
            desenhador.FillRectangle(pincel, rect6);
            desenhador.FillRectangle(pincel, rect7);
            desenhador.FillRectangle(pincel, rect8);
            desenhador.FillRectangle(pincel, rect9);
            desenhador.FillRectangle(pincel, rect10);
            desenhador.FillRectangle(pincel, rect11);
            desenhador.FillRectangle(pincel, rect12);
            desenhador.FillRectangle(pincel, rect13);
            desenhador.FillRectangle(pincel, rect14);
            desenhador.FillRectangle(pincel, rect15);
            desenhador.FillRectangle(pincel, rect16);
            desenhador.FillRectangle(pincel, rect17);
            desenhador.FillRectangle(pincel, rect18);
            desenhador.FillRectangle(pincel, rect19);
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

            //apresenta a imagem final
            pictureBox2.BackgroundImage = img;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
