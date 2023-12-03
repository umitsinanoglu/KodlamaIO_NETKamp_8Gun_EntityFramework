using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUi
{
    public class Program
    {
        //SOLID 
        //Open Close Principle
        static void Main(string[] args)
        {
            //Data Transformation Objects
            ProductManagerTest();
            //IoC
            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductManagerTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
            Console.WriteLine("*******************************************");
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("*******************************************");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("*******************************************");
            Console.WriteLine(productManager.GetByCategoryId(3).ProductName);
            Console.WriteLine("*******************************************");
            foreach (var product in productManager.GetAllByUnitPriceRange(9000, 29000))
            {
                Console.WriteLine(product.ProductName + "-" + product.UnitPrice);
            }
        }
    }
}
