using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter your number: ");
        var number1: Convert.ToInt32(Console.ReadLine());
        Console.Write(number1 % 2 == 0 ? "True" : "False");
        Console.ReadKey();

    
        }
    }

