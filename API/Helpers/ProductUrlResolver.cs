using API.Dtos;
using AutoMapper;
using CORE.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.Photos.FirstOrDefault(p => p.IsMain).ImageUrl))
            {
                return _config["ApiUrl"] + source.Photos.FirstOrDefault(p => p.IsMain).ImageUrl;
            }
            return null;
        }
    }
}
