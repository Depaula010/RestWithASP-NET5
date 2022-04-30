using Microsoft.AspNetCore.Http;
using RestWithASP_NET5.Data.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5.Business.Implementations
{
    public class FileBusinessImplementation : IFileBusiness
    {
        private readonly string _basePath;
        private readonly IHttpContextAccessor _context;
        private List<string> _extensoesPermitidas = new List<string>() { ".pdf", ".jpg", ".png", ".jpeg" };

        public FileBusinessImplementation(IHttpContextAccessor context)
        {
            _context = context;
            _basePath = Directory.GetCurrentDirectory() + "\\UploadDir\\";
        }
        public byte[] GetFile(string fileName)
        {
            throw new NotImplementedException();
        }
        public async Task<FileDatailVO> SaveFileToDisk(IFormFile file)
        {
            FileDatailVO fileDetail = new FileDatailVO();

            string fileType = Path.GetExtension(file.FileName);
            HostString baseUrl = _context.HttpContext.Request.Host;

            if (_extensoesPermitidas.Contains(fileType.ToLower()))
            {
                string docName = Path.GetFileName(file.FileName);
                if(file != null & file.Length > 0)
                {
                    string destination = Path.Combine(_basePath, "", docName);
                    fileDetail.DocumentName = docName;
                    fileDetail.DocType = fileType;
                    fileDetail.DocUrl = Path.Combine(baseUrl + "/api/file/v1" + fileDetail.DocumentName);

                    using FileStream stream = new FileStream(destination, FileMode.Create);
                    await file.CopyToAsync(stream);
                }
            }
            return fileDetail;
        }

        public async Task<List<FileDatailVO>> SaveFilesToDisk(IList<IFormFile> files)
        {
            List<FileDatailVO> list = new List<FileDatailVO>();
            foreach (IFormFile file in files)
            {
                list.Add(await SaveFileToDisk(file));
            }
            return list;
        }

    }
}
