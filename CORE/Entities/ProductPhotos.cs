using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Entities
{
    public class ProductPhotos : BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}
