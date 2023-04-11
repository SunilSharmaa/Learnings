/* Loops #40 - Display the odd number series from n to 1 (for loops) */
#include <stdio.h>

int main()
{
   
    int num;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    if(num%2==0)
        num=num-1;
    for(;num>=1;)    
        {
            printf("%d\n",num);
            num=num-2;
        }
    
    return 0;
}
