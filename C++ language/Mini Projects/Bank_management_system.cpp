#include <iostream>
#include <string>
#include <windows.h>

using namespace std;

int count = 0; // global variable to keep track of number of accounts created

class BankAccount {
    char name[20];
    int age;
    char phone_no[20];
    float balance;
    int pin;
    int ac_no;

public:
    
    void Account_open(); // function to open a new bank account
    void Deposit_amount(BankAccount user[]); // function to deposit money into an existing account
    void Withdraw_amount(BankAccount user[]); // function to withdraw money from an existing account
    void Account_details(BankAccount user[]); // function to display account details
    int Checkuser(BankAccount user[]); // function to check users credentials are correct or not
};

// inline function to delay the program execution by 3 seconds and clear the console
inline void Delay() {
    Sleep(3000);
    system("cls");
}

void BankAccount::Account_open() {
    cout << "Enter details:\n";
    cout << "Name: ";
    cin.ignore();
    cin.getline(name, 20);
    cout << "Age: "; 
    cin >> age;
    cout << "phone no. ";
    cin.ignore();
    cin.getline(phone_no, 20);
    // loop to get a valid 4 digit pin
    while (1) {
        cout << "create 4 digit pin: ";
        cin >> pin;
        cout << "confirm pin: ";
        int temp_pin;
        cin >> temp_pin;
        if (temp_pin == pin) {
            // assign an account number to the new account
            cout << "your account number is: " << 1234 + count;
            ac_no= 1234 + count;
            count++;
            cout << "\nAccount Created Successfully\n";
            Delay();
            break;
        } else {
            cout << "wrong pin! enter again\n";
        }
    }
}

void BankAccount::Deposit_amount(BankAccount user[]) {
    int check;
    check = user[count].Checkuser(user);
    if (check != 101) {
        float amount;
        cout << "Enter the amount to deposit: ";
        cin >> amount;
        user[check].balance += amount;
        cout << "Amount deposited successfully.\n";
        cout << "Your new balance is: " << user[check].balance << endl;
        Delay();
        return;
    } else {
        cout << "Invalid Credential. Please check your a/c details and try again.\n";
        Delay();
    }
}

void BankAccount::Withdraw_amount(BankAccount user[]) {
    int check;
    check = user[count].Checkuser(user);
    if (check != 101) {
        float amount;
        cout << "Enter the amount to Withdraw: ";
        cin >> amount;
        if (amount <= user[check].balance) {
            user[check].balance -= amount;
            cout << "Amount withdraw successfully.\n";
            cout << "Your new balance is: " << user[check].balance << endl;
            Delay();
            return;
        } else {
            cout << "insufficient fund!";
            Delay();
            return;          
        }
    } else {
        cout << "Invalid Credential. Please check your a/c details and try again.\n";
        Delay();
    }
}

void BankAccount::Account_details(BankAccount user[]) {
    // Check if the user is valid
    int check;
    check = user[count].Checkuser(user);
    if (check != 101) {
        // If the user is valid, display the account details
        cout << "Name: " << user[check].name << endl;
        cout << "Age: " << user[check].age << endl;
        cout << "Phone number: " << user[check].phone_no << endl;
        cout << "Account number: " << user[check].ac_no << endl;
        cout << "Current balance: " << user[check].balance << endl;
        cout << "Thank you!" << endl;
        Delay();
        return;         
    } else {
        // If the user is invalid, display an error message
        cout << "Invalid Credential. Please check your account details and try again.\n";
        Delay();
    }
}

// Checkuser function checks if the given account number and PIN are valid
int BankAccount::Checkuser(BankAccount user[]) {
    int temp_ac_no, temp_pin, attempt;
    cout << "Enter your account number: ";
    cin >> temp_ac_no;
    // Loop through all existing users to find the given account number
    for (int i = 0; i < count; i++) {
        if (temp_ac_no == user[i].ac_no) {
            // If the account number is found, ask the user for the PIN
            for (attempt = 3; attempt >= 1; attempt--) {
                cout << "Enter your PIN: ";
                cin >> temp_pin;
                if (temp_pin == user[i].pin) {
                    // If the PIN is correct, return the index of the user
                    return i;
                } else {
                    cout << "Incorrect PIN, " << attempt - 1 << " attempts left.\n";
                }
            }
            // If the PIN is incorrect three times, display an error message and return 101 (invalid user)
            cout << "Incorrect PIN attempts exceeded.\n";
            Delay();
            return 101;
        }
    }
    // If the account number is not found, display an error message and return 101 (invalid user)
    cout << "Invalid account number!\n";
    Delay();
    return 101;
}

// Main function 
int main() {
    int choice;
    BankAccount user[100];

    // Loop to display menu and execute user's choice
    while (true) {
        // Display menu
        cout << "\n! Welcome to Bank Management System!\n\n";
        cout << "1. Account Open \n2. Deposit Amount \n3. Withdrawal Amount \n4. Account Details \n5. Exit\n";
        cout << "Enter your choice (1-5): ";
        cin >> choice;

        // Switch statement to execute user's choice
        switch (choice) {
        case 1:
            user[count].Account_open();
            break;
        case 2:
            user[count].Deposit_amount(user);
            break;
        case 3:
            user[count].Withdraw_amount(user);
            break;
        case 4:
            user[count].Account_details(user);
            break;
        case 5:
            cout << "Thank you!\n";
            return 0;
        default:
            cout << "Invalid input!\n";
            Delay();
        }
    }
    return 0;
}