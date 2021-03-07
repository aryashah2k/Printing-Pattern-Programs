using System;

class Pattern_101
{
    public static void Main(string[] args)
    {

        int p_height = 5;

        /*
        change value of 'p_height' to increase or decrease the size of pyramid
        */


        int p_space = p_height - 1;

        int i, j, k, n, x = 1;


        /pyramid on top/

        for (i = 1; i <= p_height; i++)
        {

            /Broad Space/
            for (n = 1; n <= p_height; n++)
            {
                Console.Write(" ");
            }

            for (k = p_space; k >= i; k--)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("* "); // space after *
            }

            Console.WriteLine();

        }


        /bottom pyramids/

        for (i = 0; i < p_height; i++)
        {
            for (j = p_space; j > i; j--)
            {
                Console.Write(" ");
            }
            for (k = 0; k <= i; k++)
            {
                Console.Write("* ");// spaces after *
            }

            for (n = (p_height + p_height - 2); n >= x; n--)
            {
                Console.Write(" ");
            }
            for (k = 0; k <= i; k++)
            {
                Console.Write("* "); // spaces after *
            }

            x += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
