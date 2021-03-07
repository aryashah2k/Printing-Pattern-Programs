class Pattern_229
{
    public static void main(String args[])
    {
        int n = 6; //size
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i % 2 == 0) // for even rows
                {
                    if (j % 2 != 0)
                    {
                        System.out.print("x");
                    }
                    else
                    {
                        System.out.print("o");
                    }
                }
                else // for odd rows
                {
                    if (j % 2 != 0)
                    {
                        System.out.print("o");
                    }
                    else
                    {
                        System.out.print("x");
                    }
                }
            }
            System.out.println("");
        }

    }
}