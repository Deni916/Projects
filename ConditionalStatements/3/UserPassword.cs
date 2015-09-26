using System;

    class Program
    {
        static void Main()
        {
        string username = Console.ReadLine();
        string password = Console.ReadLine();

        bool isUsernameCorrect = username == "Denis";
        bool isPasswordCorrect = password == "Madonna123456";

        if (isUsernameCorrect && isPasswordCorrect);
        {
            bool isVip = username == "Denis";
            Console.WriteLine("Welcome");
            if (isVip);
            {
                Console.WriteLine("Please take our free donut");
            }
        }
        }
    }

