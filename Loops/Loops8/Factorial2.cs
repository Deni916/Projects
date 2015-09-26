using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factoriel = 1;

            for (int i = 2; i < n; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);

        }
    }
}
