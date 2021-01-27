using System;

class Pattern_43
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int z = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = z; k >= 1; k--)
            {
                Console.Write(Math.Abs(k - i));
            }
            z += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
