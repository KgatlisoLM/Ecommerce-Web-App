using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Specifications
{
    public class ProductSpecification : BaseSpecification<Product>
    {
     

        public ProductSpecification(ProductSpecParams productParams) :
            base(x => 
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
                (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId) &&
                (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId)
               )
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.Photos);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceThenAsc":
                        AddThenBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    case "priceThenDesc":
                        AddThenByDescending(p => p.Price);
                        break;

                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }

        }

        public ProductSpecification(int id) : base(x =>x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.Photos);
        }



    }
}
