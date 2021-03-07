using System;

class Pattern_125
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if ((j == 1 || j == n) || (i == 1 || i == n))
                {
                    Console.Write("* ");// space after *
                }
                else
                {
                    Console.Write("  "); // 2 spaces
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
