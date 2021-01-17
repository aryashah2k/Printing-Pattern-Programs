class Pattern_195
{
    public static void main(String args[])
    {
        int n = 5;
        for (int i = n; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                if (i > j)
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