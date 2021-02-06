using System;

class Pattern_135
{
    public static void Main(string[] a)
    {
        int i;
        int j;
        int n = 1;

        for (i = 1; i <= 4; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(n);
                n++;
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
