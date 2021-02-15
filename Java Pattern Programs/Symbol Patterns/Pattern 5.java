class Pattern_29
{
   public static void main(String args[])
   {
    int n = 5; // size (max stars)

    for (int i = n;i >= 1;i--)
    {
     for (int j = n - 1;j >= i;j--)
     {
      System.out.print(" ");
     }
     for (int k = 1;k <= i;k++)
     {
      System.out.print("*");
     }
     System.out.println();
    }
    
   }
}

   /-- Another Logic using if-else --/
class Pattern_29
{

   public static void main(String args[])
   {
    int n = 5; //size
   
    for (int i = n;i >= 1;i--)
    {
     for (int j = n;j >= 1;j--)
     {
      if (i >= j)
      {
      System.out.print("*");
      }
      else
      {
      System.out.print(" ");
      }
     }
     System.out.println();
    }
    
   }
}
/--------------------------------/