using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sumof_one_dimensional_array
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("Enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the elements of array:");
            for(int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of elements of array is " + sum);
            Console.ReadKey();
            


        }
    }
}
