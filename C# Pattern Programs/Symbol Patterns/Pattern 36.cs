using System;

class Pattern_122
{
    public static void Main(string[] args)
    {
        for (int i = 3; i >= 1; i--)
        {
            for (int x = 2; x > 0; x--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
