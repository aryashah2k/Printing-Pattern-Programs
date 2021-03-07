class PyramidSymbol
{
    public static void main(String args[])
    {
        int p_height = 5;

        for (int i = 1; i <= p_height; i++)
        {
            for (int k = p_height - 1; k >= i; k--)
            {
                System.out.print(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                if (i % 2 == 0)
                {
                    System.out.print("* "); // space after *
                }
                else
                {
                    System.out.print("+ "); // space after +
                }
            }
            System.out.println("");
        }
    }
}