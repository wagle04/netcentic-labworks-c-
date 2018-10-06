using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class arraylist
    {
        static void Main(string[] args)
        {
            ArrayList arlst = new ArrayList();
            arlst.Add("Ram");
            arlst.Add("Shyam");
            for (int i = 0; i < arlst.Count; i++)
            {
                Console.WriteLine(arlst[i]);
            }
            Console.ReadKey();
        }
    }
}
