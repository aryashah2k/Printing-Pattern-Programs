using System;

class Pattern_90
 {
  public static void Main()
   {
    int n = 5; // size
    int px = 1; // print controls
    int py = n * 2 - 1;

    for (int i = n; i >= 1; i--)
     {
      for (int j = 1; j <= n * 2; j++)
       {
        if (j == px || j == py)
         {
          Console.Write((char)(i + 64));
         }
        else
         {
          Console.Write(" ");
         }
       }

     px++;
     py--;

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
