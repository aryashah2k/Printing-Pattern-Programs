using System;

class Pattern_175
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write(j + " " + i + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
