using System;

class Pattern_50
{
    public static void Main(string[] args)
    {
        int p_height = 4;
        int s = p_height * 2 - 1;
        int p_space = p_height - 1;

        for (int i = p_height; i >= 1; i--)
        {
            for (int j = p_space; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= s; k++)
            {
                Console.Write(k);
            }
            s -= 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
