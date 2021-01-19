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

