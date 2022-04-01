using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1st_Last_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int i;
            Console.WriteLine("Enter Array Elements");
            for(i=0;i<array.Length;i++)
            { array[i] = Convert.ToInt32(Console.ReadLine()); }
            Array.Sort(array); Console.WriteLine("Array Elements");
            for (i = 0; i < array.Length; i++)
            { Console.WriteLine(array[i]); }
            int min = array.AsQueryable().First();
            int max = array.AsQueryable().Last();
            Console.WriteLine("Minimum Element is {0}", min);
            Console.WriteLine("Maximum Element is {0} ", max);
        }
    }
}
