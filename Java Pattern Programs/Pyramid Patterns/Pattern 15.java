class Pattern_48
{
    public static void main(String args[])
    {
        int p_height=4;
        int s=p_height*2-1;
        int p_space=p_height-1;

        for (int i=p_height; i>=1; i--)
        {
            for (int j=p_space; j>=i; j--)
            {
                System.out.print(" ");
            }
            for (int k=1; k<=s; k++)
            {
                System.out.print(i);
            }
            s-=2;
            System.out.println();
        }

    } //end of main
}  //end of class