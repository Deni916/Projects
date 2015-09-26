using System;

    class Program
    {
        static void Main()
        {
        float a = float.Parse(Console.ReadLine()); // Only ","
        float b = float.Parse(Console.ReadLine());

        float  biggerNumber = a;
        float  smallerNumber = b;
         if (b > biggerNumber)
            {
                biggerNumber = b;
                smallerNumber = a;
            }

        Console.WriteLine("{0} {1}", smallerNumber, biggerNumber);
        }
    }

