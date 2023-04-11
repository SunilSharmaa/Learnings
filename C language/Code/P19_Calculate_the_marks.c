/* Conditional Statement #19 - Calculate the total marks ,Percentage and division (75> "Excelent.... 40>fail....")*/
#include <stdio.h>

int main()
{
   
   int p, c, m, total;
   float per;
   printf("Enter the marks of Physics, Chemistry and Maths = ");
   scanf("%d%d%d",&p, &c, &m);
   
   total = p+c+m;
   per = (float)total/3.0;
   
   printf("Total Marks = %d \nTotal Percentage = %f\n",total,per);
   
   if(per>=75)
        printf("Excelent");
    
    else if(per>=60)
        printf("1st Division");
    
    else if(per>=50)
        printf("2nd Division");
    
    else if(per>=40)
        printf("3rd Division");
    
    else
        printf("Fail");
   
    
    return 0;
}
