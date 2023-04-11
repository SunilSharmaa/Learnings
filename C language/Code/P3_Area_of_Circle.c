/* Basic #3 - Area of Circle*/
#include <stdio.h>

int main()
{
    int radius;
    float area;
    printf("Enter the Radius of circle = ");
    scanf("%d",&radius);
    
    area= 3.14*radius*radius;
    printf("Area of Circle = %.2f",area);
    

    return 0;
}
