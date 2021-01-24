using System;

class Pattern_100
{
    public static void Main(string[] args)
    {
        int p_height = 5; //change  value to increase or decrease the size of piramid


        int p_space = p_height - 1;

        int i;
        int j;
        int k;
        int n;
        int x = 1;

        for (i = 0; i < p_height; i++)
        {
            for (j = p_space; j > i; j--)
            {
                Console.Write(" ");
            }
            for (k = 0; k <= i; k++)
            {
                Console.Write("* "); // space after *
            }


            for (n = (p_height + p_height - 2); n >= x; n--)
            {
                Console.Write(" ");
            }
            for (k = 0; k <= i; k++)
            {
                Console.Write("* ");// space after *
            }

            x += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
