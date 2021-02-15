class Pattern_69
{
    public static void main(String a[])
    {
        int p_height = 5;

        for (int i = p_height; i >= 1; i--)
        {
            for (int k = p_height - 1; k >= i; k--)
            {
                System.out.print(" ");
            }
            for (int j = i; j >= 1; j--)
            {
                System.out.print("* "); // space after '*'
            }
            System.out.print("\n");
        }

    }
}

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