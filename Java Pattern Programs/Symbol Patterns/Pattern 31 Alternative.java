*/
 
 // using if-else
 
 for(i=1;i<=6;i++)
 {
 /*if(i%2!=0)
 {
 k=i+1;
 }else
 {
 k=i;
 }*/
 
 k=(i%2!=0)?i+1:i;  //conditional operator
 
 for(int g=6;g>k;g--)
 {
 System.out.print(" ");
 }
 for(j=0;j<k;j++)
 {
 System.out.print("*");
 }
 System.out.println();
 }
     } //end of main
 }  //end of class