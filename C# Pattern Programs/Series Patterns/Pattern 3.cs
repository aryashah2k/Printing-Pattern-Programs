using System;

class OddNumbersSeries
{
    public static void Main(string[] agrs)
    {
        int n = 5; //size

        for (int i = 1; i <= n; i++)
        {
            Console.Write(" " + (2 * i - 1));
        }
        Console.ReadKey(true);
    }
}

/*
 OUTPUT :

 1 3 5 7 9

 **/
