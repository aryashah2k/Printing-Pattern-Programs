/-- Another Logic using if-else --/
class Pattern_69
{

    public static void main(String args[])
    {
        int n = 5; //size

        for (int i = n; i >= 1; i--)
        {
            for (int j = n; j >= 1; j--)
            {
                if (i >= j)
                {
                    System.out.print("* ");  // space after '*'
                }
                else
                {
                    System.out.print(" ");
                }
            }
            System.out.println();
        }

    }
}
/--------------------------------/