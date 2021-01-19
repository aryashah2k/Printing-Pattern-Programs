 class Pattern_65
 {
     public static void main(String a[])
     {
 
     for (int i = 1; i <= 5; i++)
     {
      for (int k = 4; k >= i; k--)
      {
       System.out.print(" ");
      }
      for (int j = 1; j <= i; j++)
      {
       System.out.print(i+" ");
       }
      System.out.print("\n");
     }
     
     }
 }