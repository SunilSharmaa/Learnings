// Import necessary libraries
#include <stdio.h>
#include <string.h>
#include <windows.h>

// Define maximum number of students that can be stored
#define MAX_STUDENTS 100

// Define student structure
struct student {
    char name[50];
    int roll_number;
    float marks;
};

// Declare global variables
int num_students = 0;
struct student students[MAX_STUDENTS];

// Declare functions
void add_student(); 
void search_student();
void display_all_students();

// Main function
int main() {

    int choice; // Declare and initialize variables
    
    // Loop until user chooses to exit
    while (1) {
        // Display menu options
        printf("\nStudent Management System\n");
        printf("-------------------------\n");
        printf("1. Add Student\n");
        printf("2. Search Student\n");
        printf("3. Display All Students\n");
        printf("4. Exit\n");
        printf("Enter your choice (1-4): ");
        scanf("%d", &choice); // Take input for user's choice
        
        // Executing functions based on user's choice
        switch (choice) {
            case 1:
                add_student();
                break;
            case 2:
                search_student();
                break;
            case 3:
                display_all_students();
                break;
            case 4:
                printf("\nThankyou!!\n");
                return 0;
            default:
                printf("Invalid choice. Please try again.\n");
        }
    }
    
    return 0;
}

// Function to add a new student to the system
void add_student() {
    // Check if max limit for students has been reached
    if (num_students == MAX_STUDENTS) {
        printf("\nCannot add more students, max limit reached.\n");
        Sleep(3000); system("cls");
        return;
    }
    
    struct student new_student; // Take input for new student's details
    printf("\nEnter name: ");
    scanf(" %[^\n]s", new_student.name);  
    printf("Enter roll number: ");
    scanf("%d", &new_student.roll_number);
    printf("Enter marks: ");
    scanf("%f", &new_student.marks);
    
    
    students[num_students++] = new_student; // Add new student to the system and increment number of students
    
    printf("\nStudent added successfully.\n");
    Sleep(3000); system("cls");
}

// Function to search for a student based on their roll number
void search_student() {
    int roll_number;
    printf("Enter roll number: "); // Take input for roll number to search for
    scanf("%d", &roll_number);
    
    for (int i = 0; i < num_students; i++) {
        //Check if current student's roll number matches the one being searched for
        if (students[i].roll_number == roll_number) {
             // Display student's details
            printf("\nName: %s\n", students[i].name);
            printf("Roll Number: %d\n", students[i].roll_number);
            printf("Marks: %.2f\n", students[i].marks);
            Sleep(3000); system("cls");
            return;
        }
    }
    
    // Display error message if no student is found with the given roll number
    printf("\nStudent with roll number %d not found.\n", roll_number);
    Sleep(3000); system("cls");
}

// Function to display details of all students
void display_all_students() {
    // Check if there are any students
    if (num_students == 0) {
        printf("\nNo students to display.\n");
        Sleep(3000); system("cls");
        return;
    }
    
    printf("\nList of all students:\n");
    // Print the details of each student
    for (int i = 0; i < num_students; i++) {
        printf("\nName: %s\n", students[i].name);
        printf("Roll Number: %d\n", students[i].roll_number);
        printf("Marks: %.2f\n\n", students[i].marks);        
    }
    Sleep(10000); system("cls");
}