using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area_and_Perimeter
{
    class Triangle : IShape
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public void GetBaseAndHeightTriangle ()
        {
            Console.Write("Enter Base of Triangle: ");
            if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
            {
                Base = temp;
            }
            else
            {
                Console.WriteLine("Enter valid integer number");
            }

            Console.Write("Enter Height of Triangle: ");
            if (int.TryParse(Console.ReadLine(), out int temp2) && temp2 > 0)
            {
                Height = temp2;
            }
        }

        public void CalculateArea ()
        {
            decimal area = (decimal) (Base * Height) / 2;
            Console.WriteLine("Area of Triangle : {0}", area);
        }

        public void CalculatePerimeter ()
        {
            int perimeter = Height + Base + Height;
            Console.WriteLine("Perimeter of Triangle : {0}", perimeter);
        }
    }
}
