using System;

class Pattern_77
{
    public static void Main()
    {
        int size = 4;
        int p;
        int i, j, k;

        for (i = size; i >= -size; i--)
        {
            for (j = 1; j <= Math.Abs(i); j++)
            {
                Console.Write(" ");
            }


            /*initialize p with 1 (i>=0) or j */

            p = (i >= 0) ? 1 : j;

            for (k = size; k >= Math.Abs(i); k--)
            {
                Console.Write(p + " ");
                p++;
            }

           Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
