using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_log_nums_solved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lognums(5);

            Console.ReadKey();

        }
        static int Lognums(int i) {
            for (int f = 1; f <= i; f++) 
            {
                Console.WriteLine(f);
            }; 
            return 0;
        }
    }
}
