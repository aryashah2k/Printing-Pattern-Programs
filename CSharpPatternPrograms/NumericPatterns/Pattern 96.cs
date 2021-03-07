using System;

class Pattern_204
{
    public static void Main()
    {
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (j <= i)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write(i + j);
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
