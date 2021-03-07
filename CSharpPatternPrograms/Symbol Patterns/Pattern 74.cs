using System;

class Pattern_208
{
    public static void Main()
    {
        int size = 4;
        for (int i = size; i >= -size; i--)
        {
            for (int j = 0; j <= Math.Abs(i); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
