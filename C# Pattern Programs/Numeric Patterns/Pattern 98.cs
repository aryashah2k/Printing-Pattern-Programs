using System;

class Pattern_207
{
    public static void Main()
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write((i + 1 - j));
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
