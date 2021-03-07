 using System;

class Pattern_5
{
    public static void Main(string[] args)
    {
        char i;
        char j;

        for (i = 'A'; i <= 'E'; i++)
        {
            for (j = 'A'; j <= 'E'; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
