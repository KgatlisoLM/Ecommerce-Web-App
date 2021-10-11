using API.Dtos;
using AutoMapper;
using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(b => b.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(b => b.ImageUrl, o => o.MapFrom<ProductUrlResolver>())
                .ForMember(b => b.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name));

            CreateMap<ProductPhotos, ProductPhotoReturnDto>()
               .ForMember(e => e.ImageUrl, o => o.MapFrom<PhotosUrlResolver>());

            CreateMap<CustomerBasketDto, CustomerBasket>();
            CreateMap<BasketItemDto, BasketItem>();

        }
    }
}
