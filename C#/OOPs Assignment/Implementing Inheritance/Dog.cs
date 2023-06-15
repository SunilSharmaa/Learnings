using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Inheritance
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public void GetDogDetails ()
        {
            Console.WriteLine("-------------- \nEnter following details of a Dog");
            
            
            
                Console.Write("Breed: ");
                string temp = Console.ReadLine();
                if  (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("cannot be null or empty");
                    return;
                }
                else
                {
                    Breed = temp;
                }

                Console.Write("Name: ");
                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("cannot be null or empty");
                    return;
                }
                else
                {
                    Name = temp;
                }

                Console.Write("Age: ");
                if (int.TryParse(Console.ReadLine(), out int tempAge) && tempAge > 0)
                {
                    Age = tempAge;
                }
                else
                {
                    Console.WriteLine("Please enter valid number");
                    return;
                }
            
        }

        public override void AnimalSound()
        {
            Console.WriteLine($"\nI have a Dog {Breed} who is {Age} years old. It makes the sound 'Woof!'");
            Console.WriteLine("------------");
        }
    }
}
