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
    public class PhotosUrlResolver : IValueResolver<ProductPhotos, ProductPhotoReturnDto, string>
    {
        private readonly IConfiguration _config;

        public PhotosUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(ProductPhotos source, ProductPhotoReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ImageUrl))
            {
                return _config["ApiUrl"] + source.ImageUrl;
            }
            return null;
        }
    }
}
