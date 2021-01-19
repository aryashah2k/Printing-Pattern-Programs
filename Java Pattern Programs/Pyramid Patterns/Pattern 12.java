class Pattern_45
{
    public static void main(String args[])
    {
        int n=4; //size
        for (int i=1; i<=n; i++)
        {
            for (int j=n-1; j>=i; j--)
            {
                System.out.print(" ");
            }
            for (int k=i-1; k>=-(i-1); k--)
            {
                System.out.print(i-Math.abs(k));
            }
            System.out.println();
        }
    } //end of main
}  //end of class