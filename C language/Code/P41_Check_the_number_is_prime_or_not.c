/* Loops #41 - Check the number is prime or not.  */
#include <stdio.h>

int main()
{
   
    int num, i,count=0;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    for(i=1;i<=num;i++)    
            if(num%i==0)
                count++;
    
    if(count==2)
        printf("Prime number");
    
    else
        printf("Not a prime");
    
    return 0;
}
