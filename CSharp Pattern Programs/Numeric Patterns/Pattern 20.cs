using System;

class Pattern_45
{
    public static void Main(string[] args)
    {
        int n = 4; //size
        for (int i = 1; i <= n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = i - 1; k >= -(i - 1); k--)
            {
                Console.Write(i - Math.Abs(k));
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
