using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sumof_arrays_using_classes
    {
        static void Main(string[] args)
        {
            forinput t = new forinput();
            int[,] first = t.input();
            int[,] second = t.input();
            int[,] result = t.sum(first, second);
            Console.WriteLine("First Matrix is:");
            t.display(first);
            Console.WriteLine("Second Matrix is:");
            t.display(second);
            Console.WriteLine("Sum of Matrices is:");
            t.display(result);
            Console.ReadLine();

        }
    }
    class forinput
    {
        int[,] a;
        public int[,] input()
        {
            a = new int[2, 2];
            Console.WriteLine("Enter matrix elements:");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return a;
        }
        public void display(int[,] a)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int[,] sum(int[,] first, int[,] second)
        {
            int[,] sum = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = first[i, j] + second[i, j];
                }
            }
            return sum;
        }
    }
}
