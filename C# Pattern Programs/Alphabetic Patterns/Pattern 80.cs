using System;

class Pattern_202
{
    public static void Main()
    {
        for (char i = 'A'; i <= 'E'; i++)
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
