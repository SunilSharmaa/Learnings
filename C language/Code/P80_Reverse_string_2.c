// #18 Pointers -> using string , pointer and functions (length and reverse string). 

#include <stdio.h>

void input (char*);
int len (char*);
void rvstring (char*);

int main(){
    char str[20];
    int l;
    input(str);
    l = len(str);
    printf("%d\n",l);
    rvstring(str);
    printf("Reverse String is = %s",str);
    
    printf("\n");

    return 0;

}

void input (char *p){
    printf("\nEnter any String = ");
    scanf("%s",p);
}

int len (char *l){
    int i;
    for(i=0; *(l+i)!='\0'; i++);
    return (i);
}

void rvstring (char *p){
    int l, i; 
    char temp;
    for(l=0;*(p+l)!='\0'; l++);
    for(i=0; i<l/2; i++){
        temp = *(p+i);
        *(p+i) = *(p+l-i-1);
        *(p+l-i-1) = temp;
    }

    
    
}