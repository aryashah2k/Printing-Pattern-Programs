using System;

class Pattern_42
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        int z = 0;
        int i;
        int j;
        int k;

        for (i = 0; i < n; i++)
        {
            for (j = n - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (k = 0; k <= z; k++)
            {
                Console.Write((char)(z - k + 65));
            }
            z += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
