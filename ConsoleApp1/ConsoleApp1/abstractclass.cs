using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class abstractclass
    {
        public void show()
        {
            Console.WriteLine("Show Function of abstract class");
            
        }
    }
    class child : abstractclass
    {
        public void display()
        {
            Console.WriteLine("Display fucntion of child class of abstarct class");
        }
    }
    class child2 : abstractclass
    {
        public void show()
        {
            base.show();
            Console.WriteLine("Child2 function overloading of absbtractclass show fucntion");
        }
    }


}
