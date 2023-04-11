/* Conditional Statement #20 - Check the Number is of how many digits (one digit, two digit... or more than four digit)*/
#include <stdio.h>

int main()
{
   
   int num;
   
   printf("Enter any Number = ");
   scanf("%d",&num);
   
   if(num>=0 && num<10)
        printf("One Digit");
    
    else if(num>=10 && num<100)
        printf("Two Digit");
        
    else if(num>=100 && num<1000)
        printf("Three Digit");
        
    else if(num>=1000 && num<10000)
        printf("Four Digit");    
    else
        printf("more han Four Digit");
    return 0;
}
