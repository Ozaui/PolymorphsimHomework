using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimHomework
{
    public class Rectangle : Shape
    {
        private int shortEdge;
        private int longEdge;
        public Rectangle(string name, int shortEdge, int longEdge) : base(name)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }

        public override void calculate()
        {
            base.calculate();
            Console.WriteLine("Envirnment is " + ((shortEdge * 2) + (longEdge * 2)));
            Console.WriteLine("Area is " + (shortEdge * longEdge));
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine("Short edge is " +  shortEdge);
            Console.WriteLine("Long edge is " + longEdge);
        }

    }
}
