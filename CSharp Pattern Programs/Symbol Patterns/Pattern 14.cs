using System;

class Pattern_86
 {
  public static void Main()
   {
    int n = 5; // size
    int px = 1; // print controls
    int py = n * 2 - 1;
    
    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j <= n * 2; j++)
       {
        if (j == px || j == py)
         {
          Console.Write("*");
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
