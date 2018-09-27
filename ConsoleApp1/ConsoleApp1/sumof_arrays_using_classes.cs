using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sumof_arrays_using_classes
    {
        public static int m, n;
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the size of matrices:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            m = a;
            n = b;

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
        int m = sumof_arrays_using_classes.m;
        int n = sumof_arrays_using_classes.n;
        public int[,] input()
        {

            a = new int[m, n];
            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return a;
        }
        public void display(int[,] a)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int[,] sum(int[,] first, int[,] second)
        {
            int[,] sum = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i, j] = first[i, j] + second[i, j];
                }
            }
            return sum;
        }
    }
}
