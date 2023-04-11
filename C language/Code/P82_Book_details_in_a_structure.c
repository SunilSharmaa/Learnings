// #20 Structure -> Create a program of containing book details

#include <stdio.h>  
#include <string.h>  

struct book //declaration of book datatype
{
    int id;
    char title[30];
    float price;
};

struct book input (); //declaration of input function
void display (struct book);  //declaration of display function

int main()  //main function
{
    struct book b;

    b = input();
    display(b);

    return 0;
}

struct book input (struct book b)  //input function defination
{
    printf("\nEnter book details\n");
    printf("Book id = ");
    scanf("%d",&b.id);
    fflush(stdin);
    printf("Book Title = ");
    scanf("%[^\n]s",&b.title);
    printf("Price = ");
    scanf("%f",&b.price);

    return(b);
}

void display (struct book b)  //defination of display function
{
    printf("\nBook id = %d     Book Title = %s     Book Price = %.2f\n\n",b.id, b.title, b.price);
}