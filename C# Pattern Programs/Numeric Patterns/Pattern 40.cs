using System;

class Pattern_93
 {
  public static void Main()
   {
    int n = 9; // size
    int px = n / 2 + 1; // print controls

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j <= n; j++)
       {
        if (j == px || j == n - px + 1)
         {
          Console.Write(px);
         }
        else
         {
          Console.Write(" ");
         }
       }

     if (i <= n / 2)
      {
       px--;
      }
     else
      {
       px++;
      }

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
