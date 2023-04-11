// #21 Structure -> Structure with array - Create a program of containing students roll no, name and percentage.

#include <stdio.h>  
#include <string.h>  

struct student                         //Declaration of Student datatype
{
    char name[25];
    int roll;
    float per; 
};

void input (struct student *);         //declaration of input function
void display (struct student *);      //declaration of display function

int main()  //main function
{
    struct student s[5];
    
    input(s);                     //input function call
    display(s);                      //display function call

    return 0;

}

void input (struct student *s)           //defination of input function
{
    int i;
    printf("\nEnter Students details\n");

    for(i=0; i<3; i++)
    {
        printf("\nStudent %d.\n",i+1);
        printf("Name = ");
        scanf("%[^\n]s",&s[i].name);
        printf("Roll no. = ");
        scanf("%d",&s[i].roll);
        printf("Percentage = ");
        scanf("%f",&s[i].per);
        fflush(stdin);
    }

    
}

void display (struct student *s)    //defination of display function
{
    int i;
    for(i=0; i<3; i++)
    {
        printf("\nStudent %d.\n",i+1);
        printf("Name = %s.  Roll no. = %d.  Percentage = %.2f\n\n",s[i].name, s[i].roll, s[i].per);
    }
}