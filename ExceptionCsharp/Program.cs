using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, divide;
            try
            {
                Console.WriteLine("Enter Number a : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number b : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                divide = num1 / num2;
                Console.WriteLine("Value of a/b is : " + divide);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            finally
            {
                Console.WriteLine("\nCode by Vaibhav");
            }
            Console.ReadKey();
        }
    }
}