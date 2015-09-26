using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial *i;
            }
            Console.WriteLine(factorial);

        }
    }
}
