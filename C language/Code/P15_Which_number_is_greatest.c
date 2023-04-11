/* Conditional Statement #15 - Which number is greatest (only two numbers)*/
#include <stdio.h>

int main()
{
   
    int num1, num2;
    printf("Enter any two number = ");
    scanf("%d%d",&num1,&num2);
    
    if(num1>num2)
        printf("%d is Greatest",num1);
    
    else
        printf("%d is Greatest",num2);
        
    
    return 0;
}
