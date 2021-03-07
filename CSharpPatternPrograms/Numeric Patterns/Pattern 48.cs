using System;

/*
 * Interesting fact about this pattern :-
 *
 * The last value(bottom-right corner) of the pattern is equal to the sum of all
 * numbers from 1 to n.
 *
 * e.g.
 *
 * 1
 * 2 6
 * 3 7 10
 * 4 8 11 13
 * 5 9 12 14 15
 *
 * last value is 15, which is equal to 1+2+3+4+5
 *
 */
class Pattern_136
{

    public static void Main(string[] args)
    {
        int n = 10; // size

        int i;
        int j;
        int k;

        for (i = 1; i <= n; i++)
        {
            k = i;
            for (j = 1; j <= i; j++)
            {
                Console.Write("{0,2:D} ", k);
                k = k + (n - j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
