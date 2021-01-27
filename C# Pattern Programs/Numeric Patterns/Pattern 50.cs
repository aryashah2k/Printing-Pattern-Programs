using System;

public class Pattern_138
{
    public static void Main(string[] args)
    {
        int i;
        int j;
        int k = 0;
        int n = 4; // size

        for (i = 1; i <= n; i++)
        {
            k += i;
            for (j = k; j > k - i; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
