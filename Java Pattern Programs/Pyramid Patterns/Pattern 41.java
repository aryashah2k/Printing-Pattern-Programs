class Pattern_167
{
   public static void main (String args[])
   {
    int n = 5; //size
    int i;
    int j;
    int s;

    for (i = 1;i <= n;i++)
    {
      for (s = n - 1;s >= i;s--)
      {
         System.out.print(" ");
      }
      for (j = 1;j <= i;j++)
      {
      if (i % 2 == 0)
      {
      System.out.print((char)(j + 64)+" ");
      }
      else
      {
      System.out.print(j+" ");
      }
      }
     System.out.println();
    }
    
   }
}