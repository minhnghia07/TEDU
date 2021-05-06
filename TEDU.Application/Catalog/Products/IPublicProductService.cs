using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.ViewModels.Catalog.ProductsImages;
using TEDU.ViewModels.Common;

namespace TEDU.Application.Catalog.Products
{
    public interface IPublicProductService
    {
         Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

    }
}
