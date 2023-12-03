using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetByCategoryId(int id);
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByUnitPriceRange(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();

        //Daha önce ürünler için DAL imzaları oluşturmuştuk, 
        //Şimdi Generic Repository Design Patterni takip ederek yapıyı tekrar tasarlamış oluyoruz.
    }
}
