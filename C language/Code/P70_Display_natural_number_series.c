// #8 Functions -> Accept integer value from the main() and display natural no. series 1to n.

#include <stdio.h>

void series(int);
int main(){
    int n;
    printf("Enter any integer number = ");
    scanf("%d",&n);

    series(n);
    return 0;
}
void series(n){
    int i;
    for(i=1; i<=n;i++)
        printf("%d\n",i);

}