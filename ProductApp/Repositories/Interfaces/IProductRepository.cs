using Models;
using Models.DTO;
using System;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductDTOGetAll> GetAll();
        Product Get(Guid id);
        Product Add(ProductDTOAdd item);
        Product Edit(ProductDTOEdit item);
        bool Delete(Guid id);


    }
}
