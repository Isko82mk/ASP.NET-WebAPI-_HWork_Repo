using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<ProductDTOGetAll> GetAll();
        Product Get(Guid id);
        Product Add(ProductDTOAdd item);
        Product Edit(ProductDTOEdit item);
        bool Delete(Guid id);
    }
}
