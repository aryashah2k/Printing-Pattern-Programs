using System;

class Pattern_177
{
    public static void Main()
    {
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j > i)
                {
                    Console.Write("*");
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
