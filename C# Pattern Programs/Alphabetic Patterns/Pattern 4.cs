using System;

class Pattern_9
{
    public static void Main(string[] args)
    {

        for (char i = 'E'; i >= 'A'; i--)
        {
            for (char j = 'E'; j >= 'A'; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
