using Models;
using Models.DTO;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Services
{
   public class ProductService : IProductServices
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


     
        public IEnumerable<ProductDTOGetAll> GetAll()
        {
           return _productRepository.GetAll();
        }

        public Product Get(Guid id)
        {
          return  _productRepository.Get(id);
        }

        public Product Add(ProductDTOAdd item)
        {
            return _productRepository.Add(item);
        }

        public Product Edit(ProductDTOEdit item)
        {
           return _productRepository.Edit(item);
        }

        public bool Delete(Guid id)
        {
            return _productRepository.Delete(id);
        }






    }
}
