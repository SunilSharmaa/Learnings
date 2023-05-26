namespace Classes_And_Function_2
{
    class Rectangle
    {
        //declaring properties
        private int length = 0;
        private int width = 0;

        //method for taking length and width from the user
        public void GetLengthWidth ()
        {
            Console.Write("Length : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width : ");
            width = Convert.ToInt32(Console.ReadLine());

        }

        //defining method for calculating area of rectangle
        public int AreaRectangle ()
        {
            int area = length * width;
            return area;
        }

        //defining method for calculating perimeter of rectangle
        public int PerimeterRectangle ()
        {
            int perimeter = 2 * (length + width);
            return perimeter;
        }

        static void Main()
        {
            //asking user to enter details
            Console.WriteLine("Enter the following details of the Rectangle");

            //will create object of class Rectangle
            Rectangle rect1 = new Rectangle();

            //calling method to get the length and width of the rectangle
            rect1.GetLengthWidth();

            //receiving area and perimeter and displaying it

            int area = rect1.AreaRectangle();
            int perimeter = rect1.PerimeterRectangle();

            Console.WriteLine("\n\nArea of Rectangle : {0}", area);
            Console.WriteLine("Perimeter of Rectangle : {0}", perimeter);
        }
    }
}