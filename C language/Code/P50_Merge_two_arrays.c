/* Array #50 - Take two array of five elements and merge them to third  */
#include <stdio.h>

int main()
{
    int arr1[5], arr2[5], arr3[10], i, j;
    
    printf("Enter 1st Array elements = ");
    for(i=0;i<5;i++)
        scanf("%d",&arr1[i]);
    
    printf("Enter 2nd Array elements = ");
    for(i=0;i<5;i++)
        scanf("%d",&arr2[i]);
    
    for(i=0;i<5;i++)
        arr3[i]=arr1[i];
    
    for(i=0,j=5;i<5;i++,j++)
        arr3[j]=arr2[i];
        
    printf("3rd Array elements:-\n");
    for(i=0;i<10;i++)
        printf("at index %d is %d\n",i+1,arr3[i]);
    
    
    
    
    
    return 0;
}
