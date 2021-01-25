using System;

class Pattern_54
{
    public static void Main(string[] args)
    {
        int size = 3;


        for (int i = size; i >= -size; i--)
        {
            for (int j = size; j >= Math.Abs(i); j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
