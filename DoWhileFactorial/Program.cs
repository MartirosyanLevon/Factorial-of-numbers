using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write nombre of client:");
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            Console.Write("Factorial of numbre {0}! = ",x);
            do
            {
                factorial *= x--;
            } while (x > 0);
            Console.WriteLine("{0}", factorial);


            Console.ReadKey();
        }
    }
}
