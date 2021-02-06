using System;

class Pattern_134
{
    public static void Main(string[] args)
    {
        int firstNum = 0, secondNum = 1, result = 0;
        int n = 5; //size ,increase it to create series

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                firstNum = secondNum;
                secondNum = result;
                Console.Write(result + " ");
                result = firstNum + secondNum;
            }
            firstNum = 0;
            secondNum = 1;
            result = 0;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
