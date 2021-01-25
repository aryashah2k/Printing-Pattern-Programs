using System;

class Pattern_185
{
    public static void Main()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
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
