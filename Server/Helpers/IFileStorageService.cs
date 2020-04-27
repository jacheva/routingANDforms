using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Helpers
{
    public interface IFileStorageService
    {
        Task<string> EditFile(byte[] content, string extension, string containterName, string fileRoute);
        Task DeleteFile(string fileRoute, string containterName);
        Task<string> SaveFile(byte[] content, string extension, string containerName);

    }
}
