 class Pattern_38
 {
     public static void main(String args[])
     {
     int m = 0;
 
     int p_height = 5; //change  value to increase or decrease 
                 the size of piramid
 
 
     int p_space = p_height - 1;
 
     int i;
     int j;
     int k;
 
      
     for (i = 0;i < p_height;i++)
     {
     for (j = p_space;j > i;j--)
     {
     System.out.print(" ");
     }
     for (k = 0;k <= m;k++)
     {
     System.out.print((char)(m + 65));
     }
     m += 2;
     System.out.print("\n");
     }
      
     }
 }