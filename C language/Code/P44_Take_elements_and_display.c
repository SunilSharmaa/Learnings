/* Array #44 - Accept Five elements and diplay it line by line  */
#include <stdio.h>

int main()
{
    int num[5], i;
    printf("Enter any Five Integer = ");
    
    for(i=0;i<5;i++)
        scanf("%d",&num[i]);
    
    for(i=0;i<5;i++)
        printf("%d\n",num[i]);
    
    return 0;
}
