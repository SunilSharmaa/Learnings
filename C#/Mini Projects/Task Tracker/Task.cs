using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tast_Tracker
{
    class Task
    {
        //storage location for Task properties within Task class
        private List<TaskProperties> tasks;

        //will create a non parametrized constructor
        public Task()
        {
            //will create a list of TaskProperty class and assigned it to task variable
            tasks = new List<TaskProperties>();
        }

        //method for adding task
        public void AddingTask ()
        {
            //created object of Taskpropertis class 
            TaskProperties properties = new TaskProperties();

            Console.Write("Title: ");
            properties.Title = Console.ReadLine();

            Console.Write("Description: ");
            properties.Description = Console.ReadLine();

            Console.Write("Due date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                properties.DueDate = dueDate;
            }

            else
            {
                Console.WriteLine("Invalid date format. Task not added.");
                return;
            }

            properties.IsCompleted = false;

            tasks.Add(properties);
            Console.WriteLine("Task added successfully.");
        }

        //method for marking task is completed
        public void MarkTaskCompleted ()
        {
            Console.Write("Enter the index of task to mark completed: ");

            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
                Console.WriteLine("Task marked as completed.");
            }

            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        //method for displaying pending task
        public void DisplayPendingTask ()
        {
            Console.WriteLine("List of pending task:");

            for (int i = 0; i < tasks.Count; i++)
            {
                if (!tasks[i].IsCompleted)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Index {0} \n" +
                                      "Title: {1} \n" +
                                      "Due date: {2} \n" +
                                      "Description: {3}"
                                      ,i, tasks[i].Title, tasks[i].DueDate, tasks[i].Description);
                }
            }
        }

        public void WritingDataToFiles()
        {
            //creatiing directory and file
            string folderPath = @"\TaskRecords";
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "TaskRecords.json");

            try
            {
                string jsonString = JsonSerializer.Serialize(tasks);
                File.WriteAllText(filePath, jsonString);

                Console.WriteLine("Data written to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadDataFromFiles()
        {
            // Define the folder path and file path
            string folderPath = @"\TaskRecords";
            string filePath = Path.Combine(folderPath, "TaskRecords.json");

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                tasks = JsonSerializer.Deserialize<List<TaskProperties>>(jsonString);

                Console.WriteLine("Data read from file successfully");

            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
