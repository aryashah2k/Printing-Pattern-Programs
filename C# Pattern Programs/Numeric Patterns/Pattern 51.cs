using System;

public class Pattern_139
{
    public static void Main(string[] args)
    {
        int i;
        int j;
        int k = 1;
        int n = 3; //size
        int x = 1;
        int z;
        int g;

        for (i = 0; i < n; i++)
        {

            for (z = n - 1; z >= i; z--)
            {
                Console.Write("  "); // 2 spaces
            }

            for (j = 0; j < k; j++)
            {
                if (i == j)
                {
                    g = (x + 1) * (j + j);
                    g = (g == 0)?1:g;
                    Console.Write(" " + g);
                    continue;
                }
                x += 2;

                Console.Write(" " + x);
            }
            k += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
