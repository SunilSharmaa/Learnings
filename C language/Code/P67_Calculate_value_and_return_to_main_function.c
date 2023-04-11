// #5 Functions -> Take three int value from main() then calculate and return it to main()

#include <stdio.h>

float average(int,int,int); //declaration of average function
int main(){

    int num1, num2, num3;
    float avg;

    printf("\nEnter three int numbers = ");
    scanf("%d%d%d", &num1, &num2, &num3);

    avg = average(num1,num2,num3); //calling the function
    printf("Average = %.2f\n\n",avg);

    return 0;

}
float average(int a,int b,int c){  //function defination
    int d;
    float avg;
    d=a+b+c;
    avg=d/3.0;
    return(avg);

}
