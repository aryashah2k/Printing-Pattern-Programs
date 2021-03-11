using System;

class SpiralNumberPattern2
{
    public static void Main(string[] args)
    {
        int i = 1;
        int rows = 10;
        int k = 1;
        int x = 1;

        for (x = 1; x <= rows * 2; x += 2)
        {
            if (k % 2 == 1)
            {
                Console.Write("{0:D2} {1:D2} {2:D2} {3:D2} ", i, (i + 1), (i + 2), (i + 3));
                k++;
                i += 4;
            }
            else
            {
                Console.Write("{0:D2} {1:D2} {2:D2} {3:D2} ", (i + 3), (i + 2), (i + 1), i);
                k++;
                i += 4;
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
