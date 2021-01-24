using System;

class Pattern_195
{
    public static void Main()
    {
        int n = 5;
        for (int i = n; i >= 0; i--)
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
