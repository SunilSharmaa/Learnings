/* Nested if Statements #22 - Check which number is greatest (3 unique integer) */
#include <stdio.h>

int main()
{
   
   int num1, num2, num3;
   
   printf("Enter Three Unique Integer numbers = ");
   scanf("%d%d%d",&num1, &num2, &num3);
   
   if(num1>num2)
        {
            if(num1>num3)
                printf("%d is Greatest",num1);
            
            else
                printf("%d is Greatest",num3);
        }
    else if(num2>num3)
            printf("%d is Greatest",num2);
            
        else
            printf("%d is Greatest",num3);
    
    return 0;
}
