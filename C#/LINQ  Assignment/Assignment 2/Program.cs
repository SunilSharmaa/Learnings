namespace Assignment_2
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();

            Console.Write("How many student you want to add: ");
            int size = 0;

            if(int.TryParse(Console.ReadLine(), out int temp))
            {
                size = temp;
                student.AddStudent(temp);
                student.GetStudentAbove18();

            }

            else
            {
                Console.WriteLine("Please enter valid integer number.");
            }
        }
    }
}