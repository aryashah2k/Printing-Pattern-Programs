class Pattern_193
{
    public static void main(String args[])
    {
        int n = 5;
        for (int i = n; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j != 0)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print(i);
                }
            }
            System.out.println("");
        }
    }
}