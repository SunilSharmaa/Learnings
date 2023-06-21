namespace Assignment_6
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();

            Console.Write("Enter how many Employees you want to add: ");
            int size = 0;

            if(int.TryParse(Console.ReadLine(), out size) && size > 0)
            {
                employee.GetEmployeeDetails(size);
                employee.ShowEmployeeHighestSalary();
            }

            else
            {
                Console.WriteLine("Invalid input, Please enter valid integer.");
            }
        }
    }
}