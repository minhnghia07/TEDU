using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEDU.ViewModels.Common;
using TEDU.ViewModels.System.Languages;

namespace TEDU.Admin.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
