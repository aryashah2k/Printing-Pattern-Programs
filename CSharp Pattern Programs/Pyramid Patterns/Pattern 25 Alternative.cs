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
