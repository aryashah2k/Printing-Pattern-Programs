using System;

class Pattern_199
{
    public static void Main()
    {
        int n = 5;
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j < i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
