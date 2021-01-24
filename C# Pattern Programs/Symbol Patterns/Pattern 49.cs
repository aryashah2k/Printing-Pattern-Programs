using System;

class Heart
{
    public static void Main()
    {
        int i;
        int j;
        int n = 5; //size

        /upper part/

        for (i = n / 2; i <= n; i += 2)
        {
            for (j = 1; j < n - i; j += 2)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        /lower part/

        for (i = n; i >= 1; i--)
        {
            for (j = i; j < n; j++)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= (i * 2) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
