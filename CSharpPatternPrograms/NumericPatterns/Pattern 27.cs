using System;

class Pattern_61
{
    public static void Main(string[] args)
    {
        int size = 3;

        for (int i = size; i >= -size; i--)
        {
            for (int j = 1; j <= Math.Abs(i); j++)
            {
                Console.Write(" ");
            }

            for (int k = Math.Abs(i); k <= size; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
