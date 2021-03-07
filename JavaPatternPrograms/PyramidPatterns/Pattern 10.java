class Pattern_43
{
    public static void main(String args[])
    {
        int n=5; //size
        int z=1;

        for (int i=1; i<=n; i++)
        {
            for (int j=n-1; j>=i; j--)
            {
                System.out.print(" ");
            }
            for (int k=z; k>=1; k--)
            {
                System.out.print(Math.abs(k-i));
            }
            z+=2;
            System.out.println();
        }
    } //end of main
}  //end of class