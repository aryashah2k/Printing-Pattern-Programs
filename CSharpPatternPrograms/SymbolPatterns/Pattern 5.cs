using System;

class Pattern_29
{
   public static void Main()
   {
    int n = 5; // size (max stars)

    for (int i = n;i >= 1;i--)
    {
     for (int j = n - 1;j >= i;j--)
     {
      Console.Write(" ");
     }
     for (int k = 1;k <= i;k++)
     {
      Console.Write("*");
     }
     Console.WriteLine();
    }
        Console.ReadKey(true);
    }
}
/*-- Another Logic using if-else --
class Pattern_29
{

public static void Main()
{
 int n = 5; //size

 for (int i = n;i >= 1;i--)
 {
  for (int j = n;j >= 1;j--)
  {
   if (i >= j)
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
/--------------------------------/
