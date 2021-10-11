using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal listing { get; set; }
        public string Description { get; set; }
        public bool isRelated { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
        public IReadOnlyList<ProductPhotos> Photos { get; set; }



    }
}
