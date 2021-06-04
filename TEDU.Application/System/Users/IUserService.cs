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
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<PagedResult<UserVm>> GetUserPaging(GetUserPagingRequest request);
    }
}
