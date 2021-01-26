using System;

class Pattern_107
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int i;
        int j;

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (i == j || i + j == n - 1)
                {
                    Console.Write((char)(i + 65)+" ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
