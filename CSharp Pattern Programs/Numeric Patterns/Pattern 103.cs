using System;

class Pattern_216
{
    public static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
