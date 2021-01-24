using System;

class Pattern_224
{
    public static void Main()
    {
        int n = 5; //size

        int p = 1;
        int c = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                Console.Write(" ");
            }
            p = 1;
            Console.Write(p);
            while (c < i)
            {
                Console.Write((p *= 2));
                c++;
            }
            while (c > 1)
            {
                Console.Write((p /= 2));
                c--;
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}