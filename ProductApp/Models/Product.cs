using Models.Enums;
using System;

namespace Models
{
    public class Product
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductType Type { get; set; }
        public bool isStock { get; set; }
      
      
    }
}
