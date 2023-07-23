using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting();
            int num;

            Console.WriteLine("How Many No. of Array Elements You Enter:");
            num = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[num];
            Console.WriteLine("Enter Elements here:");
            for (int i = 0; i < num; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            s.bubblesort(ar);
            Console.ReadKey();
        }
    }
}