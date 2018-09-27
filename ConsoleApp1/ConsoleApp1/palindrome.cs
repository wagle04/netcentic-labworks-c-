using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class palindrome
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Console.WriteLine("Enter a string:");
            string a = Console.ReadLine();
            int l = a.Length;
            for (int i = 0; i < l; i++)
            {
                if (a[i] == a[l - i - 1])
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Not a palindrome");
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Palindrome");
            }

            Console.ReadKey();

        }
    }
}
