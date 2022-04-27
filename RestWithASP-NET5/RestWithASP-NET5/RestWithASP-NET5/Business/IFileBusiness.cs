using Microsoft.AspNetCore.Http;
using RestWithASP_NET5.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string fileName);
        public Task<FileDatailVO> SaveFileToDisk(IFormFile file);
        public Task<List<FileDatailVO>> SaveFilesToDisk(IList<IFormFile> file);
    }
}
