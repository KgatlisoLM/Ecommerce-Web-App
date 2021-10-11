using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductPhotoReturnDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool isMain { get; set; }
    }
}
