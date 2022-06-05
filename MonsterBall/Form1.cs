using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBall
{
    public partial class Form1 : Form
    {
        int timertick;
        Color color;
        public Scene scene { get; set; }
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            timer1.Start();
            timertick = 0;
            color = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timertick++;
            Random random = new Random();

            if(timertick % 5 == 0)
            {
                int height = random.Next(this.ClientSize.Height - (this.ClientSize.Height - 25), this.ClientSize.Height);
                int width = this.ClientSize.Width - (this.ClientSize.Width - 25);
                scene.addCircles(new Point(width,height), color);
               // scene.addCircles(e.Location, color);
            }
            scene.Move();

            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //scene.addCircles(e.Location, color);
            scene.isHit(e.Location);
            Invalidate();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }
    }
}
