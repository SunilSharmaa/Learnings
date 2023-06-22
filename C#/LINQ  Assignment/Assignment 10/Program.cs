namespace Assignment_10
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();

            Console.WriteLine("Enter the number of person you wan to add in List 1");
            
            if (int.TryParse(Console.ReadLine(), out int sizeList1) && sizeList1 > 0)
            {
                Console.WriteLine("\nEnter the number of person you wan to add in List 2");

                if (int.TryParse(Console.ReadLine(),out int sizeList2) && sizeList2 > 0)
                {
                    person.GetPersonDetails(sizeList1, sizeList2 );
                    person.GetCommonPerson();
                }

                else
                {
                    Console.WriteLine("Invalid input, Please enter valid integer number");
                    return;
                }
            }

            else
            {
                Console.WriteLine("Invalid input, Please enter valid integer number");
                return;
            }
        }
    }
}