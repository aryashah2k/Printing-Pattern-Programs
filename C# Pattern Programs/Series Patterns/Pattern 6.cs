using System;

class CubeNumbersSeries
{
    public static void Main(string[] agrs)
    {
        int n = 5; //size

        for (int i = 1; i <= n; i++)
        {
            Console.Write(" " + (i * i * i));
        }
        Console.ReadKey(true);
    }
}

/*
 OUTPUT :

 1 8 27 64 125

 **/
