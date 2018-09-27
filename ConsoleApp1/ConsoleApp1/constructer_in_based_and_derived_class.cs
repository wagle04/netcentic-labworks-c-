using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class parentforconstuctor
        {
            public parentforconstuctor(int a)
            {
                Console.WriteLine("Parent1");
            }
            public parentforconstuctor(string a)
            {
                Console.WriteLine("Parent2");
            }


    }

    class childforconstructor : parentforconstuctor
    {
        public childforconstructor() : base("hello")
        {
            Console.WriteLine("Child");
        }
    }


    
}
