namespace Classes_And_Function_3
{
    class BankAccount
    {
        //declaring properties
        private int accountNumber = 0;
        private int balance = 0;

        //defining method to create an account
        public void CreateAccount ()
        {
            Console.Write("Enter account no : ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Initial amount : ");
            balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Account Created!");
        }

        //defining method to deposit money
        public void DepositMoney ()
        {
            Console.Write("Deposit amount : ");
            balance = balance + (Convert.ToInt32(System.Console.ReadLine()));
            System.Console.WriteLine("Your new balance is : {0}", balance);
        }

        //defing method to withdraw money
        public void WithdrawMoney ()
        {
            Console.Write("Withdraw amount : ");
            int tempAmount = Convert.ToInt32(System.Console.ReadLine());

            if (tempAmount > balance)
            {
                Console.WriteLine("Insufficient Amount");
            }
            else
            {
                balance = balance - tempAmount;
                Console.WriteLine("Your new balance is : {0}", balance);
            }
        }
        static void Main()
        {
            BankAccount user = new BankAccount();
            
            //created while loop to give option to user
            while (true)
            {
                Console.WriteLine("\nHello, user! Select any option");
                Console.WriteLine("1. Create an account \n2. Deposit \n3. Withdraw \n4. Exit");
                int input = Convert.ToInt32(System.Console.ReadLine());

                if (input == 1)
                {
                    user.CreateAccount();
                }

                else if (input == 2)
                {
                    user.DepositMoney();
                }

                else if (input == 3)
                {
                    user.WithdrawMoney();
                }

                else if (input == 4)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            
        }
    }
}