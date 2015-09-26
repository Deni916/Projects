using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = Math.Pow(num,power);

            Console.WriteLine(result);




        }
    }
}
