using System;

    class Program
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());   // Use ","
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        int zero = 0;

        if ( a > 0 && b > 0 && c>0)
        {
            Console.WriteLine("+");
        }

        if (a > 0 && b>0 && c < 0)
        {
            Console.WriteLine("-");
        }

        if (a>0 && b<0 && c<0)
        {
            Console.WriteLine("+");
        }

        if (a < 0 && b<0 && c<0)
        {
            Console.WriteLine("-");
        }

        if (a<0 && b>0 && c>0)
        {
            Console.WriteLine("-");
        }

        if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("+");
        }

        if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("-");
        }

        if (a ==0 && b >0 && c >0)
        {
            Console.WriteLine("0");
        }

        if (a == 0 && b > 0 && c < 0)
        {
            Console.WriteLine("0");
        }

        if (a == 0 && b<0 && c>0)
        {
            Console.WriteLine("0");
        }

        if (a == 0 && b < 0 && c <0)
        {
            Console.WriteLine("0");
        }

        if (a > 0 && b ==0 && c > 0)
        {
            Console.WriteLine("0");
        }

        if (a > 0 && b ==0 && c < 0)
        {
            Console.WriteLine("0");
        }

        if (a < 0 && b ==0 && c > 0)
        {
            Console.WriteLine("0");
        }

        if (a > 0 && b > 0 && c ==0)
        {
            Console.WriteLine("0");
        }

        if (a > 0 && b < 0 && c == 0)
        {
            Console.WriteLine("0");
        }

        if (a < 0 && b <0 && c == 0)
        {
            Console.WriteLine("0");
        }

        if (a < 0 && b > 0 && c ==0)
        {
            Console.WriteLine("0");
        }
        if (a ==0 && b ==0 && c ==0)
        {
            Console.WriteLine("0");
        }

        if (a ==0 && b ==0 && c >0)
        {
            Console.WriteLine("0");
        }

        if (a==0 && b ==0 && c <0)
        {
            Console.WriteLine("0");
        }
        if (a == 0 && b > 0 && c ==0)
        {
            Console.WriteLine("0");
        }
        if (a == 0 && b < 0 && c==0)
        {
            Console.WriteLine("0");
        }
        if (a > 0 && b == 0 && c==0)
        {
            Console.WriteLine("0");
        }
        if (a<0 && b ==0 && c==0)
        {
            Console.WriteLine("0");
        }



        }
    }


