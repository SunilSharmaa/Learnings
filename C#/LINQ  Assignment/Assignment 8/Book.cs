using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Book
    {
        private List<BookProperties> BookList;

        public Book()
        {
            BookList = new List<BookProperties>();
        }

        public void GetBookDetails (int size)
        {
            for (int i = 0; i < size; i++)
            {
                BookProperties bookProperties = new BookProperties();

                Console.WriteLine("\n---------------\nEnter the following details of book no. {0}", i + 1);
                Console.Write("Title: ");

                string temp = Console.ReadLine();

                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Title cannot be empty or null.");
                    return;
                }

                else
                {
                    bookProperties.Title = temp;
                }

                Console.Write("Author: ");
                temp = Console.ReadLine();

                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Author name cannot be empty or null.");
                    return;
                }

                else
                {
                    bookProperties.Author = temp;
                }

                Console.Write("Publication Year: ");
                
                if (int.TryParse(Console.ReadLine(), out int temp2) && temp2 > 1899 && temp2 < 2024)
                {
                    bookProperties.PublicationYear = temp2;
                }

                else
                {
                    Console.WriteLine("Please enter valid year");
                    return;
                }

                BookList.Add(bookProperties);
            }
        }

        public void ShowBooksBefore2000 ()
        {
            //linq query

            var booksBefore2000 = from i in BookList
                                  where i.PublicationYear < 2000
                                  select i;

            Console.WriteLine("---------------------\nList of books published before year 2000");

            foreach (var i in booksBefore2000)
            {
                Console.WriteLine("------------");
                Console.WriteLine("Book Title: {0}", i.Title);
                Console.WriteLine("Author: {0}", i.Author);
                Console.WriteLine("Year: {0}", i.PublicationYear);
            }
        }
    }

    
}
