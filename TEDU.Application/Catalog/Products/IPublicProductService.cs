using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.ViewModels.Catalog.Products;
using TEDU.ViewModels.Common;

namespace TEDU.Application.Catalog.Products
{
    public interface IPublicProductService
    {
         Task<PagedResult<ProductViewModel>> GetByAllCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
