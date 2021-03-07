class Pattern_208
{
    public static void main(String args[])
    {
        int size = 4;
        for (int i = size; i >= -size; i--)
        {
            for (int j = 0; j <= Math.abs(i); j++)
            {
                System.out.print("*");
            }
            System.out.println("");
        }
    }
}