using System;

class Pattern_124
{
    public static void Main(string[] args)
    {
        int n = 3; //size
        int z = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 2; j > 0; j--)
            {
                for (int x = n - 1; x > i; x--)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < z; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            z += 2;
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
