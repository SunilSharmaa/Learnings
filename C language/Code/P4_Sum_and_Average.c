/* Basic #4 - Sum and Average*/
#include <stdio.h>

int main()
{
   
    int num1, num2, num3, sum;
    float average;
    printf("Enter three Integer numbers\n");
    scanf("%d%d%d",&num1,&num2,&num3);
    sum = num1+num2+num3;
    average = sum/3.0;
    
    printf("The Sum of Three integer is = %d\n The Average of Three integer is = %f", sum,average);
    

    return 0;
}
