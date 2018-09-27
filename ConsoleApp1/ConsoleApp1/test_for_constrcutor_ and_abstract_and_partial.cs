using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class test_for_constrcutor__and_abstract
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Constrcutor---");
            constructor c = new constructor();
            Console.WriteLine("---Abstract Classes---");
            child abs = new child();
            abs.show();
            abs.display();
            Console.WriteLine("---Abstract Classes function overlaoding---");
            child2 abs2 = new child2();
            abs2.show();
            Console.WriteLine("---Partial Class---");
            partial_test par = new partial_test();
            par.show();
            par.display();
            Console.WriteLine("---Constructor in based and derived class---");
            childforconstructor cfc = new childforconstructor();
            
            Console.ReadKey();
        }
    }
}
