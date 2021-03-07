using System;

class FibonacciNumbersSeries
{
    public static void Main(string[] agrs)
    {
        int n = 15; //size or upper limit
        int a = 0;
        int b = 1;
        int c = a + b;

        while (c <= n)
        {
            Console.Write(" " + c);
            c = a + b;
            a = b;
            b = c;
        }
        Console.ReadKey(true);
    }
}

/*
 OUTPUT :

 1 1 2 3 5 8 13

 **/
