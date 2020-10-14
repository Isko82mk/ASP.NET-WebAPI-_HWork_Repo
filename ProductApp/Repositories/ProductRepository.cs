using EntetyDB;
using Models;
using Models.DTO;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {

        private DataDBContex _dbContext;

        public ProductRepository(DataDBContex dbContext)
        {
            _dbContext = dbContext;
        }

   

        ///getAllProducts 

        public IEnumerable<ProductDTOGetAll> GetAll()
        {

            var products = _dbContext.Products
                  .Select(x => new ProductDTOGetAll()
                  {
                      Id = x.Id,
                      Name = x.Name,
                      Price = x.Price,
                      isStock = x.isStock

                  }).AsEnumerable();
            return products;
        }


        ///getProduct(id)

        public Product Get(Guid id)
        {
          return _dbContext.Products.FirstOrDefault(x => x.Id == id);
           
        }


        ///addProduct()


        public Product Add(ProductDTOAdd item)
        {
            var newProduct = new Product()
            {
                Name = item.Name,
                Price=item.Price,
                Type=item.Type,
                isStock = item.isStock,
            };


            _dbContext.Products.Add(newProduct);
            _dbContext.SaveChanges();

            return newProduct;
        }

         //Update

        public Product Edit(ProductDTOEdit item)
        {
            var dbNote = _dbContext.Products.FirstOrDefault(x => x.Id == item.Id);

            if (dbNote == null) return null;

            dbNote.Name = item.Name;
            dbNote.Price = item.Price;
            dbNote.Type = item.Type;

            _dbContext.Products.Update(dbNote);
            _dbContext.SaveChanges();

            return dbNote;
        }
        //delete
        public bool Delete(Guid id)
        {
       
         var dbProduct =_dbContext.Products.FirstOrDefault(x=>x.Id == id);

            if (dbProduct == null) return false;

            _dbContext.Products.Remove(dbProduct);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
