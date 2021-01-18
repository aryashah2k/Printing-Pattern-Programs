 import java.util.Scanner;
 
 public class BarChart2
 {
     public static void main(String args[])
     {
       int n; 
       int[] numArr = new int[20];
 
       int i;
       int j;
       
       Scanner sc=new Scanner (System.in);
 
       System.out.print("Enter total number of entities : ");
       n =sc.nextInt();
 
       for (i = 0;i < n;i++)
       {
         System.out.print("Enter value for entity ["+(i + 1)+"] : 
                    ");
         numArr[i] =sc.nextInt();
       }
 
       System.out.print("\n  BAR CHART \n\n");
 
       for (i = 0;i < n;i++)
       {
          System.out.print("["+(i + 1)+"]  ");
         for (j = 0;j < numArr[i];j++)
         {
          System.out.print("#");
         }
          System.out.print("\n\n");
       }
 
 
     }
 }