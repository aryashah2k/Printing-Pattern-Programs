using System;

class Pattern_194
{
    public static void Main()
    {
        int n = 5;
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (i > j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
