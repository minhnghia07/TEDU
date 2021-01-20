using System;
using System.Collections.Generic;
using System.Text;
using TEDU.Application.Dtos;

namespace TEDU.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
