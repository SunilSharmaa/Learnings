using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area_and_Perimeter
{
    class Circle : IShape
    {
        public decimal Radius { get; set; }
        public decimal PI = 3.14M;

        public void GetRadiusOfCircle ()
        {
            Console.Write("Enter radius of circle: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal temp) && temp > 0)
            {
                Radius = temp;
            }
            else
            {
                Console.WriteLine("Please enter valid integer input");
            }
        }

        public void CalculateArea ()
        {
            decimal area = PI * (Radius * Radius);
            Console.WriteLine("Area of circle : {0}", area);
        }

        public void CalculatePerimeter ()
        {
            decimal perimeter = 2 * PI * Radius;
            Console.WriteLine("Perimeter of circle : {0}", perimeter);
        }
    }
}
