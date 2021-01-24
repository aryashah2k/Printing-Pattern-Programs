using System;

class Pattern_47
{
    public static void Main(string[] args)
    {
        int p_height = 4; //change value to increase or decrease the size of piramid

        int max_stars = p_height * 2 - 1;

        int p_space = p_height - 1;

        for (int i = p_height; i >= 1; i--)
        {
            for (int j = p_space; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= max_stars; k++)
            {
                Console.Write("*");
            }
            max_stars -= 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class




