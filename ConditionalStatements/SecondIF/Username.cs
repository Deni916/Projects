using System;

    class Program
    {
        static void Main()
        {
        string username = Console.ReadLine();
        string password = Console.ReadLine();

        bool isUsernameCorrect = username == "pesho123";
        bool isPasswordCOrrect = password == "123456";

        if (isUsernameCorrect && isPasswordCOrrect);
        {
            Console.WriteLine("Successful login");
            Console.WriteLine("Welcome");
        }
        else 
          {
           Console.WriteLine("Invalid login");
          }
        }
    }

