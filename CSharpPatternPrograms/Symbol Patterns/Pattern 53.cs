using System;

public class BarChart2
{
    public static void Main(string[] args)
    {
        int n;
        int[] numArr = new int[20];

        int i;
        int j;

        Console.Write("Enter total number of entities : ");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            Console.Write("Enter value for entity [" + (i + 1) + "] : ");
            numArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n  BAR CHART \n\n");

        for (i = 0; i < n; i++)
        {
            Console.Write("[" + (i + 1) + "]  ");
            for (j = 0; j < numArr[i]; j++)
            {
                Console.Write("#");
            }
            Console.Write("\n\n");
        }

        Console.ReadKey(true);
    }
}
