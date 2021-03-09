using System;

   class Wave_24
 {
    public static void Main(string[] args)
    {

    int wave_height = 5; //change  value to increase or decrease the height of wave
    int wave_length = 4; //change  value to increase or decrease the length of wave

    int i;
    int j;
    int k;



    for (i = 1;i <= wave_height;i++)
    {
    for (j = 1;j <= wave_length;j++)
    {
    if (i != wave_height)
    {
    Console.Write("##");
    }
    else
    {
    Console.Write("  "); // 2 spaces
    }

    for (k = 1;k <= 4;k++)
    {
    if (i == 1 || k == 1 || k == 4)
    {
    Console.Write("  ");
    }
    else
    {
    Console.Write("##");
    }
    }

    if (i != wave_height)
    {
    Console.Write("##");
    }
    else
    {
    Console.Write("  "); // 2 spaces
                }
    }

    Console.WriteLine();
    }

     Console.ReadKey(true);
    }
 }
