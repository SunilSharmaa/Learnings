/* Loops #33 - display the sum of seies from 1 to 10 (while loops) */
#include <stdio.h>

int main()
{
   
    int sum=0, i=1;
    
    while(i<=10)
    {
        sum=sum+i;
        i++;
    }printf("sum of series = %d",sum);
   
    
    return 0;
}
