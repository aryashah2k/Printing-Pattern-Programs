using System;

class Pattern_212
{
    public static void Main()
    {
        int size = 4;
        for (int i = size; i >= -size; i--)
        {
            for (int j = Math.Abs(i); j >= 0; j--)
            {
                Console.Write((char)(j + 65));
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
