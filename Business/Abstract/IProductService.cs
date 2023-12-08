using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); 
        IDataResult<Product> GetByCategoryId(int id);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPriceRange(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(int productId);
        IResult DeleteByCategoryId(int categoryId);

        //List<Product> GetAll();
        //Product GetByCategoryId(int id);
        //List<Product> GetAllByCategoryId(int id);
        //List<Product> GetAllByUnitPriceRange(decimal min, decimal max);
        //List<ProductDetailDto> GetProductDetails();

        //Daha önce ürünler için DAL imzaları oluşturmuştuk, 
        //Şimdi Generic Repository Design Patterni takip ederek yapıyı tekrar tasarlamış oluyoruz.
    }
}
