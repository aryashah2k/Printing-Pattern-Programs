using System;

class Pattern_201
{
    public static void Main()
    {
        for (char i = 'E'; i >= 'A'; i--)
        {
            for (char j = 'A'; j <= 'E'; j++)
            {
                if (j < i)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
