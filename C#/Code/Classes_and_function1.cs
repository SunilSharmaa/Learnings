namespace CLasses_And_Function_1
{
    class Person
    {
        //declaring propeerties
        private string name = "";
        private int age = 0;
        private string address = "";

        //defining methods
        public void GetDetails ()
        {
            //geting details from the user
            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your address : ");
            address = Console.ReadLine();
        }

        public void ShowDetails ()
        {
            //displaying the details of the user
            Console.WriteLine("\n\nYour name is {0} ", name);
            Console.WriteLine("You are {0} year old", age);
            Console.WriteLine("Your address is {0}", address);
        }
        static void Main()
        {
            Console.WriteLine("Hello user, please enter following details: ");

            Person user = new Person();
            user.GetDetails();
            user.ShowDetails();
        }
    }
}