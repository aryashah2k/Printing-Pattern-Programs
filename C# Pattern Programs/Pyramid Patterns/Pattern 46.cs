using System;

class PyramidSymbol
{
    public static void Main()
    {
        int p_height = 5;

        for (int i = 1; i <= p_height; i++)
        {
            for (int k = p_height - 1; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("* "); // space after *
                }
                else
                {
                    Console.Write("+ "); // space after +
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
