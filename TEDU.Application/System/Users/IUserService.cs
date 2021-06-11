using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.ViewModels.Common;
using TEDU.ViewModels.System.Users;

namespace TEDU.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request);
        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
        Task<ApiResult<UserVm>> GetById(Guid id);
    }
}
