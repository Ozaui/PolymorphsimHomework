using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimHomework
{
    public class Shape
    {
        private string name;
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public Shape(string name)
        {
            this.name = name;
        }

        public virtual void calculate()
        {
            Console.WriteLine("Calculating shape...");
        }
        public virtual void showInformation()
        {
            Console.WriteLine("Shape name is " + NAME);
        }
    }
}
