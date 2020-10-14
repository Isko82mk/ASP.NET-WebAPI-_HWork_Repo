using Models.Enums;

namespace Models.DTO
{
    public class ProductDTOAdd
    {

        public string Name { get; set; }
        public int Price { get; set; }
        public bool isStock { get; set; }
        public ProductType Type { get; set; }

    }
}
