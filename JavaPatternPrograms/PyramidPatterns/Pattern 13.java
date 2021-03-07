 class Pattern_46
 {
     public static void main(String args[])
     {
     int n = 4; //size
     int z = 1;
     int i;
     int j;
     int k;
      
     for (i = 0;i < n;i++)
     {
     for (j = n - 1;j >= i;j--)
     {
     System.out.print(" ");
     }
 
     for (k = i;k >= -i;k--)
     {
     System.out.print((char)(i - Math.abs(k) + 65));
     }
     z += 2;
     System.out.print("\n");
     }
      
     }
 }