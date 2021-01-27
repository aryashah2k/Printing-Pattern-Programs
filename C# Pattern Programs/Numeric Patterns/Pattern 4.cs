using System;

class Pattern_7
{
    public static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 5; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
