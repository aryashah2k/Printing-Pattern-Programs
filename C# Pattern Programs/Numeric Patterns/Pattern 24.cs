using System;

class Pattern_55
{
    public static void Main(string[] args)
    {
        int size = 3; //limit

        for (int i = size; i >= -size; i--)
        {
            for (int j = size; j >= Math.Abs(i); j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
