using BlazorInputFile;
namespace Ticket_reader_demo.Services
{
    public interface IFileUpload
    {
        Task UploadFile(IFileListEntry file);
    }
}
