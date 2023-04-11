// #7 Functions -> Accept radius of circle from main() then calculate the area and print it in main().

#include <stdio.h>

float area(int);
int main(){

    int rad;
    float a;
    printf("\nEnter the radius of circle = ");
    scanf("%d",&rad);

    a= area(rad);
    printf("Area of circles is = %.2f\n\n",a);
    return 0;

}
float area(int rad){
    float area;
    area = (3.14*rad*rad);
    return (area);
}
