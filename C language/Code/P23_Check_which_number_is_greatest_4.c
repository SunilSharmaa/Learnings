/* Nested if Statements #23 - Check which number is greatest (4 unique integer) */
#include <stdio.h>

int main()
{
   
   int num1, num2, num3, num4;
   
   printf("Enter Three Unique Integer numbers = ");
   scanf("%d%d%d%d",&num1, &num2, &num3, &num4);
   
   if(num1>num2 && num1>num3)
        {
            if(num1>num4)
                printf("%d is Greatest",num1);
            
            else
                printf("%d is Greatest",num4);
        }
    else if(num2>num3)
            {
                if(num2>num4)
                    printf("%d is Greatest",num2);
                
                else
                    printf("%d is greatest",num4);
            }
    else if(num3>num4)
            printf("%d is Greatest",num3);
            
        else
            printf("%d is Greatest",num4);
    
    return 0;
}
