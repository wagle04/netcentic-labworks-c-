using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//we cannot use multiple interface in c# but we can use inteeface to do so
namespace ConsoleApp1
{
    class using_interface
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            rectangle r = new rectangle();
            driver d = new driver();
            d.calculate(c);
            d.calculate(r);
            Console.ReadLine();
        }
    }
    interface shape
    {
        void area();
    }
    class circle : shape
    {
        public void area()
        {
            double p, r, a;
            p = 3.14;
            r = 4;
            a = p * r * r;
            Console.WriteLine(a);
        }
    }
    class rectangle : shape
    {
        public void area()
        {
            int l, b, a;
            l = 5;
            b = 10;
            a = l * b;
            Console.WriteLine(a);

        }
    }
    class driver
    {
        public void calculate(shape s)
        {
            s.area();
        }
    }
}
