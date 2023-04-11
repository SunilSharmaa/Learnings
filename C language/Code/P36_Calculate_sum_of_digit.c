/* Loops #36 - take a input from the user calculate the the sum of digit (while loops) */
#include <stdio.h>

int main()
{
   
    int num, m,sum=0;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    while(num!=0)
    {
        m=num%10;
        sum=sum+m;
        num=num/10;
        
    }printf("sum of Digit =  %d",sum);
   
    
    return 0;
}
