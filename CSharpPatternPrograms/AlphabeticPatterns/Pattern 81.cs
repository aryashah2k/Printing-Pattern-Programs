using System;

class Pattern_203
{
    public static void Main()
    {
        for (char i = 'E'; i >= 'A'; i--)
        {
            for (char j = 'A'; j <= 'E'; j++)
            {
                if (j < i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
