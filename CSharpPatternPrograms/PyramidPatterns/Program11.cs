using System;

class Pattern_44
{
    public static void Main(string[] args)
    {
        int n = 5; //size;
        int z = 1;
        int l = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= z; k++)
            {
                Console.Write((char)(Math.Abs(k - l) + 65));
            }
            l++;
            z += 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
