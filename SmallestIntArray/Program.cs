using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[10];
            Console.WriteLine("Please Enter 10 Value of Array. \n");
            //read array value from user
            for (int i = 0; i < 10; i++)
            {
                s[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest_element = s[0];
            Console.WriteLine("\nDescending Order :");
            foreach (int a in s)
            {
                Console.WriteLine(a);
            }

            //find smallest value
            for (int i = 1; i < 10; i++)
            {
                if (s[i] < smallest_element)
                {
                    smallest_element = s[i];
                }
            }
            Console.WriteLine("\nSamllest integer in the Array : " + smallest_element);
            Array.Sort(s);
            Console.WriteLine("\nAscending Order :");
            foreach (int a in s)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();

        }
    }
}