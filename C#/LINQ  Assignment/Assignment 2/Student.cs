using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Student
    {
        private List<StudentModel> studentList;
        public Student ()
        {
            studentList = new List<StudentModel> ();
        }

        public void AddStudent (int size)
        {
            for (int i = 0; i < size; i++)
            {
                StudentModel student = new StudentModel ();

                Console.WriteLine("----------\nEnter following details of student no. {0}", i + 1);
                Console.Write("Name: ");

                string tempName = Console.ReadLine();

                if(string.IsNullOrEmpty(tempName))
                {
                    Console.WriteLine("Input cannot be null or empty");
                    return;
                }

                else
                {
                    student.Name = tempName;
                }

                Console.Write("Age: ");

                if (int.TryParse(Console.ReadLine(), out int tempAge))
                {
                    student.Age = tempAge;
                }

                else
                {
                    Console.WriteLine("Please valid integer number");
                    return;
                }

                Console.Write("Grade: ");
                string tempGrade = Console.ReadLine();

                if (string.IsNullOrEmpty(tempGrade))
                {
                    Console.WriteLine("Input cannot be null or empty");
                    return;
                }

                else
                {
                    student.Grade = tempGrade;
                }

                studentList.Add(student);
            }
        }

        public void GetStudentAbove18 ()
        {
            //linq query to find all the student above 18 year old 
            var studentAbove18 = from i in studentList
                                 where i.Age > 18
                                 select i;

            Console.WriteLine("\nList of student above age 18");

            foreach (var student in studentAbove18)
            {
                Console.WriteLine("----------\nName: {0}, Age: {1}, Grade{2}", student.Name, student.Age, student.Grade);
            }
        }
    }
}
