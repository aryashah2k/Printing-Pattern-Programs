using System;

class Pattern_183
{
    public static void Main()
    {
        int n = 5;
        for (int i = n; i >= 1; i--)
        {
            for (int j = n; j >= 1; j--)
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
