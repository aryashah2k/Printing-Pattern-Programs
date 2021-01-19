 class Wave_22
 {
     public static void main(String args[])
     {
 
     int wave_height = 4; //change  value to increase or 
                    decrease the height of wave
     int wave_length = 4; //change  value to increase or 
                    decrease the length of wave
 
     int i;
     int j;
     int k;
 
      
 
     for (i = 1;i <= wave_height;i++)
     {
     for (j = 1;j <= wave_length;j++)
     {
     if (i != wave_height)
     {
     System.out.print("  ");
     }
     else
     {
     System.out.print("* ");
     }
 
     for (k = 1;k <= 4;k++)
     {
     if (i == 1 || k == 1 || k == 4)
     {
     System.out.print("* ");
     }
     else
     {
     System.out.print("  ");
     }
     }
 
     if (i != wave_height)
     {
     System.out.print("  ");
     }
     else
     {
     System.out.print("* ");
     }
     }
 
     System.out.print("\n");
     }
      
     }
 }