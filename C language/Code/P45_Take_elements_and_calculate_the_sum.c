/* Array #45 - Accept Five elements and calculate the sum of all and display  */
#include <stdio.h>

int main()
{
    int num[5], i, sum=0;
    printf("Enter any Five Integer = ");
    
    for(i=0;i<5;i++)
        scanf("%d",&num[i]);
    
    for(i=0;i<5;i++)
        {
            sum=sum+num[i];
        }
    printf("sum of all the number is %d",sum);
    return 0;
}
