using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca2
{
   public class Scene
    {
        public List<Circle> circles { get; set; }
        

        public Scene()
        {
            circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }

        public void AddCircles(int height)
        {
            Random random = new Random();

            int r = random.Next(height - (height- 30), height);
            Point p = new Point(0, r);
            Circle c = new Circle(p,30,30);
            circles.Add(c);
        }

        public void Move()
        {
            foreach(Circle c in circles)
            {
                c.Move();
            }
        }

        public void Hit(Point p)
        {
            foreach(Circle c in circles)
            {
                c.Hit(p);
            }

            for(int i = circles.Count - 1; i >= 0; i--)
            {
                if(circles[i].state == 4)
                {
              
                    circles.RemoveAt(i);
                } 
            }
        }
    }
}
