using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface default public değildir methodları operasyonları publictir
    public interface IProductDal : IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();
    }
         
}
//Code Refactoring