using System;

class Pattern_68
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int k = 4; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write((char)(j + 65)+" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}


/*-- Another Logic using if-else --
class Pattern_69
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
   Console.Write("* "); // space after *
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
