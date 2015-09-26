using System;

    class Program
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double biggerNumber = a;
        double middleNumber = b;
        double smallerNumber = c;

        if (a > b && b > c)
        {
            biggerNumber = a;
            middleNumber = b;
            smallerNumber = c;
            Console.WriteLine("{0} {1} {2}",biggerNumber,middleNumber,smallerNumber);
        }

        if ( a < b && b < c)
        {
            biggerNumber = c;
            middleNumber = b;
            smallerNumber = a;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }

        if (a < b && b > c )
        {
            biggerNumber = b;
            middleNumber = c;
            smallerNumber = a;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }

        if (a == b && a > c)
        {
            biggerNumber = a;
            middleNumber = b;
            smallerNumber = c;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }

        if (a==b && a < c)
        {
            biggerNumber = c;
            middleNumber = a;
            smallerNumber = b;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }

        if ( a > c && c ==b)
        {
            biggerNumber = a;
            middleNumber = c;
            smallerNumber = b;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }

        if (a < c && c==b)
        {
            biggerNumber = c;
            middleNumber = b;
            smallerNumber = a;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }
        if (a == b && b == c)
        {
            biggerNumber = a;
            middleNumber = a;
            smallerNumber = a;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }
        if ( c > a && a > b)
        {
            biggerNumber = c;
            middleNumber = a;
            smallerNumber = b;
            Console.WriteLine("{0} {1} {2}", biggerNumber, middleNumber, smallerNumber);
        }
        
        
           
        }
        

        }


   
    

