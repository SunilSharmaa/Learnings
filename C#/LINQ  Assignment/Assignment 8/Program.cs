namespace Assignment_8
{
    class Program
    {
        static void Main()
        {
            Book book = new Book();

            Console.Write("How many book do you want to add: ");

            if(int.TryParse(Console.ReadLine(), out int size) && size > 0) 
            { 
                book.GetBookDetails(size);
                book.ShowBooksBefore2000();
            }

            else
            {
                Console.WriteLine("Please enter valid integer number.");
                return;
            }
        }
    }
}