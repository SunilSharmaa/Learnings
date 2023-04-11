/* Array #47 - Accept 10 int elements and accept anoher number then search the new number is present in array or not  */
#include <stdio.h>

int main()
{
    int num[10], n, i;
    printf("Enter any Five Integer = ");
    
    for(i=0;i<10;i++)
        scanf("%d",&num[i]);
    
    printf("Enter another number = ");
    scanf("%d",&n);
    
    for(i=0;i<10;i++)
        {
            if(n==num[i])
            break;
        }
    
    if(i!=10)
        printf("%d Found at index no. %d",n,i+1);
    
    else 
        printf("Not found");
    
    
    return 0;
}
