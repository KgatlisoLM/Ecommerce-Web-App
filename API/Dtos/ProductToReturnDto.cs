using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal listing { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool isRelated { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
        public IReadOnlyList<ProductPhotoReturnDto> Photos { get; set; }
    }
}
