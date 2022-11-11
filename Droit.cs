using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class Droit
    {
        private Point p1;
        private Point p2;

        public Droit(int x1, int y1, int x2, int y2)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }
        public Droit(Point p1, Point p2)
        {
            this.p1 = new Point(p1);
            this.p2 = new Point(p2);
        }
        public void setp1(int x, int y)
        {
            p1.Setx(x);
            p1.Sety(y);
        }
        public void setp2(int x, int y)
        {
            p2.Setx(x);
            p2.Sety(y);
        }
        public Point getp1()
        {
            return p1;
        }
        public Point getp2()
        {
            return p2;
        }
        public bool Equality(Droit d)
        {


            return this.p1.Equality(d.p1) == this.p2.Equality(d.p2);
        }
        public bool Parallelism(Droit d)
        {

            return ((d.p1.x1 - this.p1.x1) * (d.p2.y2 - this.p2.y2) == (d.p1.y1 - this.p1.y1) * (d.p2.x2 - this.p2.x2));
        }
        public bool Intersection(Droit d)
        {

            return ((d.p2.y2 - d.p1.y1) * (this.p2.x2 - this.p1.x1)) - ((d.p2.x2 - d.p1.x1 - this.p1.y1)) == 0
        }


    }
}
