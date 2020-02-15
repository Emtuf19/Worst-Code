using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int result;

            Console.WriteLine("Enter a number");            
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");            
            numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne != numberTwo)
            {
                result = numberOne + numberTwo;
                Console.WriteLine("Adding your numbers gives the result " + result);
                Console.ReadLine();
            }
            else
            {
                result = (numberOne + numberTwo) * 3;
                Console.WriteLine("Entering the same number will result in triple the sum " + result);
                Console.ReadLine();
            }
        }
    }
}
