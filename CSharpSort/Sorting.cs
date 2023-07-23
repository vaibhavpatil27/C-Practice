using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSort
{
    internal class Sorting
    {
        public void bubblesort(int[] ar)
        {
            int temp;
            for (int i = (ar.Length - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (ar[j - 1] > ar[j])
                    {
                        temp = ar[j - 1];
                        ar[j - 1] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array After Sorting");
            for (int i = (ar.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}
