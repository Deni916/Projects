using System;
    class Program
    {
        static void Main()
        {
        int p = 5;
        int n = 291;
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);


        }
    }

