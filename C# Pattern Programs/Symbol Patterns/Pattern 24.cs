using System;

class Pattern_110
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i <= j)
                {
                    Console.Write("o "); //ANY SYMBOL
                }
                else
                {
                    Console.Write("x "); //ANY SYMBOL
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
