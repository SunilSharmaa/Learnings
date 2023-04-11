/* Conditional Statement #16 - Check the number is divisible by 5 or not (integer)*/
#include <stdio.h>

int main()
{
   
    int num;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    if(num%5==0)
        printf("Divisible by 5");
    
    else
        printf("Not Divisible by 5");
        
    
    return 0;
}
