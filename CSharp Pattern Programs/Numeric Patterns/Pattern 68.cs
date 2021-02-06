using System;

class Pattern_162
{
  public static void Main()
     {
       int n = 5; //size
       int i;
       int j;
    int s;

    for (i = n;i >= 1;i--)
    {
     for (s = i;s <= n - 1;s++)
     {
       Console.Write(" ");
     }
      for (j = 1;j <= i;j++)
      {
      if (i % 2 == 0)
      {
      Console.Write((char)(i + 64));
      }
      else
      {
      Console.Write(i);
      }
      }
     Console.WriteLine();
    }
          Console.ReadKey(true);
   }
}
