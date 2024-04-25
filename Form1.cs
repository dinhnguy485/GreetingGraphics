using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;

//23rd April 2024
//New Year Greeting Card 
//Tri Nguyen

namespace GreetingGraphics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.FromArgb(245, 172, 39), 2);
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(192, 24, 0));
            SolidBrush drawString = new SolidBrush(Color.FromArgb(245, 172, 39));
            Font drawFont = new Font("Times New Roman", 16, FontStyle.Bold);

            //draw the first page
            g.Clear(Color.FromArgb(219, 65, 49));
            g.DrawRectangle(drawPen, 15, 15, 390, 440);

            g.FillEllipse(drawBrush, 20, 20, 120, 90);
            g.DrawEllipse(drawPen, 20, 20, 120, 90);
            g.DrawArc(drawPen, 50, 20, 50, 90, 90, -180);
            g.DrawArc(drawPen, 35, 20, 90, 90, 90, 360);
            g.DrawLine(drawPen, 80, 20, 80, 110);
            g.DrawArc(drawPen, 60, 20, 50, 90, 90, 180);

            g.FillEllipse(drawBrush, 280, 20, 120, 90);
            g.DrawEllipse(drawPen, 280, 20, 120, 90);
            g.DrawArc(drawPen, 310, 20, 50, 90, 90, -180);
            g.DrawArc(drawPen, 295, 20, 90, 90, 90, 360);
            g.DrawLine(drawPen, 340, 20, 340, 110);
            g.DrawArc(drawPen, 320, 20, 50, 90, 90, 180);

            g.FillEllipse(drawBrush, 280, 350, 120, 90);
            g.DrawEllipse(drawPen, 280, 350, 120, 90);
            g.DrawArc(drawPen, 310, 350, 50, 90, 90, -180);
            g.DrawArc(drawPen, 295, 350, 90, 90, 90, 360);
            g.DrawLine(drawPen, 340, 350, 340, 440);
            g.DrawArc(drawPen, 320, 350, 50, 90, 90, 180);

            g.FillEllipse(drawBrush, 20, 350, 120, 90);
            g.DrawEllipse(drawPen, 20, 350, 120, 90);
            g.DrawArc(drawPen, 50, 350, 50, 90, 90, -180);
            g.DrawArc(drawPen, 35, 350, 90, 90, 90, 360);
            g.DrawLine(drawPen, 80, 350, 80, 440);
            g.DrawArc(drawPen, 60, 350, 50, 90, 90, 180);

            g.DrawString("Happy Chinese New Year", drawFont, drawString, 100, 200);
        }

        //When the main form is clicked, do some animations
        private void MainForm_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.FromArgb(245, 172, 39), 2);
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(192, 24, 0));
            SolidBrush drawBrush2 = new SolidBrush(Color.FromArgb(255, 215, 0));
            SolidBrush drawString = new SolidBrush(Color.FromArgb(245, 172, 39));
            Font drawFont = new Font("Times New Roman", 16, FontStyle.Bold);
            SoundPlayer newYearVibes = new SoundPlayer(Properties.Resources.Festival_Beat);
            SoundPlayer fireworks = new SoundPlayer(Properties.Resources.Festival_Sound);
            newYearVibes.Play();

            int i = 350;
            g.DrawRectangle(drawPen, 15, 15, 390, 440);

            //make the lanterns move up.
            while (i > 15)
            {
                g.Clear(Color.FromArgb(219, 65, 49));
                g.DrawRectangle(drawPen, 15, 15, 390, 440);
                g.DrawString("Happy Chinese New Year 2024", drawFont, drawString, 60, i+250);
                g.DrawString("I wish you all the best", drawFont, drawString, 100, i+300);
                g.FillEllipse(drawBrush, 20, i, 120, 90);
                g.DrawEllipse(drawPen, 20, i, 120, 90);
                g.DrawArc(drawPen, 50, i, 50, 90, 90, -180);
                g.DrawArc(drawPen, 35, i, 90, 90, 90, 360);
                g.DrawLine(drawPen, 80, i, 80, i + 90);
                g.DrawArc(drawPen, 60, i, 50, 90, 90, 180);

                g.FillEllipse(drawBrush, 280, i, 120, 90);
                g.DrawEllipse(drawPen, 280, i, 120, 90);
                g.DrawArc(drawPen, 310, i, 50, 90, 90, -180);
                g.DrawArc(drawPen, 295, i, 90, 90, 90, 360);
                g.DrawLine(drawPen, 340, i, 340, i + 90);
                g.DrawArc(drawPen, 320, i, 50, 90, 90, 180);

                g.FillEllipse(drawBrush, 20, i-330, 120, 90);
                g.DrawEllipse(drawPen, 20, i-330, 120, 90);
                g.DrawArc(drawPen, 50, i - 330, 50, 90, 90, -180);
                g.DrawArc(drawPen, 35, i-330, 90, 90, 90, 360);
                g.DrawArc(drawPen, 60, i, 50, 90, 90, 180);

                g.FillEllipse(drawBrush, 280, i - 330, 120, 90);
                g.DrawEllipse(drawPen, 280, i-330, 120, 90);
                g.DrawArc(drawPen, 310, i-330, 50, 90, 90, -180);
                g.DrawArc(drawPen, 295, i - 330, 90, 90, 90, 360);
                g.DrawArc(drawPen, 320, i - 330, 50, 90, 90, 180);

                Thread.Sleep(5);
                i--;
            }

            g.Clear(Color.FromArgb(219, 65, 49));
            g.DrawRectangle(drawPen, 15, 15, 390, 440);

            //play sound
            fireworks.Play();

            //lanterns started flashings
            int y = 0;
            while (y < 5)
            {
                g.DrawString("Tri Nguyen", drawFont, drawString, 150, 200);
                //If y is an even number, the lanterns turn yellow.
                if (y % 2 == 0)
                {
                    g.FillEllipse(drawBrush2, 20, 20, 120, 90);
                    g.DrawEllipse(drawPen, 20, 20, 120, 90);
                    g.DrawArc(drawPen, 50, 20, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 35, 20, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 80, 20, 80, 110);
                    g.DrawArc(drawPen, 60, 20, 50, 90, 90, 180);

                    g.FillEllipse(drawBrush2, 280, 20, 120, 90);
                    g.DrawEllipse(drawPen, 280, 20, 120, 90);
                    g.DrawArc(drawPen, 310, 20, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 295, 20, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 340, 20, 340, 110);
                    g.DrawArc(drawPen, 320, 20, 50, 90, 90, 180);

                    g.FillEllipse(drawBrush2, 280, 350, 120, 90);
                    g.DrawEllipse(drawPen, 280, 350, 120, 90);
                    g.DrawArc(drawPen, 310, 350, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 295, 350, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 340, 350, 340, 440);
                    g.DrawArc(drawPen, 320, 350, 50, 90, 90, 180);

                    g.FillEllipse(drawBrush2, 20, 350, 120, 90);
                    g.DrawEllipse(drawPen, 20, 350, 120, 90);
                    g.DrawArc(drawPen, 50, 350, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 35, 350, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 80, 350, 80, 440);
                    g.DrawArc(drawPen, 60, 350, 50, 90, 90, 180);
                }

                //If y is an odd number, the lanterns turn red.
                else
                {
                    g.FillEllipse(drawBrush, 20, 20, 120, 90);
                    g.DrawEllipse(drawPen, 20, 20, 120, 90);
                    g.DrawArc(drawPen, 50, 20, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 35, 20, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 80, 20, 80, 110);
                    g.DrawArc(drawPen, 60, 20, 50, 90, 90, 180);

                    g.FillEllipse(drawBrush, 280, 20, 120, 90);
                    g.DrawEllipse(drawPen, 280, 20, 120, 90);
                    g.DrawArc(drawPen, 310, 20, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 295, 20, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 340, 20, 340, 110);
                    g.DrawArc(drawPen, 320, 20, 50, 90, 90, 180);

                    g.FillEllipse(drawBrush, 280, 350, 120, 90);
                    g.DrawEllipse(drawPen, 280, 350, 120, 90);
                    g.DrawArc(drawPen, 310, 350, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 295, 350, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 340, 350, 340, 440);
                    g.DrawArc(drawPen, 320, 350, 50, 90, 90, 180);

                    g.FillEllipse(drawBrush, 20, 350, 120, 90);
                    g.DrawEllipse(drawPen, 20, 350, 120, 90);
                    g.DrawArc(drawPen, 50, 350, 50, 90, 90, -180);
                    g.DrawArc(drawPen, 35, 350, 90, 90, 90, 360);
                    g.DrawLine(drawPen, 80, 350, 80, 440);
                    g.DrawArc(drawPen, 60, 350, 50, 90, 90, 180);
                }
                Thread.Sleep(1000);
                y++;
            }
        }
    }
}