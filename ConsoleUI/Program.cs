using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();

            GetProductsByCategoryId(2);
        }

        private static void GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                foreach (Product product in context.Products)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }
        private static void GetProductsByCategoryId(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.Where(p => p.CategoryID == categoryId);

                foreach (Product product in result)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }
    }
}
