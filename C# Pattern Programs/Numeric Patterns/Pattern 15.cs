using System;

class Pattern_35
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int z = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < z; k++)
            {
                Console.Write(z - i);
            }
            z += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
