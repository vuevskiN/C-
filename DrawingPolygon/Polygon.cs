using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingPolygon
{
    public class Polygon
    {
        public int height { get; set; }
        public int width { get; set; }
        public Point point { get; set; }
        public Color color { get; set; }

        public Polygon(Point point, int height, int width, Color color)
        {
            this.point = point;
            this.height = height;
            this.width = width;
            
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, point.X, point.Y, width, height);
            b.Dispose();
        }


    }
}
