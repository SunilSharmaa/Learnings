namespace Tast_Tracker
{
    public class Program
    {
        static void Main()
        {
            //created object of Task class
            Task taskManager = new Task();

            //created menu for user to select option
            while (true)
            {
                Console.WriteLine("\n---Task Tracker---");
                Console.WriteLine("1. New Task \n" +
                                  "2. Mark Task as completed \n" +
                                  "3. Display pending Task \n" +
                                  "4. Write data to file \n" +
                                  "5. Read data from file \n" +
                                  "6. Exit");
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            taskManager.AddingTask();
                            break;
                        case 2:
                            taskManager.MarkTaskCompleted();
                            break;
                        case 3:
                            taskManager.DisplayPendingTask();
                            break;
                        case 4:
                            taskManager.WritingDataToFiles();
                            break; ;
                        case 5:
                            taskManager.ReadDataFromFiles();
                            break;
                        case 6:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter integer number only(1-4");
                }
            }
            

        }
    }
}