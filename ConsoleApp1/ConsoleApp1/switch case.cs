using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class switch_case
    {
         static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("Enter a choice");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("sunday");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Monday");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Number!");

                        Console.ReadLine();
                        break;
                    }
            }
        }

        }
}
