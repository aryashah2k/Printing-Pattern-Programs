class Pattern_53
{
    public static void main(String args[])
    {
        int p_height=4;
        int width=p_height*2-1;
        int p_space=p_height-1;

        for (int i = p_height; i >= 1; i--)
        {
            for (int j = p_space; j >= i; j--)
            {
                System.out.print(" ");
            }
            for (int k = 0; k < width; k++)
            {
                System.out.print((char)(k + 65));
            }
            width -= 2;
            System.out.println("");
        }
    }
}