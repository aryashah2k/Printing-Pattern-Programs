using System;

class Pattern_97
 {
  public static void Main()
   {
    int n = 5; // size

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j < n * 2; j++)
       {
        if (j <= i || j >= n * 2 - i)
         {
          Console.Write("*");
         }
        else
         {
          Console.Write(" ");
         }
       }

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
