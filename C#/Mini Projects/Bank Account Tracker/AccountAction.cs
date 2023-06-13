using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Tracker
{
    class AccountAction<T1, T2, T3, T4>
    {
        //creating list of type AccountCredentials
        private List<AccountCredentials<T1, T2, T3, T4>> accountData;

        //random account number
        int tempAccountNumber = 123;
        //constructor to create list
        public AccountAction()
        {
            accountData = new List<AccountCredentials<T1, T2, T3, T4>>();
        }

        //for converting 
        private static T ConvertToType<T>(string value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public void AddAccount ()
        {
            AccountCredentials<T1, T2, T3, T4> accountCredentials = new AccountCredentials<T1, T2, T3, T4>();
            //Will take user name here
            Console.WriteLine("\n----------------------\nEnter following details");
            Console.Write("Name: ");
            accountCredentials.Name = ConvertToType<T1>(Console.ReadLine());

            //will ask for user type
            Console.Write("Account type (1.Saving / 2.Current): ");
            if(int.TryParse(Console.ReadLine(), out int temp) && temp > 0 && temp < 3)
            {
                if (temp == 1)
                {
                    accountCredentials.AccountType = ConvertToType<T2>("Saving Account");
                }

                else
                {
                    accountCredentials.AccountType = ConvertToType<T2>("Current Account");
                }
            }

            else
            {
                Console.WriteLine("Invalid input please enter (1 or 2)");
            }

            //will ask for initial amount to deposit
            while (true)
            {
                Console.Write("Initial Amount: ");
                if (int.TryParse(Console.ReadLine(), out temp) && temp > 0 && temp < 100000)
                {
                    accountCredentials.Balance = ConvertToType<T3>(temp.ToString());
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter valid amount to deposit");
                }
            }
                accountCredentials.AccountNumber = ConvertToType<T4>(tempAccountNumber.ToString());
                tempAccountNumber++;

                accountData.Add(accountCredentials);
                Console.WriteLine("-----Account created-----");
                Console.WriteLine("your account number is : {0}", accountCredentials.AccountNumber);
                return;
            

        }

        public void DepositAmount ()
        {
            Console.Write("\n----------------------\nEnter your account number: ");
            if (ConvertToType<T4>(Console.ReadLine()) is T4 tempAccountNumber)
            {
                for (int i = 0; i < accountData.Count; i++)
                {
                    if (accountData[i].AccountNumber.Equals(tempAccountNumber))
                    {
                        Console.Write("Amount to deposit: ");
                        if (ConvertToType<T3>(Console.ReadLine()) is T3 depositAmount)
                        {
                            // Perform deposit operation
                            accountData[i].Balance = ConvertToType<T3>((Convert.ToDecimal(accountData[i].Balance) + Convert.ToDecimal(depositAmount)).ToString());
                            Console.WriteLine("Deposit successful. New balance: {0}", accountData[i].Balance);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for deposit amount!");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Account not found!");
        }

        public void WithdrawAmount ()
        {
            Console.Write("\n----------------------\nEnter your account number: ");
            if (ConvertToType<T4>(Console.ReadLine()) is T4 tempAccountNumber)
            {
                for (int i = 0; i < accountData.Count; i++)
                {
                    if (accountData[i].AccountNumber.Equals(tempAccountNumber))
                    {
                        Console.Write("Amount to withdraw: ");
                        if (ConvertToType<T3>(Console.ReadLine()) is T3 withdrawalAmount)
                        {
                            // Perform withdrawal operation
                            if (Convert.ToDecimal(accountData[i].Balance) >= Convert.ToDecimal(withdrawalAmount))
                            {
                                accountData[i].Balance = ConvertToType<T3>((Convert.ToDecimal(accountData[i].Balance) - Convert.ToDecimal(withdrawalAmount)).ToString());
                                Console.WriteLine("Withdrawal successful. New balance: {0}", accountData[i].Balance);
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for withdrawal amount!");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Account not found!");
        }

        //method for diplaying records
        public void DisplayRecords()
        {
            Console.Write("\n----------------------\nEnter your account number: ");
            if (ConvertToType<T4>(Console.ReadLine()) is T4 tempAccountNumber)
            {
                foreach (var account in accountData)
                {
                    if (account.AccountNumber.Equals(tempAccountNumber))
                    {
                        Console.WriteLine("\n----------------------\nAccount Records:");
                        Console.WriteLine("Account Number: {0}", account.AccountNumber);
                        Console.WriteLine("Name: {0}", account.Name);
                        Console.WriteLine("Account Type: {0}", account.AccountType);
                        Console.WriteLine("Balance: {0}", account.Balance);
                        Console.WriteLine("-------------------");
                        return;
                    }
                }
            }
            Console.WriteLine("Account not found!");
        }

        //method for storing data into files
        public void WriteDataToFile ()
        {
            //creating directory and file
            string folderPath = @"\BankRecords";
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "AccountsRecords.json");

            try
            {
                string jsonString = JsonSerializer.Serialize(accountData);
                File.WriteAllText(filePath, jsonString);

                Console.WriteLine("Data written to file");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        //method for reading data from file
        public void ReadDataFromFile ()
        {
            // Define the folder path and file path
            string folderPath = @"\BankRecords";
            string filePath = Path.Combine(folderPath, "AccountsRecords.json");

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                accountData = JsonSerializer.Deserialize < List<AccountCredentials<T1,T2,T3,T4>>>(jsonString);

                Console.WriteLine("Data read from file successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }


    }


}
