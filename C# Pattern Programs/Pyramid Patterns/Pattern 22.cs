using System;

class Pattern_65
{
    public static void Main(string[] a)
    {

        for (int i = 1; i <= 5; i++)
        {
            for (int k = 4; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
