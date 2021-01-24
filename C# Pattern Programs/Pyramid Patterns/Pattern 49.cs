using System;

class Pattern_223
{
    public static void Main()
    {
        int n = 4; //size
        int z = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                Console.Write(" ");
            }

            for (int k = i - 1; k >= -(i - 1); k--)
            {
                Console.Write((char)(z - Math.Abs(k) + 65));
            }
            z += 2;
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}