using System;

class Pattern_20
{
    public static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
