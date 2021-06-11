using System;
using System.Collections.Generic;
using System.Text;

namespace TEDU.ViewModels.Common
{
    //check tài khoản đăng ký chưa
    public class ApiResult<T>
    {
        public bool IsSuccessed { get; set; }
        public string Message { get; set; }
        public T ResultObj { get; set; }
    }
}
