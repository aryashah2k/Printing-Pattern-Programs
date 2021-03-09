using System;

class SquareNumbersSeries
{
    public static void Main(string[] agrs)
    {
        int n = 5; //size

        for (int i = 1; i <= n; i++)
        {
            Console.Write(" " + (i * i));
        }
        Console.ReadKey(true);
    }
}

/*
 OUTPUT :

 1 4 9 16 25

 **/
