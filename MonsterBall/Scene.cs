using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MonsterBall
{
    public class Scene
    {
        public List<Circle> circles { get; set; }

        public Scene()
        {
            circles = new List<Circle>();
        }

        public void Move()
        {
            foreach(Circle c in circles)
            {
                c.Move();
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }

        public void addCircles(Point p, Color color)
        {
            Circle c = new Circle(25, p, color);
            circles.Add(c);
        }

        public void isHit(Point p)
        {
            foreach(Circle c in  circles)
            {
                c.Hit(p);
            }

            for(int i = 0; i < circles.Count - 1; i++)
            {
                if(circles[i].touched == true)
                {
                    circles.RemoveAt(i);
                }
            }
        }
    }
}
