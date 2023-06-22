using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private List<Person> PersonList1;
        private List<Person> PersonList2;

        public Person ()
        {
            PersonList1 = new List<Person> ();
            PersonList2 = new List<Person> ();
        }

        public void GetPersonDetails (int sizeOfList1, int sizeOfList2)
        {
            Console.WriteLine("\nEnter following details in List 1");
            for (int i = 0; i < sizeOfList1; i++)
            {
                Person person = new Person ();
                Console.WriteLine("\nDeatails of Person no. {0}", i + 1);
                Console.Write("Name: ");

                string tempName = Console.ReadLine ();

                if (string.IsNullOrEmpty (tempName))
                {
                    Console.WriteLine("Name Cannot be empty or null");
                }

                else
                {
                    person.Name = tempName;
                }

                Console.Write("Age: ");

                if (int.TryParse(Console.ReadLine(), out int tempAge) && tempAge > 0)
                {
                    person.Age = tempAge;
                }

                else
                {
                    Console.WriteLine("Invalid input, Please enter valid age");
                    return;
                }

                PersonList1.Add(person);
            }

            Console.WriteLine("\nEnter following details in List 2");
            for (int i = 0; i < sizeOfList2; i++)
            {
                Person person = new Person();
                Console.WriteLine("\nDeatails of Person no. {0}", i + 1);
                Console.Write("Name: ");

                string tempName = Console.ReadLine();

                if (string.IsNullOrEmpty(tempName))
                {
                    Console.WriteLine("Name Cannot be empty or null");
                }

                else
                {
                    person.Name = tempName;
                }

                Console.Write("Age: ");

                if (int.TryParse(Console.ReadLine(), out int tempAge) && tempAge > 0)
                {
                    person.Age = tempAge;
                }

                else
                {
                    Console.WriteLine("Invalid input, Please enter valid age");
                    return;
                }

                PersonList2.Add(person);
            }
        }

        public void GetCommonPerson ()
        {
            var commonPerson = from list1 in PersonList1
                               join list2 in PersonList2 on new { list1.Name, list1.Age } equals new { list2.Name, list2.Age }
                               select list1;

            Console.WriteLine("\n-----------\nList of common people are:\n------------\n");
            foreach (var person in commonPerson)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
            }
        }
    }
}
