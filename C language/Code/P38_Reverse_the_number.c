/* Loops #38 - take a input from the user and reverse it (while loops) */
#include <stdio.h>

int main()
{
   
    int num, m,rev=0;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    while(num!=0)
    {
        m=num%10;
        rev=rev*10+m;
        num=num/10;
        
    }printf("After reversing the number =  %d",rev);
   
    
    return 0;
}
