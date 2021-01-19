 class Pattern_100
 {
     public static void main(String args[])
     {
          int p_height = 5; //change  value to increase or 
                   decrease the size of piramid
 
 
     int p_space = p_height - 1;
 
     int i;
     int j;
     int k;
     int n;
     int x = 1;
      
     for (i = 0;i < p_height;i++)
     {
     for (j = p_space;j > i;j--)
     {
     System.out.print(" ");
     }
     for (k = 0;k <= i;k++)
     {
     System.out.print("* ");
     }
 
 
     for (n = (p_height + p_height - 2);n >= x;n--)
     {
     System.out.print(" ");
     }
     for (k = 0;k <= i;k++)
     {
     System.out.print("* ");
     }
 
     x += 2;
     System.out.print("\n");
     }
      
     }
 }