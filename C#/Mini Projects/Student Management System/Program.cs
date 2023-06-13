using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Student_Management_System
{

    class Program
    {
        static int count = 0;
        
        public static void Main()
        {
            StudentService studentManagement = new StudentService();
            int input = 0;

            while (true)
            {
                Console.WriteLine("\n-----Student Management System-----");
                Console.WriteLine("1. Add student \n" +
                                  "2. Remove student \n" +
                                  "3. Update records \n" +
                                  "4. Show records \n" +
                                  "5. Write data to file \n" +
                                  "6. Reading data from file \n" +
                                  "7. Exit");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input > 7 || input < 1)
                    {
                        throw new ArgumentException();
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Exception! \nPlease enter valid integer number (1-7)");
                }

                catch (ArgumentException)
                {
                    Console.WriteLine("Exception! \nPlease enter valid input (1-7)");
                }

                switch (input)
                {
                    case 1:
                        studentManagement.StudentDetails();
                        break;
                    case 2:
                        studentManagement.RemoveDetails();
                        break;
                    case 3:
                        studentManagement.UpdateDetails();
                        break;
                    case 4:
                        studentManagement.ShowDeatils();
                        break;
                    case 5:
                        
                        studentManagement.WritingDataToFiles();
                        break;
                    case 6:
                        studentManagement.ReadingDataFromFiles();
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }
            }
        }
    }
}
