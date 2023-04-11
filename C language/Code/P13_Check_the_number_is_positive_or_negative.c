/* Conditional Statement #13 - Check the number is positive,negative or zero (only if)*/
#include <stdio.h>

int main()
{
   
    int num;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    if(num>0)
        printf("Positive number");
    
    if(num<0)
        printf("Negative number");
        
    if(num==0)    
        printf("number is Zero");
    return 0;
}
