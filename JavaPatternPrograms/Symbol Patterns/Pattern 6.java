class Pattern_34
{
    public static void main(String args[])
    {
        int min_stars=1;  /*change value to set min. no. of stars
               in piramid
             take odd no. for odd no. of stars in each row 1-3-5
             etc
             take even no. for even no. stars in each row, 2-4-6
             etc */

        int p_height=5;   //change  value to increase or decrease
        the size of piramid

        int p_space=p_height-1;

        for (int i=0; i<p_height; i++)
        {
            for (int j=p_space; j>i; j--)
            {
                System.out.print(" ");
            }
            for (int k=0; k<min_stars; k++)
            {
                System.out.print("*");
            }
            min_stars+=2;
            System.out.println();
        }
    } //end of main
}  //end of class


/-- Another Logic using if-else --/

class Pattern_34
{
    public static void main(String args[])
    {
        int n = 5; // size

        int px = n; // left print control
        int py = n; // right print control

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < n * 2; j++)
            {
                if (j >= px && j <= py)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print(" ");
                }
            }
            px--;
            py++;

            System.out.println();
        }

    }
}
/--------------------------------/