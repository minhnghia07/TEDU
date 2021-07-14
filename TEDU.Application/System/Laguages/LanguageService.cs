using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEDU.Data.EF;
using TEDU.ViewModels.Common;
using TEDU.ViewModels.System.Languages;

namespace TEDU.Application.System.Laguages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _config;
        private readonly TEDUDbContext _context;

        public LanguageService(TEDUDbContext context, IConfiguration config)
        {
            _config = config;
            _context = context;
        }
        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}
