/*-- Another Logic using if-else */
class Pattern_47
{
    public static void main(String args[])
    {
        int n = 4; // size

        int px = 1; // print controls
        int py = n * 2 - 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < n * 2; j++)
            {
                if (j >= px && j <= py)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print(" ");
                }
            }
            px++;
            py--;

            System.out.println();
        }


    }
}

/--------------------------------/