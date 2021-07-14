using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEDU.Data.Entities;
using TEDU.ViewModels.System.Roles;

namespace TEDU.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManeger;
        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManeger = roleManager;
        }
        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManeger.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToListAsync();

            return roles;
        }
    }
}
