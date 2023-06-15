using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area_and_Perimeter
{
    class Rectangle : IShape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public void GetLengthAndWidthRectangle ()
        {
            Console.Write("Enter length of rectangle: ");
            if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
            {
                Length = temp;
            }
            else
            {
                Console.WriteLine("Enter valid integer number");
            }

            Console.Write("Enter width of rectangle: ");
            if (int.TryParse(Console.ReadLine(), out int temp2) && temp2 > 0)
            {
                Width = temp2;
            }
        }

        public void CalculateArea ()
        {
            int area = Width * Length;
            Console.WriteLine("Area of rectangle: {0}", area);
        }

        public void CalculatePerimeter ()
        {
            int perimeter = 2 * (Length + Width);
            Console.WriteLine("Perimeter of rectangle: {0}", perimeter);
        }
    }
}
