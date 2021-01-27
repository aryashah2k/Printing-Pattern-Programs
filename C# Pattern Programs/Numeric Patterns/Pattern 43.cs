using System;

class Pattern_105
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int i;
        int j;

        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                if (i == j || i + j == n + 1)
                {
                    Console.Write(j+" ");
                }
                else
                {
                    Console.Write("  "); // 2spaces
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);

    }
}
