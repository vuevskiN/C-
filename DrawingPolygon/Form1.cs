using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPolygon
{
    public partial class Form1 : Form
    {
        public Scene scene { get; set; }
        
        Point currentpoint;
        Point previouspoint;
        int x, y, height, width;
        public Form1()
        {
            InitializeComponent();
            
            scene = new Scene();
            DoubleBuffered = true;
            previouspoint = Point.Empty;
            currentpoint = Point.Empty;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentpoint = e.Location;
            x = previouspoint.X;
            y = previouspoint.Y;

            if (x > currentpoint.X) x = currentpoint.X;
            if (y > currentpoint.Y) y = currentpoint.Y;
            width = Math.Abs(previouspoint.X - currentpoint.X);
            height = Math.Abs(previouspoint.Y - currentpoint.Y);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(previouspoint.IsEmpty)
            {
                previouspoint = e.Location;
            }

            else
            {
                scene.addPolygon(new Point(x, y), height, width, Color.Red);
                
                textBox1.Text = x.ToString();
                textBox2.Text = y.ToString();
                textBox3.Text = previouspoint.ToString();
                textBox4.Text = currentpoint.ToString();
                previouspoint = Point.Empty;
                currentpoint = Point.Empty;
            }
            Invalidate();
        }

        private void textBox4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
                scene.Draw(e.Graphics);

        }
    }
}
