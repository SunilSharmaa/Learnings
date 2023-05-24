namespace Assessment_2
{
    class AreaOfRectangle
    {
        //defining function to calculate the area of rectangle
        public static void AreaRectangle(int length, int width)
        {
            int area = length * width;
            Console.WriteLine("Area of Rectangle = " + area);
        }

        //defining function to calculate the perimeter of rectangle
        public static void PerimeterRectangle(int length, int width)
        {
            int perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter of Rectangle = " + perimeter);
        }
        public static void Main()
        {
            //declaring the variables
            int length, width;

            //taking length and width from the user
            Console.WriteLine("Enter the following details of Rectangle");
            Console.Write("length: ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width: ");
            width = Convert.ToInt32(Console.ReadLine());

            //calling the function where we have defined the logic
            AreaRectangle(length, width);
            PerimeterRectangle(length, width);

        }
        
    }
}