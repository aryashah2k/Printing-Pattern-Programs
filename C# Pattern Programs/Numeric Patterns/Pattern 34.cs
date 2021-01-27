using System;

   class Pattern_78
 {
    public static void Main(string[] args)
    {
        int size = 4;
        int p = 1; // print value

        for (int i = size; i >= -size; i--)
        {
            for (int j = 1; j <= Math.Abs(i); j++)
            {
                Console.Write(" ");
            }

            p = 1;
            for (int k = size; k >= Math.Abs(i); k--)
            {
                Console.Write(p + " ");
                p++;
            }

            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
   
}
