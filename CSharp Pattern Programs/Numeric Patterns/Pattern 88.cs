using System;

class Pattern_192
{
    public static void Main()
    {
        int n = 5;
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j != 0)
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
