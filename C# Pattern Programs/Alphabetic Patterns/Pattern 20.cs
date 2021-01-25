using System;

class Pattern_46
{
    public static void Main(string[] args)
    {
        int n = 4; //size
        int z = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                Console.Write(" ");
            }

            for (int k = i; k >= -i; k--)
            {
                Console.Write((char)(i - Math.Abs(k) + 65));
            }
            z += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
