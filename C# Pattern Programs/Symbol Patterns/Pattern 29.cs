using System;

class Pattern_115
{
    public static void Main(string[] args)
    {
        int z = 1;
        int n = 5; //size

        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < n; k++)
            {
                Console.Write("*");
            }
            z++;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
