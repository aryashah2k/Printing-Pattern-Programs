class GlobalMembersNew5
{
   public static void main(String args[])
   {
    int wH = 4; //wave height-> change value to increase or decrease the height of wave


    int wL = 4; //wave length->change value to increase or decrease the length of wave


    int x = wH - 1; //if cond for printing



    for (int i = 0;i <= wH;i++)
    {
     for (int j = 0;j < wH * wL * 2;j++)
     {

        if (j % (wH * 2) == x || j % (wH * 2) == wH + i)
        {
        System.out.printf("%02d",j);
        }
        else
        {
         System.out.print(" ");
        }
     }
       x--;
     System.out.println();
    }
   
   }
}