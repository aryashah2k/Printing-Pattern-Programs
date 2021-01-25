using System;

class Pattern_200
{
    public static void Main()
    {
        for (char i = 'A'; i <= 'E'; i++)
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
