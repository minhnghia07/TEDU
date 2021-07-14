using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEDU.ViewModels.System.Languages;

namespace TEDU.Admin.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }
        public string CurrentLanguageId { get; set; }
    }
}
