using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class Cercle
    {
        private Point center;
        private int r;
        public Cercle(Point center, int r = 0)
        {
            center = new Point(0, 0);
            this.center = center;
            this.r = r;
        }
        public Point getcenter()
        {
            return center;
        }
        public int getr()
        {
            return r;
        }
        public void setcenter(Point center)
        {
            this.center = center;
        }
        public void setr(int r)
        {
            this.r = r;
        }
        //egalité 
        public bool Equality(Cercle c)
        {
            return (this.center.Equality(c.getcenter()) && r == c.getr());

        }
        public double Circumference()
        {
            return Math.PI * 2 * r;

        } 
        public double Area()
        {
            return Math.PI * r * r;

        }
    }
}

