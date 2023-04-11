/* Basic #9 - Swap two Integer*/
#include <stdio.h>

int main()
{
   
    int num1, num2, temp;
    printf("Enter any two  Integer number\n");
    scanf("%d%d", &num1, &num2);
    
    printf("Entered integer is :- 1st= %d and 2nd= %d\n",num1,num2);
    
    temp=num1;
    num1=num2;
    num2=temp;
    printf("After Swaping integer :- 1st= %d and 2nd= %d",num1,num2);

    return 0;
}
