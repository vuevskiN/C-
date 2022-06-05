using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca2
{
    public partial class Form1 : Form
    {
        public Scene scene { get; set; }
        int timerticks;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            timer1.Start();
             timerticks = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Hit(e.Location);
            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++timerticks;

            if(timerticks % 10 == 0)
            {
                scene.AddCircles(this.ClientSize.Height);
            }
            scene.Move();
            Invalidate();
        }
    }
}
