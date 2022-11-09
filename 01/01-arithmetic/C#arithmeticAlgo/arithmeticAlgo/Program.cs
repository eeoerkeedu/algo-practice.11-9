using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(addition(10, 24));
            Console.WriteLine(subtract(100, 91));
            Console.WriteLine(multiply(7, 70));
            Console.WriteLine(divide(33, 11));


            Console.ReadKey();

        }
        static int addition(int num1, int num2) { return num1 + num2; }
        static int subtract(int num1, int num2) { return(num1 - num2);  }
        static int multiply(int num1, int num2) { return (num1 * num2);  }
        static float divide(int num1, int num2) { return (num1 / num2); }
    }
}
