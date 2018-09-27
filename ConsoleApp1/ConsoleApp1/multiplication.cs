using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class multiplication
    {
        static void Main(string[] args)
        {
            int m, n,i,j;
            Console.WriteLine("Enter Two Numbers:");
            m = Convert.ToInt32(Console.ReadLine());
            n= Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= m; i++)
            {
                for (j=0;j<=n;j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j);
                    
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
