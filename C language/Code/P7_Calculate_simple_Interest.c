/* Basic #7 - Calculate Simple Interest*/
#include <stdio.h>

int main()
{
   
    float Principle, Rate, Time;
    printf("Enter Principle, Rate and Time\n");
    scanf("%f%f%f", &Principle, &Rate, &Time);
    
    printf("Simple Interest  = %f",Principle*Rate*Time);

    return 0;
}
