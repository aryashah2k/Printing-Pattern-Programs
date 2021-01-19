 class Pattern_71
 {
     public static void main(String a[])
     {
     int p_height = 5;
     
     for (int i = p_height; i >= 1; i--)
     {
      for (int k = p_height - 1; k >= i; k--)
      {
      System.out.print(" ");
      }
      for (int j = i; j >= 1; j--)
      {
      System.out.print(j+" ");
       }
      System.out.print("\n");
     }
      
     }
 }