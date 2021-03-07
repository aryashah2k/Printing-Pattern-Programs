using System;

class Pattern_75
 {
  public static void Main()
   {
    int size = 4;
    for (int i = size; i >= -size; i--)
     {
      for (int j = 1; j <= Math.Abs(i); j++)
       {
        Console.Write(" ");
       }
       for (int k = size; k >= Math.Abs(i); k--)
        {
         Console.Write("* "); // space after '*'
        }
     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
