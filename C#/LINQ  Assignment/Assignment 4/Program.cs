namespace Assignment_4
{
    class Program
    {
        static void Main()
        {
            Product product = new Product();

            Console.Write("How many product you want to add: ");
            int size = 0;

            if(int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
            {
                size = temp;
                product.AddProduct(size);
                product.GetProductAbove50();
            }

            else
            {
                Console.WriteLine("Please enter valid integer number.");
            }
        }
    }
}