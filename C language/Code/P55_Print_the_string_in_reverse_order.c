/* String #55 - Print the String in Reverse order  */
#include <stdio.h>

int main()
{
    int i;
    char str[20];
    printf("Enter any string\n");
    scanf("%s",str);
    
    for(i=0;str[i]!='\0';i++);
    
    printf("Reversed string is\n");
    for(i=i-1;i>=0;i--)
    printf("%c",str[i]);
    
    return 0;
}
