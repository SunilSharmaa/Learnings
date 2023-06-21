using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Product
    {
        private List<ProductProperties> productList;

        public Product()
        {
            productList = new List<ProductProperties>();
        }

        public void AddProduct(int size)
        {
            ProductProperties properties = new ProductProperties();

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("------------------\nEnter following details of product no. {0}", i + 1);
                Console.Write("Product Name: ");

                string temp = Console.ReadLine();

                if (! string.IsNullOrEmpty(temp))
                {
                    properties.Name = temp;
                }

                else
                {
                    Console.WriteLine("name cannot be empty or null");
                    return;
                }

                Console.Write("Category: ");
                temp = Console.ReadLine();

                if (! string.IsNullOrEmpty(temp))
                {
                    properties.Category = temp;
                }

                else
                {
                    Console.WriteLine("cannot be empty or null");
                }

                Console.Write("Price: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal temp2) && temp2 > 0)
                {
                    properties.Price = temp2;
                }

                else
                {
                    Console.WriteLine("Invalid Input");
                }

                productList.Add(properties);
            }
        }

        //methods for geting
        public void GetProductAbove50 ()
        {
            Console.WriteLine("------------------\nList of Product above $50");

            //linq query for geting the list of product above $50

            var listOfProductAbove50 = from i in productList
                                       where i.Price > 50
                                       select i;

            foreach (var product in listOfProductAbove50)
            {
                Console.WriteLine("--------\n");
                Console.WriteLine("Product Name: {0} \n" +
                                  "Category: {1} \n" +
                                  "Price: ${2}", product.Name, product.Category, product.Price);
            }
        }
    }
}
