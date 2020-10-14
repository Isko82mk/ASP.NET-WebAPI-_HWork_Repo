using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class ProductDTOEdit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductType Type { get; set; }
         

    }
}
