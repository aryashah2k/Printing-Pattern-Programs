using System;

class Pattern_188
{
    public static void Main()
    {
        int n = 4;
        for (int i = 0; i <= n; i++)
        {
            for (int j = n; j >= 0; j--)
            {
                if (j > i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write((char)(i + 65));
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
