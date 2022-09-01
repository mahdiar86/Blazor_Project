using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace Blazor_Project.Presentation.Service.IService
{
    public interface IFileUploadService
    {
        Task<string> UploadFile(IBrowserFile file);
        bool DeleteFile(string fileName);
    }
}