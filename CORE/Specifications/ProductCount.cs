using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CORE.Specifications
{
    public class ProductCount : BaseSpecification<Product>
    {
        public ProductCount(ProductSpecParams productParams) : base( x =>
           (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
            (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId) &&
            (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId)
        )
        {
        }
    }
}
