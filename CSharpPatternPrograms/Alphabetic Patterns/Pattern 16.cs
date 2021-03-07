using System;

class Pattern_38
{
    public static void Main(string[] args)
    {
        int m = 0;

        int p_height = 5; //change  value to increase or decrease the size of piramid
        int p_space = p_height - 1;

        for (int i = 0; i < p_height; i++)
        {
            for (int j = p_space; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= m; k++)
            {
                Console.Write((char)(m + 65));
            }
            m += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
