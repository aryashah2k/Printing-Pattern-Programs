using System;

class Pattern_191
{
    public static void Main()
    {
        int n = 4;
        for (int i = n; i >= 0; i--)
        {
            for (int j = n; j >= 0; j--)
            {
                if (j > i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write((char)(j + 65));
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
