using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n! = ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            decimal factoriel = 1;

            while (true)
            {
                Console.Write(n);
                if (n==1)
                {
                    break;
                }
                Console.Write(" * ");
                factoriel *= n;
                n--;
            }
            Console.WriteLine(" = {0}",factoriel);
 

        }
    }
}
