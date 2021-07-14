using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEDU.ViewModels.Common;
using TEDU.ViewModels.System.Languages;

namespace TEDU.Application.System.Laguages
{
    public interface ILanguageService
    {
      
        Task<ApiResult<List<LanguageVm>>> GetAll();
       
    }
}
