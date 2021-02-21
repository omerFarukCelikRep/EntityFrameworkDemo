using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
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

            //GetProductsByCategoryId(2);

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"{product.ProductID} {product.ProductName} {product.QuantityPerUnit}");
            }
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
