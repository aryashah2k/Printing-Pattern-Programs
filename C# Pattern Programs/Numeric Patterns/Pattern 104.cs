using System;

class Pattern_222
{
    public static void Main()
    {
        int n = 4; //size
        int z = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                Console.Write(" ");
            }

            for (int k = i - 1; k >= -(i - 1); k--)
            {
                Console.Write(z - Math.Abs(k));
            }
            z += 2;
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
