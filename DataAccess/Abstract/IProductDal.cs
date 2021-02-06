using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface default public değildir methodları operasyonları publictir
    public interface IProductDal:IEntityRepository<Product>
    {
        

    } 
}
//Code Refactoring