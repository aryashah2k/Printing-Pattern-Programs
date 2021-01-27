using System;

class Pattern_25
{
   public static void Main()
   {
    int n = 5; // size

     for (int i = 1;i <= n;i++)
     {
      for (int j = n - 1;j >= i;j--)
      {
      Console.Write(" ");
      }
      for (int k = 1;k <= i;k++)
      {
      Console.Write(i);
      }

      Console.WriteLine();
     }
        Console.ReadKey(true);
    }
}
