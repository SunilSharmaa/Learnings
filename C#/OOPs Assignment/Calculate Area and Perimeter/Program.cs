namespace Calculate_Area_and_Perimeter
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Circle \n2. Rectangle \n3. Triangle \n4. Exit");
                Console.Write("Enter your choice: ");

                int choice = 0;
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    choice = temp;
                }

                else
                {
                    Console.WriteLine("Enter valid integer number");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("-------------");
                        Circle circle = new Circle();
                        circle.GetRadiusOfCircle();
                        circle.CalculateArea();
                        circle.CalculatePerimeter();
                        Console.WriteLine("-------------");
                        break;
                    case 2:
                        Console.WriteLine("-------------");
                        Rectangle rectangle = new Rectangle();
                        rectangle.GetLengthAndWidthRectangle();
                        rectangle.CalculateArea();
                        rectangle.CalculatePerimeter();
                        Console.WriteLine("-------------");
                        break;
                    case 3:
                        Console.WriteLine("-------------");
                        Triangle triangle = new Triangle();
                        triangle.GetBaseAndHeightTriangle();
                        triangle.CalculateArea();
                        triangle.CalculatePerimeter();
                        Console.WriteLine("-------------");
                        break;
                    case 4:
                        Console.WriteLine("-------------");
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Please enter valid number (1-4)");
                        Console.WriteLine("-------------");
                        break;
                }
            }
        }
    }
}