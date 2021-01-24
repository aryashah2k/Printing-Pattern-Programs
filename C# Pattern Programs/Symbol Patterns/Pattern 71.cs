using System;

class Pattern_193
{
    public static void Main()
    {
        int n = 5;
        for (int i = n; i >= 0; i--)
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
