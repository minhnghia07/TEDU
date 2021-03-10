using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
namespace TEDU.Application.Common
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);
    }
}
