using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEDU.ViewModels.System.Users;

namespace TEDU.Admin.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
