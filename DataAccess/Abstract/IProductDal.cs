using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityFrameworkRepository<Product>
    {
        List<ProductDetailDto> GetDetails();
    }
}
