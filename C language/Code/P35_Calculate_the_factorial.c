/* Loops #35 - take a input from the user calculate the factorial (while loops) */
#include <stdio.h>

int main()
{
   
    int num, f=1;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    while(num>1)
    {
        f=f*num;
        num--;
    }printf("Factorial is %d",f);
   
    
    return 0;
}
