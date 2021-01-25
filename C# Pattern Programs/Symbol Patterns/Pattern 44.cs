using System;

public class Pattern_130
{
    public static void Main(string[] args)
    {
        int i;
        int j;

        int n = 7; //size (odd)

        int c1 = (n - 1) / 2; //cond

        int c2 = 3 * n / 2 - 1; //cond

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (j - i == c1 || i + j == c2 || i == c1)
                {
                    Console.Write("* "); // space after *
                }
                else
                {
                    Console.Write("  "); // 2 spaces
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
