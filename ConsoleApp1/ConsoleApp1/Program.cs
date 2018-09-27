using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //add obj = new add(); //for using another class
            //obj.sum();
            Console.WriteLine("Enter the screen");
            string s1;
            s1 = Console.ReadLine();
            for ( int i= 0; i < s1.Length;i++)
            {
                Console.WriteLine(s1[i]);
            }
            
            
            Console.ReadLine();
        }
    }
}
