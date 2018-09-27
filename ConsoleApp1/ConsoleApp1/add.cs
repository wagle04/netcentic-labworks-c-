using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class add
    {
        public  void sum()
        {
            int a, b;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Sum of two number is: " + c);

        }
    }
}
