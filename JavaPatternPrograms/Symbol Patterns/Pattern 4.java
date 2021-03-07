class Pattern_24
{
   public static void main(String args[])
   {
    int n = 5; // size
    
     for (int i = 1;i <= n;i++)
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
   

----Alternative Solution----

class Pattern_24
{

   public static void main(String args[])
   {
    int n = 5; //size
    
    for (int i = 1;i <= n;i++)
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