class Pattern_147
{
   public static void main (String args[])
   {
    int m = 1;
    int p_height = 5;
    int p_space = p_height - 1;

    int i; // loop variable
    int j;
    int k;


    int np = 1; // for number printing
    char cp = 'A'; // for char printing

    for (i = 1;i <= p_height;i++)
    {
     for (j = p_space;j >= i;j--)
     {
      System.out.print(" ");
     }

     for (k = 1;k <= m;k++)
     {
      if (i % 2 != 0)
      {
      System.out.print(np);
      np++;
      }
      else
      {
      System.out.print(cp);
      cp++;
      }

      np = (np > 9)?1:np; //reset number
      cp = (cp > 'Z')?'A':cp; //reset character
     }
     m += 2;
     System.out.println();
    }
    
   }
}