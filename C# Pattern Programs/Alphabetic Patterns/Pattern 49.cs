using System;

class Pattern_151
{
   public static void Main()
    {
      int n = 5; //size
      int i;
      int j;

       for (i = 1;i <= n;i++)
    {
      for (j = 1;j <= i;j++)
      {
      if (i % 2 == 0)
      {
      Console.Write((char)(j + 64));
      }
      else
      {
      Console.Write(j);
      }
      }
     Console.WriteLine();
    }
          Console.ReadKey(true);
   }
}
