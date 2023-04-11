// #11 Functions -> Accept integer value from the main() and display its even number series from 1 to n.

#include <stdio.h>

void evenseries (int);
int main(){

    int n;
    printf("\nEnter any integer number = ");
    scanf("%d",&n);

    evenseries(n);

    return 0;

}
void evenseries (int n){
    int i;
    
    for(i=1; i<=n; i++){
        if(i%2==0)
            printf("%d\n",i);
    }
    
}
