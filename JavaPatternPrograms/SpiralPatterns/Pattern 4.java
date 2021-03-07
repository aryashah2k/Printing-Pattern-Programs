class SpiralNumberPattern2
{
    public static void main(String args[])
    {
        int i=1;
        int rows = 10;
        int k = 1;
        int x = 1;

        for (x = 1; x <= rows * 2; x += 2)
        {
            if (k % 2 == 1)
            {
                System.out.printf("%02d %02d %02d %02d ",i,(i+1),(i+2),(i+3));
                k++;
                i += 4;
            }
            else
            {
                System.out.printf("%02d %02d %02d %02d ",(i+3),(i+2),(i+1),i);
                k++;
                i += 4;
            }
            System.out.println();
        }
    }
}