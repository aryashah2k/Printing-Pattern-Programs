using System;

class Pattern_79
 {
  public static void Main()
   {
    int size = 4;
    int p = 0; // print value

    for (int i = size; i >= -size; i--)
     {
      for (int j = 1; j <= Math.Abs(i); j++)
       {
        Console.Write(" ");
       }
        for (int k = size; k >= Math.Abs(i); k--)
         {
          Console.Write((char)(p + 65) + " ");
         }

        if (i > 0)
         {
          p++;
         }
        else
         {
          p--;
         }

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
