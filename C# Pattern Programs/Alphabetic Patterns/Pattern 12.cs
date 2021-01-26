using System;

class Pattern_28
{
   public static void Main()
   {
    int n = 5; // size

     for (int i = 0;i < n;i++)
     {
      for (int j = n - 1;j > i;j--)
      {
      Console.Write(" ");
      }
      for (int k = 0;k <= i;k++)
      {
      Console.Write((char)(k + 65));
      }

      Console.WriteLine();
     }
        Console.ReadKey(true);
    }
}
