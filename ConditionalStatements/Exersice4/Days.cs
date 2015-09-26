using System;

    class Program
    {
        static void Main()
        {
        string day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("Today is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Today is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("Today is Wednesday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
        }
    }

