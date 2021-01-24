using System;

class EvenNumbersSeries
{
    public static void Main(string[] agrs)
    {
        int n = 5; //size

        for (int i = 1; i <= n; i++)
        {
            Console.Write(" " + (2 * i));
        }
        Console.ReadKey(true);
    }
}

/*
 OUTPUT :

 2 4 6 8 10

 **/
