 */
 
 // logic two (using if-else)
 for(i=n;i>0;i--)
 {
 
 //if(i%2!=0) { k=i+1; } else { k=i; }
 
 k=(i%2!=0)?i+1:i;  //use of conditional operator instead of 
   if-else
 
 for(j=0;j<k;j++)
 {
 System.out.print("*");
 }
 System.out.println();
 }
     } //end of main
 }  //end of class