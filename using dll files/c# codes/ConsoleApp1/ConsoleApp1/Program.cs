using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            add obj = new add();
            obj.sum();
            Console.ReadKey();
        }
    }
}
