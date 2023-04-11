/* Conditional Statement #14 - Check the number is odd or even (using if and else)*/
#include <stdio.h>

int main()
{
   
    int num;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    if(num%2==0)
        printf("Even number");
    
    else
        printf("Odd number");
        
    
    return 0;
}
