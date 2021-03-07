using System;

class Pattern_14
{
    public static void Main(string[] args)
    {

        for (char i = 'A'; i <= 'E'; i++)
        {
            for (char j = 'A'; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
