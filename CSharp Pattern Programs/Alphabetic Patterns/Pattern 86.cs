using System;

class Pattern_218
{
    public static void Main()
    {
        int n = 5;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                for (int k = 0; k <= j; k++)
                {
                    Console.Write((char)(j + 65));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
