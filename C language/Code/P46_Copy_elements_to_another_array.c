/* Array #46 - Accept Five elements and copy them to another array and display it  */
#include <stdio.h>

int main()
{
    int num1[5], num2[5], i;
    printf("Enter any Five Integer = ");
    
    for(i=0;i<5;i++)
        scanf("%d",&num1[i]);
    
    for(i=0;i<5;i++)
            num2[i]=num1[i];
        
    for(i=0;i<5;i++)
            printf("Elements of array 2 at index %d is = %d\n",i+1,num2[i]);
    
    return 0;
}
