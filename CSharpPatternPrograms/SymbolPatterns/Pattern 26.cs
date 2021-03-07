using System;

class Pattern_112
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int m = (n / 2) + 1; //center
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == m && j == m)
                {
                    Console.Write("o ");
                }
                else
                {
                    Console.Write("x ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
