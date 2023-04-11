/* Basic #10 - Print how many note of 1000/-, 500/-, 200/-, 100/-, 50/-  are given by the atm Machine(using mod nd divide)*/
#include <stdio.h>

int main()
{
   
    int amount, r1000, r500, r200, r100, r50;
    printf("Enter any Amount = ");
    scanf("%d",&amount);
    
    r1000 = amount/1000;
    printf("Notes of 1000/- = %d\n",r1000);
    
    amount = amount%1000;
    r500 = amount/500;
    printf("Notes of 500/- = %d\n", r500);
    
    amount = amount%500;
    r200 = amount/200;
    printf("Notes of 200/- = %d\n",r200);
    
    amount = amount%200;
    r100 = amount/100;
    printf("Notes of 100/- = %d\n",r100);
    
    amount = amount%100;
    r50 = amount/50;
    printf("Notes of 50/- = %d\n",r50);
    

    return 0;
}
