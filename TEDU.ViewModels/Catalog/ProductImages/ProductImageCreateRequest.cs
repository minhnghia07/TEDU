﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TEDU.Application.Catalog.ProductImages
{
    public class ProductImageCreateRequest
    {
      
       
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOder { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
