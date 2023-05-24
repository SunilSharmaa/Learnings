namespace Assessment_1
{
    
    class TakingInput
    {
        static void Main()
        {
            //declaring variables
            string name;
            int age;

            //asking for user name and age
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            //display the input with greetings
            Console.WriteLine("Hello! Welcome to the programm.");
            Console.WriteLine("Your name is {0} and you are {1} year old ", name, age);
            Console.WriteLine("See you Again, bye!");

        }
    }

    

}