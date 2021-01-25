using System;

class Pattern_73
{
    public static void Main(string[] args)
    {
        int i;
        int j;
        int k;

        for (i = 4; i >= 0; i--)
        {
            for (k = 3; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (j = i; j >= 0; j--)
            {
                Console.Write((char)(j + 65)+" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
