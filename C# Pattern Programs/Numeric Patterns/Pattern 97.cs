using System;

class Pattern_205
{
    public static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = i; j < i + 4; j++)
            {
                Console.Write((j % 4) + 1);
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
