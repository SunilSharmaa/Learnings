/* Basic #6 - Area of Triangle*/
#include <stdio.h>

int main()
{
   
    int base, height;
    float area;
    printf("Enter Base and Height of a triangle\n");
    scanf("%d%d", &base, &height);
    area= (float)base*height/2;
    printf("Area of Triangle is = %f",area);

    return 0;
}
