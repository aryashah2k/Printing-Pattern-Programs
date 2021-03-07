using System;

class Pattern_1
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
