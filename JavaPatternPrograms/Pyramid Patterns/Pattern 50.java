class Pattern_224
{
    public static void main(String args[])
    {
        int n = 5; //size

        int p = 1;
        int c = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = n - 1; j >= i; j--)
            {
                System.out.print(" ");
            }
            p = 1;
            System.out.print(p);
            while (c < i)
            {
                System.out.print((p *= 2));
                c++;
            }
            while (c > 1)
            {
                System.out.print((p /= 2));
                c--;
            }
            System.out.println("");
        }

    }
}