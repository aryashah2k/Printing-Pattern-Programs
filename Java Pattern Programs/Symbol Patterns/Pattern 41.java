class Pattern_127
{
    public static void main(String args[])
    {
        int n = 7; // size

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j == 1 || i == j || i == n)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print(" ");
                }
            }

            System.out.println();
        }

    }
}