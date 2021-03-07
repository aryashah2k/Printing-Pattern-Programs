using System;

class Pattern_98
 {
  public static void Main()
   {
    int n = 7; // size
    int px = 1;

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j <= n; j++)
       {
        if (j <= px || j >= n - px + 1)
         {
          Console.Write("*");
         }
        else
         {
          Console.Write(" ");
         }
       }

     if (i <= n / 2)
      {
       px++;
      }
     else
      {
       px--;
      }

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
