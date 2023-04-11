/* Conditional Statement #12 - Check odd or even (only if)*/
#include <stdio.h>

int main()
{
   
    int num;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    if(num%2==0)
        printf("Even number");
    
    if(num%2!=0)
        printf("Odd number");

    return 0;
}
