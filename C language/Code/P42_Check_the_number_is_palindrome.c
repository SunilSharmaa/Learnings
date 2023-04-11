/* Loops #42 - Check the number is palindrome or not.  */
#include <stdio.h>

int main()
{
   
    int num,rev=0, temp, i;
    printf("Enter any number = ");
    scanf("%d",&num);
    
    for(i=num;num!=0;)    
        {
            temp = num%10;
            rev = rev*10+temp;
            num = num/10; 
        }    
            
    if(i==rev)
        printf("Palindrome");
    
    else
        printf("Not a Palindrome");
    
    return 0;
}
