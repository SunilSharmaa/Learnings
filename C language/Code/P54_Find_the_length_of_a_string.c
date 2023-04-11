/* String #54 - Find the length of a String  */
#include <stdio.h>

int main()
{
    int i;
    char str[20];
    printf("Enter any string\n");
    scanf("%s",str);
    
    for(i=0;str[i]!='\0';i++);
    
    printf("length of the String is = %d",i);
    
    return 0;
}
