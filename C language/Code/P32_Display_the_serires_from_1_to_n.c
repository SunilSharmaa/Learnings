/* Loops #32 - display the seies from 1 to n (while loops) */
#include <stdio.h>

int main()
{
   
    int num, i=1;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    while(i<=num)
    {
        printf("%d\n",i);
        i++;
    }
   
    
    return 0;
}
