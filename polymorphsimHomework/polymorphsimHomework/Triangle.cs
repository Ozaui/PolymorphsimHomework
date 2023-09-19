using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimHomework
{
    public class Triangle : Shape
    {
        private int @base;
        private int @height;
        public Triangle(string name, int @base, int height) : base(name)
        {
            this.@base = @base;
            this.height = height;
        }

        public override void calculate()
        {
            base.calculate();
            Console.WriteLine("Area is " + (@base * @height) / 2);
        }

        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine("Height is " + @height);
            Console.WriteLine("Base is " + @base);
        }
    }
}
