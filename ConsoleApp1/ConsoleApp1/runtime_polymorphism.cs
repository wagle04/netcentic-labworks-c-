using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class runtime_polymorphism
    {   
        public static void Main(string[] args)
        {
            Bird b = new Parrot();//Bird variable using parrot class
            b.eat();//to us runtime polymorphism we use virtual and override keywords
            //if runtime polymorphism is not used it will display bird eat something..using runitme ploymorphism it will display parrot eat grass
            Console.ReadKey();
        }
    }
    class Bird
    {
        public virtual void eat()
        {
            Console.WriteLine("Bird eat something");
        }
    }
    class Parrot : Bird
    {
        public override void eat()
        {
            Console.WriteLine("Parrot eat grass");
        }
    }
}
