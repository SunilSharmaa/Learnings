namespace Assignment_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter list of string (separate with coma): ");
            string listOfString = Console.ReadLine();

            if (string.IsNullOrEmpty(listOfString))
            {
                Console.WriteLine("input cannot be empty or null.");
                return;
            }

            else
            { }

            string[] arrayOfStrings = listOfString.Split(',');


            //linq query
            var stringConstainsA = from i in arrayOfStrings
                                   where i.Contains("a") && i.Length > 5 || i.Contains("A") && i.Length > 5
                                   select i;

            Console.WriteLine("\nList of string that contains letter A or a and length greater than 5");
            foreach ( var i in stringConstainsA )
            {
                Console.WriteLine(i);
            }
        }
    }
}