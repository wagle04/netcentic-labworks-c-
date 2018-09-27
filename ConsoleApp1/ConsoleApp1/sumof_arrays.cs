using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sumof_arrays
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Enter the size of array:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] array1 = new int[m, n];
            int[,] array2 = new int[m, n];
            int[,] sum = new int[m, n];
            Console.WriteLine("Enter element of first array:");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array1[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter element of second array:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i, j] = array1[i, j] + array2[i, j];
                }
            }
            Console.WriteLine("Sum of two arrays is");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sum[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
