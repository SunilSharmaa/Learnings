using System;
namespace Bank_Account_Tracker
{
    class Program
    {
        static void Main()
        {
            AccountAction<string, string, decimal, int> accountAction = new AccountAction<string, string, decimal, int>();
            //storing data into files
            string filePath = @"D:/programming/c# learning/Bank Account Tracker/AccountDetails.json";

            while (true)
            {
                Console.WriteLine("Choose an action:\n" +
                                  "1. Add Account \n" +
                                  "2. Deposit Amount \n" +
                                  "3. Withdraw Amount \n" +
                                  "4. Display Records \n" +
                                  "5. Write data to file \n" +
                                  "6. Read data from file \n" +
                                  "7. Exit");

                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            accountAction.AddAccount();
                            break;
                        case 2:
                            accountAction.DepositAmount();
                            break;
                        case 3:
                            accountAction.WithdrawAmount();
                            break;
                        case 4:
                            accountAction.DisplayRecords();
                            break;
                        case 5:
                            accountAction.WriteDataToFile(filePath);
                            break;
                        case 6:
                            accountAction.ReadDataFromFile(filePath);
                            break;
                        case 7:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter (1-5) only.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
            }
        }
    }
}