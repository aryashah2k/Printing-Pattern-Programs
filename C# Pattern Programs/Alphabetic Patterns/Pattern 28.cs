using System;

class Pattern_67
{
    public static void Main(string[] args)
    {

        for (int i = 0; i < 5; i++)
        {
            for (int k = 4; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write((char)(i + 65)+" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
