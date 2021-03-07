class Pattern_184
{
    public static void main(String args[])
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j > i)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print((char)(i + 65));
                }
            }
            System.out.println("");
        }

    }
}