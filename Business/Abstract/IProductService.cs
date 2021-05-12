using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); 
        List<Product> GetAllByCategoryId(int id); 
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails(); 
        void Add(Product product); 
        Product GetById(int productId);
        void Update(Product product);
    }
}
