using System;

   class Wave_16
 {
    public static void Main(string[] args)
    {

    int wave_height = 5; //change  value to increase or decrease the height of wave
    int wave_length = 4; //change  value to increase or decrease the length of wave

    int i;
    int j;
    int k;
    int @is = 1; //inner space
    int os = 2; //outer space




    for (i = 1;i <= wave_height;i++)
    {
      for (j = 1;j <= wave_length;j++)
      {
       for (k = 1;k <= os;k++)
       {
        Console.Write(" ");
       }
        Console.Write("0");

       for (k = 1;k <= @is;k++)
       {
        Console.Write(" ");
       }
        Console.Write("0");

       for (k = 1;k <= os;k++)
       {
        Console.Write(" ");
       }
        Console.Write(" ");
      }

       /* set value of os to 1 if i+1 is not equal to wave height or 0 otherwise*/
 os = ((i + 1) != wave_height)?1:0;

       @is = ((i + 1) != wave_height)?3:5;
       /* set value of is to 3 if i+1 is not equal to wave height or 5 otherwise*/

       Console.WriteLine();
    }
        Console.ReadKey(true);

    }
 }
