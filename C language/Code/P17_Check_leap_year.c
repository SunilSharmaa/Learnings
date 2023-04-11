/* Conditional Statement #17 - Check the year is leap year or not (4digit year)*/
#include <stdio.h>

int main()
{
   
    int num;
    printf("Enter any Year = ");
    scanf("%d",&num);
    
    if(num%4==0)
        printf("Leap Year");
    
    else
        printf("Not a Leap year");
        
    
    return 0;
}
