using System;

class Pattern_80
{
    public static void Main()
    {
        int size = 4;
        int p;
        int i, j, k;

        for (i = size; i >= -size; i--)
        {
            for (j = 0; j < Math.Abs(i); j++)
            {
                Console.Write(" ");
            }


            /*initialize p with 0 (i>=0) or j */

            p = (i >= 0) ? 0 : j;

            for (k = size; k >= Math.Abs(i); k--)
            {
                Console.Write((char)(p+65) + " ");
                p++;
            }

            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
