using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.Application.Catalog.Products.Dtos;
using TEDU.Application.Catalog.Products.Dtos.Public;
using TEDU.Application.Dtos;

namespace TEDU.Application.Catalog.Products
{
    public interface IPublicProductService
    {
         Task<PagedResult<ProductViewModel>> GetByAllCategoryId(GetProductPagingRequest request);
    }
}
