using System;
using System.Collections.Generic;
using System.Text;
using TEDU.ViewModels.Common;

namespace TEDU.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
