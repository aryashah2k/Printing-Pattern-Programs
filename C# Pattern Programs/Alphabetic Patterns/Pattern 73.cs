using System;

class Pattern_187
{
    public static void Main()
    {
        int n = 4;
        for (int i = n; i >= 0; i--)
        {
            for (int j = 0; j <= n; j++)
            {
                if (j > i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write((char)(j + 65));
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
