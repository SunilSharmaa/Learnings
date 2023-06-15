namespace Implementing_Inheritance
{
    internal class Program
    {
        static void Main()
        {
            while (true) 
            { 
                Console.WriteLine("Select any of these");
                Console.WriteLine("1. Dog \n2. Cat \n3. Bird \n4. Exit");
                int choice = 0;
            
                if (int.TryParse(Console.ReadLine(), out choice)) 
                {
                }

                else
                {
                    Console.WriteLine("Enter valid integer number");
                }

                switch (choice)
                {
                    case 1:
                        Dog dog = new Dog();
                        dog.GetDogDetails();
                        dog.AnimalSound();
                        break;
                    case 2:
                        Cat cat = new Cat();
                        cat.GetCatDetails();
                        cat.AnimalSound();
                        break;
                    case 3:
                        Bird bird = new Bird();
                        bird.GetBirdDetails();
                        bird.AnimalSound();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
                
            }
        }
    }
}