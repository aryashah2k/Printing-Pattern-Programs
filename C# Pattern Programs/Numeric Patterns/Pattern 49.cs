using System;

public class Pattern_137
{

    public static void Main(string[] agrs)
    {
        int i;
        int j;
        int k;
        int n = 5; //size

        for (i = 1; i <= n; i++)
        {

            k = (i % 2 == 0) ? 2 : 1;

            for (j = 1; j <= i; j++)
            {
                Console.Write(k+" ");
                k += 2;
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
