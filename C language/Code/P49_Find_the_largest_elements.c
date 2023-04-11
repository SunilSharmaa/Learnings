/* Array #49 - Accecpt 10 int element and find out the largest one (without changing the elements positions).  */
#include <stdio.h>

int main()
{
    int num1[10], temp, i,j;
    printf("Enter any ten Integer = ");
    
    for(i=0;i<10;i++)
        scanf("%d",&num1[i]);
    
    temp=num1[0];
    for(i=0;i<10;i++)
        {
            if(num1[i]>temp)
              temp=num1[i];
        }
        
    printf("%d is Largest number ",temp);
    
    
    
    return 0;
}
