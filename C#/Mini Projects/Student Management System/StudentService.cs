using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Student_Management_System
{
    public class StudentService
    {

        //storage location for student model within student service class
        private List<StudentModel> studentData;

        public int count = 0;
        
        //creating a non parametrized constructor
        public StudentService()
        {
            //creating a list with the name of studentData to store the data
            studentData = new List<StudentModel>();
        }

        //methods of students
        public void StudentDetails()
        {
            StudentModel studentProperties = new StudentModel();
            Console.WriteLine("Enter following details:");
            Console.Write("Name : ");
            studentProperties.Name = Console.ReadLine();

            try
            {
                Console.Write("Age : ");
                studentProperties.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Exception! \nPlease enter valid integer number (greater then 0)");
                return;
            }

            try
            {
                Console.Write("Grade : ");
                studentProperties.Grade = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception! \nPlease enter valid character");
                return;
            }

            studentData.Add(studentProperties);
            Console.WriteLine("Student details added");
            count++;

        }

        //method for removing student
        public void RemoveDetails()
        {
            Console.Write("Enter student name: ");
            string tempName = Console.ReadLine();

            for (int i = 0; i < studentData.Count; i++)
            {
                if (studentData[i].Name == tempName)
                {
                    studentData.RemoveAt(i);
                    Console.WriteLine("Student removed");
                    count--;
                    return;
                }
            }

            Console.WriteLine("Student not found");
        }

        //method for updating student details
        public void UpdateDetails()
        {
            Console.WriteLine("Enter following details to update the record:");
            Console.Write("Enter student name: ");
            string tempName = Console.ReadLine();

            for (int i = 0; i < studentData.Count; i++)
            {
                if (studentData[i].Name == tempName)
                {
                    try
                    {
                        Console.Write("Name : ");
                        studentData[i].Name = Console.ReadLine();

                        Console.Write("Age : ");
                        int tempAge = Convert.ToInt32(Console.ReadLine());

                        if (tempAge == 0 || tempAge < 0)
                        {
                            throw new ArgumentException();
                        }
                        else
                        {
                            studentData[i].Age = tempAge;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Exception! \nEnter valid integer number ");
                        return;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Exception! \nAge cannot be 0 or less than 0");
                        return;
                    }

                    try
                    {
                        Console.Write("Grade : ");
                        studentData[i].Grade = Console.ReadLine();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Exception! \nPlease enter a valid character");
                        return;
                    }

                    Console.WriteLine("Records updated!");
                    return;
                }
            }

            Console.WriteLine("Student not found");
        }

        public void WritingDataToFiles()
        {
            //creating a path and combining the file
            string folderPath = @"\Records";
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "StudentRecords.json");

            //serializing the student data into json string cariable
            string jsonString = JsonSerializer.Serialize(studentData);
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine("Data written to file successfully.");
        }


        public void ReadingDataFromFiles()
        {
            try
            {
                // Define the folder path and file path
                string folderPath = @"\Records";
                string filePath = Path.Combine(folderPath, "StudentRecords.json");

                //checking if the file exist or not
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    studentData = JsonSerializer.Deserialize<List<StudentModel>>(jsonString);

                    Console.WriteLine("Data read from file successfully.");
                }
                else
                {
                    Console.WriteLine("Data file does not exist.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not Found.");
            }

            catch (JsonException)
            {
                Console.WriteLine("Error while reading Json data");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //method for displaying student details
        public void ShowDeatils()
        {
            for (int i = 0; i < studentData.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Name: {0}", studentData[i].Name);
                Console.WriteLine("Age: {0}", studentData[i].Age);
                Console.WriteLine("Grade: {0}", studentData[i].Grade);
            }
            
        }

    }
}
