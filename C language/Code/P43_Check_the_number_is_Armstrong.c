/* Loops #43 - Check the number is Armstrong or not.  */
#include <stdio.h>

int main()
{
   
    int num,arm=0, temp, i;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    for(i=num;num!=0;)    
        {
            temp = num%10;
            arm = arm+(temp*temp*temp);
            num = num/10; 
        }    
            
    if(i==arm)
        printf("Number is Armstrong");
    
    else
        printf("Not  Armstrong");
    
    return 0;
}
