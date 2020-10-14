using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ProductWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }



        [HttpGet("getall")]
        public ActionResult<IEnumerable<ProductDTOGetAll>> GetAll()
        {
            return Ok(_productServices.GetAll());

        }

        [HttpGet("get")]
        public ActionResult<Product> Get(Guid id)
        {
            var dbProduct = _productServices.Get(id);

            if (dbProduct == null) return null;
            return Ok(dbProduct);
        }

        [HttpPost("add")]
        public ActionResult<Product> Add([FromBody]ProductDTOAdd item)
        {
            var newProduct = _productServices.Add(item);
            if (newProduct == null) return BadRequest();
            return Ok(newProduct);
        }


        [HttpPut("edit")]
        public ActionResult<Product> Edit([FromBody]ProductDTOEdit item)
        {
            var dboProduct = _productServices.Edit(item);

            if (dboProduct == null) return BadRequest();
            return Ok(dboProduct);

        }

        [HttpDelete("delete")]
        public ActionResult<bool> Delete(Guid id)
        {
            return _productServices.Delete(id);

        }

    }
}
