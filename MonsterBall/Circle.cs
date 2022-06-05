using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MonsterBall
{
   public class Circle
    {
        public int radius { get; set; }
        public Point point { get; set; }
        public Color color { get; set; }
        public bool touched { get; set; }

        public Circle(int radius, Point point, Color color)
        {
            this.radius = radius;
            this.point = point;
            this.color = color;
            this.touched = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, point.X - radius, point.Y - radius, radius * 2, radius * 2);
            b.Dispose();
        }

        public void Move()
        {
            point = new Point(point.X + 10, point.Y);
        }

        public bool Hit(Point p)
        {
            int newdistance = (int)Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y,2));

            if(radius * radius >= newdistance)
            {
                touched = true;
                return true;
            }
            return false;
        }
    }
}
