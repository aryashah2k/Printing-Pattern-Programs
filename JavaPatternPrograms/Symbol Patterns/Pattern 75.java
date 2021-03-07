class Pattern_213
{
    public static void main(String args[])
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    System.out.print("*");
                }
                System.out.println("");
            }
            System.out.println("");
        }

    }
}