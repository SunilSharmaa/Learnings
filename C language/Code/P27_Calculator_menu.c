/* Switch Statement #27 - Calculator menu */
#include <stdio.h>

int main()
{
   
   int num1, num2, x;
   printf("Enter any two integer number= ");
   scanf("%d%d",&num1, &num2);
   printf("1 for substract\n2 for add\n3 for multiply\n4 for divide\n 5 for mod\n");
   scanf("%d", &x);
   
   switch(x)
   {
       case 1:
                printf("%d",num1-num2);
                break;
       case 2:
                printf("%d",num1+num2);
                break;
        case 3:
                printf("%d",num1*num2);
                break;
        case 4:
                printf("%d",num1/num2);
                break;
        case 5:
                printf("%d",num1%num2);
                break;
        case 6:
                printf("Saturday");
                break;
        case 7:
                printf("Sunday");
                break;
       default:
            printf("Invalid Input");
   }
   
   
    
    return 0;
}
