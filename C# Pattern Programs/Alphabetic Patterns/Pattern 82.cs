using System;

class Pattern_206
{
    public static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = i; j < i + 4; j++)
            {
                Console.Write((char)((j % 4) + 65));
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
