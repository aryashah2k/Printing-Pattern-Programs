using System;

class Pattern_230
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            int t = i - 1;
            for (int j = 1; j <= i; j++)
            {
                Console.Write((t + i) + " ");
                t += 2;
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
