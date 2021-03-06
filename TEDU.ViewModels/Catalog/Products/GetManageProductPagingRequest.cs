﻿using System;
using System.Collections.Generic;
using System.Text;
using TEDU.ViewModels.Common;

namespace TEDU.ViewModels.Catalog.ProductsImages
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
