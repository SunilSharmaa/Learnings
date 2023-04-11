/* Basic #11 - Print 3 Digit integer line by line*/
#include <stdio.h>

int main()
{
   
    int num, temp;
    printf("Enter any three digit integer number = ");
    scanf("%d",&num);
    
    temp=num/100;
    printf("First digit = %d\n",temp);
    
    num=num%100;
    temp=num/10;
    printf("Second digit = %d\n",temp);
    
    num=num%10;
    printf("Third digit = %d",num);

    return 0;
}
