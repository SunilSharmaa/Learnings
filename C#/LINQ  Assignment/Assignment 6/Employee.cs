using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employee
    {
        private List<EmployeeProperties> EmployeeList;

        //constructor for creating list
        public Employee()
        {
            EmployeeList = new List<EmployeeProperties>();
        }

        public void GetEmployeeDetails (int size)
        {
            for (int i = 0; i < size; i++)
            {
                EmployeeProperties employeeProperties = new EmployeeProperties();

                Console.WriteLine("---------------\nEnter following details of employee no. {0}", i + 1);
                Console.Write("Name: ");
                string temp = Console.ReadLine();

                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Name cannot be empty or null.");
                    return;
                }
                else
                {
                    employeeProperties.Name = temp;
                }

                Console.Write("Department: ");
                temp = Console.ReadLine();

                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Department cannot be empty or null.");
                    return;
                }

                else
                {
                    employeeProperties.Department = temp;
                }

                Console.Write("Salary: ");
                decimal temp2;

                if(decimal.TryParse(Console.ReadLine(), out temp2) && temp2 > 0)
                {
                    employeeProperties.Salary = temp2;
                }

                else
                {
                    Console.WriteLine("Please enter valid input.");
                }

                EmployeeList.Add(employeeProperties);
            }
        }

        public void ShowEmployeeHighestSalary ()
        {
            //linq query for getting the employee with highest salary
            var highestSalary = (from i in EmployeeList
                                orderby i.Salary descending
                                select i).FirstOrDefault();

            Console.WriteLine("\nEmplyee with Highest salary is\n----------------\n");
                Console.WriteLine("Name: {0} \n" +
                              "Department: {1} \n" +
                              "Salary: {2}", 
                              highestSalary.Name, highestSalary.Department, highestSalary.Salary);
            
        }
    }
}
