/* String #56 - Copy string to another string  */
#include <stdio.h>

int main()
{
    int i;
    char str[20], str2[20];
    printf("Enter any string\n");
    scanf("%s",str);
    
    for(i=0;i<20;i++)
        str2[i]=str[i];
    
    printf("Copied String is %s",str2);    
    
    return 0;
}