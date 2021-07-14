using System;
using System.Collections.Generic;
using TEDU.ViewModels.Common;

namespace TEDU.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}
