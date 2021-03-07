class Pattern_183
{
    public static void main(String args[])
    {
        int n = 5;
        for (int i = n; i >= 1; i--)
        {
            for (int j = n; j >= 1; j--)
            {
                if (j > i)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print(j);
                }
            }
            System.out.println("");
        }
    }
}