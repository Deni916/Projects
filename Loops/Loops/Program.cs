using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = 1;


            while ( number <= 10)
            {
                if (number ==7)
                {
                    break;
                }

                Console.WriteLine(number);
                number++;
            }






        }
    }
}
