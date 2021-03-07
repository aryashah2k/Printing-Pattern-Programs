class Pattern_91
{
    public static void main(String args[])
    {
        int n = 9; // size

        int px = n / 2 + 1; // print controls (mid)

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j == px || j == n - px + 1)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print(" ");
                }
            }

            if (i <= n / 2)
                px--;
            else
                px++;

            System.out.println();
        }

    }
}