using System;

class Pattern_106
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int i;
        int j;

        for (i = n; i >= 1; i--)
        {
            for (j = n; j >= 1; j--)
            {
                if (i == j || i + j == n + 1)
                {
                    Console.Write(j+" ");
                }
                else
                {
                    Console.Write("  ");// 2 spaces
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
