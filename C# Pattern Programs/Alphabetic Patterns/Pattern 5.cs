using System;

class Pattern_13
{
    public static void Main(string[] args)
    {
        char i;
        char j;

        for (i = 'A'; i <= 'E'; i++)
        {
            for (j = 'A'; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
