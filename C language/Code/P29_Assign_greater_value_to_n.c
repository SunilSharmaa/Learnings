/* Switch Statement #29 - assign greater value to c (using conditional operater) */
#include <stdio.h>

int main()
{
   
    int a, b, c;
    printf("enter any two  number = ");
    scanf("%d%d",&a, &b);

    (a>b) ? (c=a) : (c=b) ;
    
    printf("%d",c);
   
    
    return 0;
}
