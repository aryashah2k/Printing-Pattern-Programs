using System;

class Pattern_58
{
    public static void Main(string[] args)
    {
        int size = 3; //limit

        for (int i = size; i >= -size; i--)
        {
            for (int j = Math.Abs(i); j <= size; j++)
            {
                Console.Write((char)(j + 65));
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
