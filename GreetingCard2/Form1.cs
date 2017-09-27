using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace GreetingCard2
    // by Julia Scholz, Sep 27th, 2017
    // a greeting card with the cancer constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Parent = pictureBox1;
        }

        private void pictureboxcancer_Click(object sender, EventArgs e)
        {
            SoundPlayer diamondplayer = new SoundPlayer(Properties.Resources.Diamond_Sound_Effect);
            diamondplayer.Play();
            Thread.Sleep(500);

            labelcancer.Dispose();
            labelowner.Dispose();
            cancerpicturebox.Dispose();
            Thread.Sleep(800);
            
            //cancer cosntellation
            SoundPlayer starplayer = new SoundPlayer(Properties.Resources.Twinkling_Stars_Sound_Effect);

            starplayer.Play();
            Graphics formGraphics = this.CreateGraphics();
            Pen starPen = new Pen(Color.White, 10);
            SolidBrush starBrush = new SolidBrush(Color.White);

            formGraphics.DrawEllipse(starPen, 270, 360, 7, 7);
            formGraphics.FillEllipse(starBrush, 270, 360, 7, 7);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(starPen, 450, 290, 10, 10);
            formGraphics.FillEllipse(starBrush, 450, 290, 10, 10);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(starPen, 400, 500, 7, 7);
            formGraphics.FillEllipse(starBrush, 400, 500, 7, 7);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(starPen, 350, 630, 10, 10);
            formGraphics.FillEllipse(starBrush, 350, 630, 10, 10);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(starPen, 530, 210, 7, 7);
            formGraphics.FillEllipse(starBrush, 530, 210, 7, 7);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(starPen, 700, 30, 8, 8);
            formGraphics.FillEllipse(starBrush, 700, 30, 8, 8);
            Thread.Sleep(500);

            Pen linePen = new Pen(Color.Yellow, 6);

            formGraphics.DrawLine(linePen, 270, 365, 450, 295);
            Thread.Sleep(500);
            formGraphics.DrawLine(linePen, 455, 295, 405, 505);
            Thread.Sleep(500);
            formGraphics.DrawLine(linePen, 405, 505, 355, 630);
            Thread.Sleep(400);
            formGraphics.DrawLine(linePen, 455, 295, 530, 215);
            Thread.Sleep(400);
            formGraphics.DrawLine(linePen, 530, 215, 700, 35);
            Thread.Sleep(400);

            //"Cancer Constellation" writing
            Graphics fg = this.CreateGraphics();
            Font ccFont = new Font("Verdana", 35, FontStyle.Bold);
            SolidBrush ccBrush = new SolidBrush(Color.White);

            fg.DrawString("Cancer Constellations", ccFont, ccBrush, 30, 80);
            Thread.Sleep(1000);

            //writing about cancer
            Font writeFont = new Font("Tahoma", 16, FontStyle.Bold);
            SolidBrush writeBrush = new SolidBrush(Color.White);
            
            fg.DrawString("Cancer is one of the constellations", writeFont, writeBrush, 470, 350);
            Thread.Sleep(300);
            fg.DrawString("of the zodiac.", writeFont, writeBrush, 470, 380);
            Thread.Sleep(300);
            fg.DrawString("The period of birth is from 20th, July", writeFont, writeBrush, 470, 410);
            Thread.Sleep(300);
            fg.DrawString("till 10th, August.", writeFont, writeBrush, 470, 440);
            Thread.Sleep(300);
            fg.DrawString("The cancer constellation consists", writeFont, writeBrush, 470, 470);
            Thread.Sleep(300);
            fg.DrawString("of 6 stars and the ruling planet ", writeFont, writeBrush, 470, 500);
            Thread.Sleep(300);
            fg.DrawString("is the moon.", writeFont, writeBrush, 470, 530);
            Thread.Sleep(300);
        }


    }

}