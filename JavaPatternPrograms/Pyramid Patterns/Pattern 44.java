class Pattern_170
{
   public static void main (String args[])
   {
    int n = 5; //size
    int i;
    int j;
    int s;

    for (i = n;i >= 1;i--)
    {
     for (s = i;s <= n - 1;s++)
     {
         System.out.print(" ");
     }
      for (j = 1;j <= i;j++)
      {
      if (i % 2 == 0)
      {
      System.out.print((char)(i + 64)+" ");
      }
      else
      {
      System.out.print(i+" ");
      }
      }
     System.out.println();
    }
    
   }
}