/* Switch Statement #28 - odd even number (using conditional operater) */
#include <stdio.h>

int main()
{
   
    int num;
    printf("enter any number = ");
    scanf("%d",&num);

    (num%2==0) ? printf("Even") : printf("odd");
   
    
    return 0;
}
