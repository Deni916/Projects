﻿using System;

    class Program
    {
        static void Main()
        {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double biggerNumber = a;
        if (b > biggerNumber)
        {
            biggerNumber = b;
        }
        if (c > biggerNumber)
        {
            biggerNumber = c;
        }

        Console.WriteLine("{0}",biggerNumber);







        }
    }

