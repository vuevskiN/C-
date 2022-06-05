using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca2
{
   public class Circle
    {
        

        public Color color { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public Point point { get; set; }
        public int state { get; set; } = 1;
        public Circle(Point point, int height, int width)
        {
            this.color = color;
            this.height = height;
            this.width = width;
            this.point = point;
            this.color = Color.Red;
        }

        public void Draw(Graphics g)
        {
            Brush b = null;
                if(state == 1)
            {
                 b = new SolidBrush(Color.Green);
            }

                else if(state ==2)
            {
                 b = new SolidBrush(Color.Yellow);
            }
                else
            {
                 b = new SolidBrush(Color.Red);
            }
            g.FillEllipse(b, point.X, point.Y, width, height);
            b.Dispose();
        }


        public bool Hit(Point p)
        {
            if(30 * 30 >= (point.X - p.X) * (point.X - p.X) + (point.Y - p.Y) * (point.Y - p.Y))
            {
                state++;

                if (state == 3)
               
                    return true;
            }
            
                    return false;
            
        }
        public void Move()
        {
            point = new Point(point.X + 10, point.Y);
        }
    }
}
