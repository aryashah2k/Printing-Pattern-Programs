using System;

class Pattern_113
{
    public static void Main(string[] a)
    {

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (j == 3 || i == 3)
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
