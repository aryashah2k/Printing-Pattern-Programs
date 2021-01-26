using System;

class Pattern_8
{
    public static void Main(string[] args)
    {

        for (char i = 'E'; i >= 'A'; i--)
        {
            for (char j = 'E'; j >= 'A'; j--)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
