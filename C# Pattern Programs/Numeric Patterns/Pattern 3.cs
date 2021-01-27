using System;

class Pattern_6
{
    public static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
