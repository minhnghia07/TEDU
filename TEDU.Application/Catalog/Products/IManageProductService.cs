using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.Application.Catalog.Products.Dtos;
using TEDU.Application.Catalog.Products.Dtos.Manage;
using TEDU.Application.Dtos;

namespace TEDU.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request); // trả về kiểu int

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int ProductId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

      
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);


    }
}
