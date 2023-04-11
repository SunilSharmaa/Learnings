/* Array #48 - Accept 5 int elements and copy them to another array in reverse order.  */
#include <stdio.h>

int main()
{
    int num1[5], num2[5], i,j;
    printf("Enter any Five Integer = ");
    
    for(i=0;i<5;i++)
        scanf("%d",&num1[i]);
    
    for(i=0,j=4;i<5;i++,j--)
        num2[j]=num1[i];
        
    for(i=0;i<5;i++)
    printf("Array 2 elemnts in index %d is %d\n",i+1,num2[i]);
    
    
    
    return 0;
}
