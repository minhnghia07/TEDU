using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.Application.Catalog.ProductImages;
using TEDU.ViewModels.Catalog.ProductsImages;
using TEDU.ViewModels.Common;

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

        Task<ProductViewModel> GetById(int productId, string languageId);

      
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        //thêm riêng ảnh
        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<List<ProductImageViewModel>> GetListImages(int productId);



    }
}
