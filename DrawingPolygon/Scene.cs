using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingPolygon
{
    public class Scene
    {
        public List<Polygon> polygons { get; set; }

        public Scene()
        {
            polygons = new List<Polygon>();
        }

        public void Draw(Graphics g)
        {
            foreach(Polygon p in polygons)
            {
                p.Draw(g);
            }
        }

        public void addPolygon(Point p, int height, int width, Color color)
        {
            Polygon pl = new Polygon(p, height,width, color);
            polygons.Add(pl);
        }
    }
}
