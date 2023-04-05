using Ticket_reader_demo.Services;
using BlazorInputFile;

namespace Ticket_reader_demo.Data
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webhost)
        {
            _webHostEnvironment = webhost;
        }

        public async Task UploadFile(IFileListEntry file)
        {
            var path = Path.Combine(_webHostEnvironment.ContentRootPath, "UploadloadedFiles", file.Name);
            var MemStream = new MemoryStream();
            await file.Data.CopyToAsync(MemStream);
            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                MemStream.WriteTo(fs);
            }
        }
    }
}
