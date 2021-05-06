using System;
using System.Collections.Generic;
using System.Text;
using TEDU.ViewModels.Common;

namespace TEDU.ViewModels.Catalog.ProductsImages
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        
        public int? CategoryId { get; set; }
        
    }
}
