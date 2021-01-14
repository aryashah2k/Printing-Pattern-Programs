class SpiralCharPattern
{
    public static void main(String args[])
    {
        int n = 8; // change to change size
        int[][] a = new int[8][8]; // same as 'n'
        int i;
        int j;
        int ot;

        int x = 0;
        int y = 0;
        int z = 0;

        for (ot = 0; ot <= n / 2; ot++)
        {
            if (ot == n / 2)
            {
                z--;
            }
            for (j = y; j < n - y; j++)
            {
                a[x][j] = z;
                z++;
            }
            for (i = x + 1; i < n - x - 1; i++)
            {
                a[i][n - y - 1] = z;
                z++;
            }
            for (j = n - y - 1; j >= y; j--)
            {
                a[n - x - 1][j] = z;
                z++;
            }
            for (i = n - x - 2; i > x; i--)
            {
                a[i][y] = z;
                z++;
            }
            x++;
            y++;
        }

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (a[i][j] >= 26)
                {
                    a[i][j] %= 26; // reset print char to A
                }

                System.out.print((char)(a[i][j] + 65)+" ");
            }
            System.out.println();
        }
    }
}