using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            //Oracle, MongoDB, Postgre,SQL Server, MySQL
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Lenovo Legion", UnitPrice=39999, UnitsInStock=4 },
                new Product{ProductId=2, CategoryId=1, ProductName="Acer Nitro 5", UnitPrice=29999, UnitsInStock=5 },
                new Product{ProductId=3, CategoryId=2, ProductName="Dell Latitude", UnitPrice=19999, UnitsInStock=7 },
                new Product{ProductId=4, CategoryId=2, ProductName="Lenovo Yoga 7", UnitPrice=34999, UnitsInStock=2 },
                new Product{ProductId=5, CategoryId=3, ProductName="HP Victus", UnitPrice=41999, UnitsInStock=6 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //Lambda 
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAllByUnitPriceRange(int min, int max)
        {
            return _products.Where(p => p.UnitPrice <= max && p.UnitPrice >= min).ToList();
        }

        public Product GetByCategoryId(int categoryId)
        {
            return _products.First(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
