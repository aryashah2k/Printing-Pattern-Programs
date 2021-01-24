using System;

class Pattern_72
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
                Console.Write((char)(i + 65)+" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
