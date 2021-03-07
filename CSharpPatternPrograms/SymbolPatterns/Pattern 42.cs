using System;

class Pattern_128
{
    public static void Main(string[] args)
    {
        int i;
        int j;
        int n = 7; //size

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (i == 0 || j == 0 || i == j || i == n - 1 || j == n - 1 || i + j == n - 1)
                {
                    Console.Write("* "); // * after spaces
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
