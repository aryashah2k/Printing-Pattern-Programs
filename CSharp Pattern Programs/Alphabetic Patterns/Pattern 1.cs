using System;

class Pattern_4
{
    public static void Main(string[] a)
    {
        char i;
        char j;

        for (i = 'A'; i <= 'E'; i++)
        {
            for (j = 'A'; j <= 'E'; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
