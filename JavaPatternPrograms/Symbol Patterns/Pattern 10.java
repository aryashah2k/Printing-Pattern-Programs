public class Pattern_64
{
    public static void main(String a[])
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
                System.out.print("* "); // space after '*'
            }
            System.out.print("\n");
        }

    }
}

/-- Another Logic using if-else --/

class Pattern_64
{

    public static void main(String args[])
    {
        int n = 5; //size

        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= 1; j--)
            {
                if (i >= j)
                {
                    System.out.print("* "); // space after '*'
                }
                else
                {
                    System.out.print(" ");
                }
            }
            System.out.println();
        }

    }

    /--------------------------------/